using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicDesk.Net;

public class Server
{
    private const int BufferSize = 32;

    private TcpListener _listener;
    private bool _isRunning;
    private List<TcpClient> _clients = new();

    public async Task StartAsync()
    {
        _listener = new TcpListener(IPAddress.Any, 8484);
        _listener.Start();
        _isRunning = true;

        while (_isRunning)
        {
            try
            {
                TcpClient client = await _listener.AcceptTcpClientAsync();
                _clients.Add(client);
                HandleClientAsync(client);
            }
            catch (SocketException ex)
            {
                MessageBox.Show($"Socket exception: {ex.Message}", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        _listener.Stop();
    }

    private async Task HandleClientAsync(TcpClient client)
    {
        using NetworkStream stream = client.GetStream();
        byte[] buffer = stackalloc byte[BufferSize];

        while (_isRunning)
        {
            try
            {
                int bytesRead = await stream.ReadAsync(buffer, 0, BufferSize);
                
                // Client disconnected
                if (bytesRead == 0)
                    break;

                string request = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                
                if (request == "DB_CHANGED")
                    BroadcastRefreshUI();
            }
            catch (Exception ex)
            {
                if (_isRunning)
                    MessageBox.Show(ex.Message, "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                break;
            }
        }

        _clients.Remove(client);
    }

    private async void BroadcastRefreshUI()
    {
        Span<byte> messageBytes = stackalloc byte[BufferSize];
        int bytesCount = Encoding.UTF8.GetBytes("REFRESH_UI".AsSpan(), messageBytes));

        List<Task> tasks = [];

        foreach (TcpClient client in _clients)
        {
            tasks.Add(Task.Run(async () =>
            {
                try
                {
                    NetworkStream stream = client.GetStream();
                    await stream.WriteAsync(messageBytes, 0, bytesCount);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending to client: {ex.Message}", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }));
        }

        // Wait for all messages to be sent.
        await Task.WhenAll(tasks);
    }

    public void Stop()
    {
        _isRunning = false;
        
        foreach (TcpClient client in _clients)
            client.Close();
        
        _listener?.Stop();
    }
}
