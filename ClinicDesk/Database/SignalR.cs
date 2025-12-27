using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.AspNetCore.Builder;

namespace ClinicDesk.Database;

public static class SignalR
{
    private static IHost _host;
    private static HubConnection _connection;

    public static ushort Port { get; private set; } = 8484;

    public static event Func<Task> DatabaseChanged;

    public static async Task Initialize()
    {
        if (Settings.Instance.IsServer)
            await StartServerAsync();
        
        // Both ends must act as client.
        // await StartClientAsync();
    }

    private static async Task StartClientAsync()
    {
        _connection = new HubConnectionBuilder()
            .WithUrl($"http://{Settings.Instance.Server}:{Port}/databaseHub")
            .WithAutomaticReconnect()
            .Build();

        _connection.On("DatabaseChanged", () =>
        {
            // This runs on background thread -> marshal to UI thread
            // Invoke((Action)(() => DatabaseChanged?.Invoke() ));
            DatabaseChanged?.Invoke();
        });

        await _connection.StartAsync();
    }

    private static async Task StartServerAsync()
    {
        /*_host = Host.CreateDefaultBuilder()
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseUrls($"http://+:{Port}");

                webBuilder.ConfigureServices(services =>
                {
                    services.AddSignalR();
                });

                webBuilder.Configure(app =>
                {
                    app.UseRouting();
                    app.UseEndpoints(endpoints => endpoints.MapHub<DatabaseHub>("/databaseHub"));
                });
            })
            .Build();

        await _host.StartAsync();*/
    }

    public static async Task StopServerAsync()
    {
        if (_host != null)
            await _host.StopAsync();

        if (_connection != null)
            await _connection.StopAsync();
    }
}

public class DatabaseHub : Hub { }
