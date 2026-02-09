using Budgethelper.Models;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Budgethelper.Services
{
    public partial class Logger : Form
    {
        private static Logger _instance;

        private RichTextBox _output;

        private Logger()
        {
            InitializeUI();
        }

        // 🔹 Инициализация (вызывается один раз)
        public static void Initialize()
        {
            if (_instance == null)
            {
                _instance = new Logger();
                _instance.Show();
            }
        }

        // 🔹 Доступ к экземпляру
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                    Initialize();

                return _instance;
            }
        }

        // 🔹 Метод логирования
        public static void Log(string message, Color? color = null)
        {
            if (_instance == null)
                return;

            _instance.Append(message, color ?? Color.LightGreen);
        }

        private void Append(string message, Color color)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Append(message, color)));
                return;
            }

            _output.SelectionStart = _output.TextLength;
            _output.SelectionLength = 0;
            _output.SelectionColor = color;

            _output.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}\n");
            _output.SelectionColor = _output.ForeColor;
            _output.ScrollToCaret();
        }

        private void InitializeUI()
        {
            Text = "Visual Logger";
            Size = new Size(700, 400);
            StartPosition = FormStartPosition.Manual;
            BackColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            _output = new RichTextBox
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Black,
                ForeColor = Color.LightGreen,
                BorderStyle = BorderStyle.None,
                Font = new Font("Consolas", 10),
                ReadOnly = true
            };

            Controls.Add(_output);
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
                case MessageType.UI:
                    loggerPrefix = "DataBase:";
                    textColor = Color.LightBlue;
                    break;
                case MessageType.Account:
                    loggerPrefix = "Account:";
                    textColor = Color.Lime;
                    break;
                case MessageType.User:
                    loggerPrefix = "User:";
                    textColor = Color.Yellow;
                    break;
                default:
                    loggerPrefix = "message:";
                    textColor = Color.GhostWhite;
                    break;
            }

            try
            {
                int port = GetLoggerPort();
                if (port == 0)
                    return;

                string timeStamp = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss.fff");
                using (var client = new TcpClient("127.0.0.1", port))
                using (var stream = client.GetStream())
                using (var writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    // Формат:
                    // R|G|B|prefix|message
                    writer.WriteLine($"{timeStamp}=>{textColor.R}|{textColor.G}|{textColor.B}|{loggerPrefix}|{message}");
                    writer.Flush();
                }
            }
            catch
            {
                // если логгер не доступен — просто игнорируем
            }
        }// end of SendMessage
        private static int GetLoggerPort()
        {
            using (var key = Registry.CurrentUser.OpenSubKey(Session.RegistryKeyPath))
            {
                if (key == null)
                    return 0;

                object value = key.GetValue("loggerPort");
                if (value == null)
                    return 0;

                return Convert.ToInt32(value);
            }
        }

    } // end of public partial class Logger : Form
}// enf of namespace Budgethelper.Services
