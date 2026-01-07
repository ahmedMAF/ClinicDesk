using System.Net.Sockets;
using System.Text;

namespace ClinicDesk.Net;

public class Client
{
    private TcpClient _client = null!;
    private readonly byte[] _dbChangedMessage;

    private bool _isRunning;

    public event Action? RefreshUI;

    public Client()
    {
        _dbChangedMessage = Encoding.UTF8.GetBytes(Server.DBChangedMessage);
    }

    public async Task StartAsync()
    {
        _client = new TcpClient();
        await _client.ConnectAsync(Settings.Instance.Server, Server.Port);
        _isRunning = true;

        // Start listening for messages from the server.
        _ = ListenForMessagesAsync();
    }

    public void Stop()
    {
        _client?.Dispose();
        _isRunning = false;
    }

    public async Task SendAsync()
    {
        try
        {
            await _client.GetStream().WriteAsync(_dbChangedMessage);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error sending message: {ex.Message}", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task ListenForMessagesAsync()
    {
        NetworkStream stream = _client.GetStream();
        byte[] buffer = new byte[Server.BufferSize];

        try
        {
            while (_isRunning)
            {
                int bytesRead = await stream.ReadAsync(buffer);

                // Server disconnected.
                if (bytesRead == 0)
                    break;

                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                MessageBox.Show($"\"{message}\"");

                if (message == Server.RefreshMessage)
                    RefreshUI?.Invoke();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error receiving message: {ex.Message}", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
