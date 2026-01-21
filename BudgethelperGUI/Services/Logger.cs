using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;

namespace BudgetHelper.Services
{
    public static class Logger
    {
        private static TcpClient _client;
        private static NetworkStream _stream;

        public static void Initialize()
        {
            try
            {
                _client = new TcpClient("127.0.0.1", 4000);
                _stream = _client.GetStream();
            }
            catch
            {
                // Логгер критичен
                throw new Exception("Visual.Logger is not running (localhost:4000)");
            }
        }

        public static void SendMessage(string message, Color? color = null)
        {
            if (_stream == null) return;

            string payload =
                $"{DateTime.Now:HH:mm:ss}|{color?.ToArgb() ?? Color.White.ToArgb()}|{message}\n";

            byte[] data = Encoding.UTF8.GetBytes(payload);
            _stream.Write(data, 0, data.Length);
        }

        public static void Shutdown()
        {
            try
            {
                SendMessage("BudgetHelper shutting down", Color.Gray);
                _stream?.Close();
                _client?.Close();
            }
            catch { }
        }
    }
}
