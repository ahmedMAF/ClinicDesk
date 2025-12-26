using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.SignalR.Client;

namespace ClinicDesk.Database;

public static class SignalR
{
    private static IHost _host;
    private static HubConnection _connection;

    public static ushort Port { get; private set; } = 8484;

    public static event Action DatabaseChanged;

    public static async Task Initialize()
    {
        if (Setting.Instance.Server is "127.0.0.1" or "localhost")
            await StartServerAsync();
        
        // Both ends must act as client.
        await StartClientAsync();
    }

    private static async Task StartClientAsync()
    {
        _connection = new HubConnectionBuilder()
            .WithUrl($"http://{Setting.Instance.Server}:{Port}/databaseHub")
            .WithAutomaticReconnect()
            .Build();

        _connection.On("DatabaseChanged", () =>
        {
            // This runs on background thread -> marshal to UI thread
            Invoke((Action)(() => DatabaseChanged?.Invoke() ));
        });

        await _connection.StartAsync();
    }

    private static async Task StartServerAsync()
    {
        _host = Host.CreateDefaultBuilder()
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseUrls($"http://+:{Port}");
                webBuilder.Configure(app =>
                {
                    app.UseRouting();
                    app.UseEndpoints(endpoints => endpoints.MapHub<DatabaseHub>("/databaseHub"));
                });
            })
            .Build();

        await _host.StartAsync();
    }

    public static async Task StopServerAsync()
    {
        if (_host != null)
            await _host.StopAsync();
            
        await _connection.StopAsync();
    }
}

public class DatabaseHub : Hub { }
