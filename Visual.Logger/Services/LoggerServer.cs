using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Visual.Logger.Services
{
    public static class LoggerServer
    {
        private static TcpListener _listener;
        private static bool _isRunning;

        // Событие для передачи сообщений в VisualLoggerForm
        public static event Action<string> MessageReceived;

        public static void Start(int port)
        {
            if (_isRunning)
                return;

            _listener = new TcpListener(IPAddress.Loopback, port);
            _listener.Start();

            _isRunning = true;

            // Запускаем слушающий цикл асинхронно
            _ = Task.Run(ListenLoop);
        }

        public static void Stop()
        {
            _isRunning = false;

            if (_listener != null)
                _listener.Stop();
        }

        private static async Task ListenLoop()
        {
            while (_isRunning)
            {
                try
                {
                    TcpClient client = await _listener.AcceptTcpClientAsync();
                    // Обработка клиента в отдельном Task
                    _ = Task.Run(() => HandleClient(client));
                }
                catch
                {
                    // Ловим исключения при остановке сервера
                    _isRunning = false;
                }
            }
        }

        private static void HandleClient(TcpClient client)
        {
            try
            {
                using (client)
                using (NetworkStream stream = client.GetStream())
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        // Передаём событие на форму
                        MessageReceived?.Invoke(line);
                    }
                }
            }
            catch
            {
                // Игнорируем ошибки клиента
            }
        }
    }
}
