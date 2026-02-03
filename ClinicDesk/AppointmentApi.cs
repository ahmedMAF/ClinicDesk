using ClinicDesk.Database.Models;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Timer = System.Threading.Timer;

namespace ClinicDesk;

internal class AppointmentApi
{
    private static HttpClient _httpClient = null!;
    private static JsonSerializerOptions _options = null!;
    private static Timer _timer = null!;
    private static bool _isRunning;

    public static List<AppointmentRequest> Requests { get; private set; } = [];

    public static event Action? NewRequestsRecieved;

    public static void Initialize()
    {
        _options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        _options.Converters.Add(new JsonStringEnumConverter());

        _httpClient = new HttpClient();
        _timer = new Timer(Callback, null, TimeSpan.FromSeconds(10), TimeSpan.FromMinutes(10));
    }

    public static async Task<bool> TestApiUrl(string url)
    {
        HttpClient httpClient = new();

        try
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);
            return response.IsSuccessStatusCode;
        }
        catch
        {
            return false;
        }
        finally
        {
            httpClient.Dispose();
        }
    }

    public static async Task SendRemoveRequest(int id)
    {
        try
        {
            await _httpClient.PostAsync(Settings.Instance.AppointmentApiUrl, JsonContent.Create(new Dictionary<string, int>{{ "id", id }}));
        }
        catch
        {
        }
    }

    private static async void Callback(object? state)
    {
        // prevent overlapping calls.
        if (_isRunning)
            return;

        _isRunning = true;

        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync(Settings.Instance.AppointmentApiUrl);

            if (!response.IsSuccessStatusCode)
            {
                _isRunning = false;
                return;
            }

            Response? data = await response.Content.ReadFromJsonAsync<Response>(_options);

            if (data == null || data.Data.Count == 0)
                return;
            
            bool raiseEvent = false;
            
            foreach (AppointmentRequest req in data.Data)
                if (!Requests.Contains(req))
                    raiseEvent = true;

            Requests.Clear();
            Requests.AddRange(data.Data);
            
            if (raiseEvent)
                NewRequestsRecieved?.Invoke();
        }
        catch
        {   
        }
        finally
        {
            _isRunning = false;
        }
    }

    public static void Shutdown()
    {
        _httpClient?.Dispose();
    }
}

public class Response
{
    public bool Success { get; set; }
    public List<AppointmentRequest> Data { get; set; } = null!;
}

public class AppointmentRequest
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Phone { get; set; } = null!;

    public Sex Sex { get; set; }
    public MaritalStatus MaritalStatus { get; set; }
    public DateTime DateOfBirth { get; set; }
    public BloodType BloodType  { get; set; }
}
