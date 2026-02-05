using Budgethelper.Models;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace Budgethelper.Services
{
    public static class Logger
    {
        private const string RegistryPath = @"Software\BudgetHelper";

        public static void SendMessage(MessageType prefix, string message)
        {
            SendMessage(prefix, message, Color.WhiteSmoke);
        }

        public static void SendMessage(MessageType prefix, string message, Color textColor)
        {
            string loggerPrefix = string.Empty;
            switch (prefix)
            {
                case MessageType.Info:
                    loggerPrefix = "Info:";
                    textColor = Color.WhiteSmoke;
                    break;
                case MessageType.Warn:
                    loggerPrefix = "Warning:";
                    textColor = Color.White;
                    break;
                case MessageType.Debug:
                    loggerPrefix = "Debug:";
                    textColor = Color.Gray;
                    break;
                case MessageType.DB:
                    loggerPrefix = "DataBase:";
                    textColor = Color.MediumBlue;
                    break;
                case MessageType.Account:
                    loggerPrefix = "Account:";
                    textColor = Color.Gold;
                    break;
                default:
                    loggerPrefix = "message:";
                    textColor = Color.Yellow;
                    break;
            }

            try
            {
                int port = GetLoggerPort();
                if (port == 0)
                    return;

                using (var client = new TcpClient("127.0.0.1", port))
                using (var stream = client.GetStream())
                using (var writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    // Формат:
                    // R|G|B|prefix|message
                    writer.WriteLine($"{textColor.R}|{textColor.G}|{textColor.B}|{loggerPrefix}|{message}");
                    writer.Flush();
                }
            }
            catch
            {
                // если логгер не доступен — просто игнорируем
            }
        }

        private static int GetLoggerPort()
        {
            using (var key = Registry.CurrentUser.OpenSubKey(RegistryPath))
            {
                if (key == null)
                    return 0;

                object value = key.GetValue("loggerPort");
                if (value == null)
                    return 0;

                return Convert.ToInt32(value);
            }
        }
    }
}
