using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Budgethelper.Models;

namespace Budgethelper.Services
{
    public partial class Logger : Form
    {
        private static Logger _instance;
        private RichTextBox _output;

        #region Singleton

        public static void Initialize()
        {
            if (_instance == null)
            {
                _instance = new Logger();
                _instance.Show();
            }
        }

        #endregion

        #region Constructor

        private Logger()
        {
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "BudgetHelper Logger";
            this.Size = new Size(900, 500);

            _output = new RichTextBox();
            _output.Dock = DockStyle.Fill;
            _output.ReadOnly = true;
            _output.BackColor = Color.Black;
            _output.ForeColor = Color.White;
            _output.Font = new Font("Consolas", 10);

            this.Controls.Add(_output);
        }

        #endregion

        #region Public API

        public static void SendMessage(
            MessageType type,
            string message,
            [CallerMemberName] string member = "",
            [CallerFilePath] string file = "",
            [CallerLineNumber] int line = 0)
        {
            if (_instance == null)
                return;

            string fileName = Path.GetFileNameWithoutExtension(file);
            string source = $"{fileName}.{member} (line {line})";
            string thread = Thread.CurrentThread.ManagedThreadId.ToString();

            string finalMessage = $"[T{thread}] [{source}] {message}";

            _instance.Append_ByMessageType(type, finalMessage);
        }

        #endregion

        #region Core Logic

        private void Append_ByMessageType(MessageType type, string message)
        {
            string prompt = GetPrompt(type);
            Color color = GetColor(type);

            string fullText =
                $"[{DateTime.Now:HH:mm:ss}] {prompt}\n" +
                $"{message}\n\n";

            Append_ColorMessage(fullText, color);
        }

        private void Append_ColorMessage(string message, Color color)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => Append_ColorMessage(message, color)));
                return;
            }

            _output.SelectionStart = _output.TextLength;
            _output.SelectionLength = 0;
            _output.SelectionColor = color;

            _output.AppendText(message);

            _output.SelectionColor = _output.ForeColor;
            _output.ScrollToCaret();
        }

        #endregion

        #region Helpers

        private string GetPrompt(MessageType mType)
        {
            switch (mType)
            {
                case MessageType.UI:
                    return "Сообщение от Пользовательского интерфейса:";

                case MessageType.Account:
                    return "Сообщение от сервиса работы со счетами :";

                case MessageType.User:
                    return "Сообщение от сервиса работы с учетной записью пользователя приложения:";

                case MessageType.DB:
                case MessageType.DB_success:
                case MessageType.DB_fail:
                    return "Сообщение от сервиса Базы Данных:";

                case MessageType.TransactionExpence:
                case MessageType.TransactionIncome:
                    return "Сообщение от сервиса работы с транзакциями:";

                case MessageType.Warn:
                    return "Сообщение Предупреждение:";

                case MessageType.Error:
                    return "Системное Сообщение об Ошибке:";

                case MessageType.Debug:
                    return "Отладочное сообщение:";

                default:
                    return "Сообщение общего характера:";
            }
        }

        private Color GetColor(MessageType mType)
        {
            switch (mType)
            {
                case MessageType.UI:
                    return Color.LightBlue;

                case MessageType.Account:
                    return Color.LightGreen;

                case MessageType.AccountSelect:
                    return Color.Yellow;

                case MessageType.AccountCReate:
                    return Color.Blue;

                case MessageType.User:
                    return Color.LightSkyBlue;

                case MessageType.DB:
                    return Color.Orange;

                case MessageType.DB_success:
                    return Color.Green;

                case MessageType.DB_fail:
                    return Color.Red;

                case MessageType.Transaction:
                    return Color.ForestGreen;
                case MessageType.TransactionIncome:
                    return Color.LawnGreen;

                case MessageType.TransactionExpence:
                    return Color.IndianRed;

                case MessageType.Warn:
                    return Color.PaleVioletRed;

                case MessageType.Error:
                    return Color.Red;

                case MessageType.Debug:
                    return Color.LightGray;

                default:
                    return Color.White;
            }
        }

        #endregion
    }
}