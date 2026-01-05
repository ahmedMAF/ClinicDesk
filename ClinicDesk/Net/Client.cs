using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicDesk.Net;

public class Client
{
    private TcpClient _client;
    
    public event Action RefreshUI;

    public async Task StartAsync()
    {
        _client = new TcpClient();
        await _client.ConnectAsync(Settings.Instance.Server, 8484);
        
        // Start listening for messages from the server.
        ListenForMessagesAsync();
    }

    public async Task SendAsync()
    {
        try
        {
            using NetworkStream stream = _client.GetStream();
            Span<byte> messageBytes = stackalloc byte[BufferSize];
            int bytesCount = Encoding.UTF8.GetBytes("DB_CHANGED".AsSpan(), messageBytes));
            await stream.WriteAsync(messageBytes, 0, bytesCount);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error sending message: {ex.Message}", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task ListenForMessagesAsync()
    {
        using NetworkStream stream = _client.GetStream();
        byte[] buffer = new byte[BufferSize];

        while (true)
        {
            try
            {
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                
                // Server disconnected.
                if (bytesRead == 0)
                    break;

                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                
                if (message == "REFRESH_UI")
                    RefreshUI?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error receiving message: {ex.Message}", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                break;
            }
        }
    }
}
