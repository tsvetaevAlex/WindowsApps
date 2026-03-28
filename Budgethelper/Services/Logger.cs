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
            Message_Type type,
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

        private void Append_ByMessageType(Message_Type type, string message)
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

        private string GetPrompt(Message_Type mType)
        {
            switch (mType)
            {
                case Message_Type.UI:
                    return "Сообщение от Пользовательского интерфейса:";

                case Message_Type.Account:
                    return "Сообщение от сервиса работы со счетами :";

                case Message_Type.User:
                    return "Сообщение от сервиса работы с учетной записью пользователя приложения:";

                case Message_Type.DB:
                case Message_Type.DB_success:
                case Message_Type.DB_fail:
                    return "Сообщение от сервиса Базы Данных:";

                case Message_Type.TransactionExpence:
                case Message_Type.TransactionIncome:
                    return "Сообщение от сервиса работы с транзакциями:";

                case Message_Type.Warn:
                    return "Сообщение Предупреждение:";

                case Message_Type.Error:
                    return "Системное Сообщение об Ошибке:";

                case Message_Type.Debug:
                    return "Отладочное сообщение:";

                default:
                    return "Сообщение общего характера:";
            }
        }

        private Color GetColor(Message_Type mType)
        {
            switch (mType)
            {
                case Message_Type.UI:
                    return Color.LightBlue;

                case Message_Type.Info:
                    return Color.White;

                case Message_Type.Account:
                    return Color.LightGreen;

                case Message_Type.AccountSelect:
                    return Color.Yellow;

                case Message_Type.AccountCReate:
                    return Color.Blue;

                case Message_Type.User:
                    return Color.LightSkyBlue;

                case Message_Type.DB:
                    return Color.Orange;

                case Message_Type.DB_success:
                    return Color.Green;

                case Message_Type.DB_fail:
                    return Color.Red;

                case Message_Type.Transaction:
                    return Color.ForestGreen;
                case Message_Type.TransactionIncome:
                    return Color.LawnGreen;

                case Message_Type.TransactionExpence:
                    return Color.IndianRed;

                case Message_Type.Warn:
                    return Color.PaleVioletRed;

                case Message_Type.Error:
                    return Color.Red;

                case Message_Type.Debug:
                    return Color.LightGray;

                case Message_Type.Hint:
                    return Color.Yellow;
                
                default:
                    return Color.White;
            }
        }

        #endregion
    }
}