using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace VisualLoggerClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string server = "127.0.0.1";
            int port = 4000;

            try
            {
                var client = new TcpClient();
                await client.ConnectAsync(server, port);
                Console.WriteLine($"Connected to VisualLogger at {server}:{port}");

                var stream = client.GetStream();

                while (true)
                {
                    Console.Write("Message: ");
                    string message = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(message))
                        continue;

                    byte[] buffer = Encoding.UTF8.GetBytes(message + "\n");
                    await stream.WriteAsync(buffer, 0, buffer.Length);

                    if (message.Equals("/exit", StringComparison.OrdinalIgnoreCase))
                        break;
                }

                Console.WriteLine("Disconnected.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
