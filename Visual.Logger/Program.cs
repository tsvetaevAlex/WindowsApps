using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using Microsoft.Win32;
using Visual.Logger.Forms;
using Visual.Logger.Services;

namespace Visual.Logger
{
    static class Program
    {
        private const string RegistryKeyPath = @"Software\BudgetHelper";
        private const string RegistryPortName = "LoggerPort";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Получаем свободный порт
            int port = GetFreePort();

            // Сохраняем порт в реестр для Budgethelper
            using (var key = Registry.CurrentUser.CreateSubKey(RegistryKeyPath))
            {
                key.SetValue(RegistryPortName, port);
            }

            // Старт TCP сервера логгера
            LoggerServer.Start(port);

            // Запускаем форму логгера
            Application.Run(new VisualLoggerForm());
        }

        private static int GetFreePort()
        {
            TcpListener listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            int port = ((IPEndPoint)listener.LocalEndpoint).Port;
            listener.Stop();
            return port;
        }
    }
}
