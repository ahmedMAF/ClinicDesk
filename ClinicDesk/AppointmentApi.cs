using ClinicDesk.Database.Models;
using System.Net.Http.Json;
using Timer = System.Threading.Timer;

namespace ClinicDesk;

internal class AppointmentApi
{
    private static HttpClient _httpClient = null!;
    private static Timer _timer = null!;
    private static bool _isRunning;

    private static readonly List<AppointmentRequest> _requests = [];

    public static event Action? NewRequestsRecieved;

    public static void Initialize()
    {
        _httpClient = new HttpClient();
        _timer = new Timer(Callback, null, TimeSpan.Zero, TimeSpan.FromMinutes(10));
    }

    public static async Task<bool> TestApiUrl(string url)
    {
        HttpResponseMessage response = await _httpClient.GetAsync(url);

        return response.IsSuccessStatusCode;
    }

    public static async Task SendRemoveRequest(int id)
    {
        HttpResponseMessage response = await _httpClient.PostAsync(Settings.Instance.AppointmentApiUrl, JsonContent.Create(id));

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

            List<AppointmentRequest>? data = await response.Content.ReadFromJsonAsync<List<AppointmentRequest>>();

            if (data == null || data.Count == 0)
                return;

            _requests.AddRange(data);
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

public class AppointmentRequest
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Phone { get; set; } = null!;

    public Sex Sex { get; set; }
    public MaritalStatus MaritalStatus { get; set; }
    public DateTime DateOfBirth { get; set; }
}
