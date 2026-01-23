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
        _timer = new Timer(Callback, null, TimeSpan.FromSeconds(10), TimeSpan.FromSeconds(30));
    }

    public static async Task<bool> TestApiUrl(string url)
    {
        using HttpClient httpClient = new();
        HttpResponseMessage response = await httpClient.GetAsync(url);

        return response.IsSuccessStatusCode;
    }

    public static async Task SendRemoveRequest(int id)
    {
        HttpResponseMessage response = await _httpClient.PostAsync(Settings.Instance.AppointmentApiUrl, JsonContent.Create(new Dictionary<string, int>{{ "id", id }}));

        response.EnsureSuccessStatusCode();
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

            response.EnsureSuccessStatusCode();

            Response? data = await response.Content.ReadFromJsonAsync<Response>(_options);

            if (data == null || data.Data.Count == 0)
                return;

            Requests.Clear();
            Requests.AddRange(data.Data);
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
