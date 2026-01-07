using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClinicDesk.Net;

public class Server
{
    public const int BufferSize = 32;
    public const int Port = 8484;

    public const string RefreshMessage = "REFRESH_UI\n";
    public const string DBChangedMessage = "DB_CHANGED\n";

    private readonly List<TcpClient> _clients = [];
    private readonly Lock _clientsLock = new();

    private readonly byte[] _refreshMessage;
    private TcpListener _listener = null!;
    private bool _isRunning;

    public Server()
    {
        _refreshMessage = Encoding.UTF8.GetBytes(RefreshMessage);
    }

    public async Task StartAsync()
    {
        _listener = new TcpListener(IPAddress.Any, Port);
        _listener.Start();
        _isRunning = true;

        try
        {
            while (_isRunning)
            {
                TcpClient client = await _listener.AcceptTcpClientAsync();

                lock (_clientsLock)
                {
                    _clients.Add(client);
                }

                _ = HandleClientAsync(client);
            }
        }
        catch (SocketException ex)
        {
            MessageBox.Show($"Socket exception: {ex.Message}", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        _listener.Stop();
    }

    public void Stop()
    {
        _isRunning = false;

        foreach (TcpClient client in _clients)
            client.Close();

        _listener?.Stop();
    }

    private async Task HandleClientAsync(TcpClient client)
    {
        NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[BufferSize];

        try
        {
            while (_isRunning)
            {
                int bytesRead = await stream.ReadAsync(buffer);

                // Client disconnected.
                if (bytesRead == 0)
                    break;

                string request = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                MessageBox.Show($"\"{request}\"");

                if (request == DBChangedMessage)
                    await BroadcastRefreshUI(client);
            }
        }
        catch (IOException)
        {
            // Client disconnected normally.
        }
        catch (Exception ex)
        {
            if (_isRunning)
                MessageBox.Show(ex.Message, "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            client.Close();

            lock (_clientsLock)
            {
                _clients.Remove(client);
            }
        }
    }

    private async Task BroadcastRefreshUI(TcpClient exceptFor)
    {
        foreach (TcpClient client in _clients)
        {
            // Don't send refresh UI command to the client how caused the change
            // It will update locally.
            if (client == exceptFor)
                continue;

            try
            {
                NetworkStream stream = client.GetStream();
                await stream.WriteAsync(_refreshMessage);
            }
            catch (Exception ex)
            {
                client.Close();

                lock (_clientsLock)
                {
                    _clients.Remove(client);
                }

                MessageBox.Show($"Error sending to client: {ex.Message}", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
