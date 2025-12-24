using System;
using System.Drawing;
using System.Windows.Forms;

namespace Visual.Logger.Service.UI
{
    public sealed partial class VisualLogger : Form
    {
        private static readonly string TitleSuffix = " - Visual Logger 1.0.1";

        public VisualLogger()
        {
            InitializeComponent();
        }

        public void SetWindowTitle(string windowTitle)
        {
            Text = windowTitle + TitleSuffix;
        }

        public void WriteText(LogLevel logLevel, string msg)
        {
            Color color;

            switch (logLevel)
            {
                case LogLevel.Warning: color = Color.Pink; break;
                case LogLevel.Error: color = Color.Red; break;
                case LogLevel.Performance: color = Color.Orange; break;
                case LogLevel.Info: color = Color.Chartreuse; break;
                case LogLevel.Debug: color = Color.GhostWhite; break;
                default: color = ForeColor; break;
            }

            if (loggerTextBox.InvokeRequired)
            {
                loggerTextBox.Invoke(new MethodInvoker(() =>
                    AppendColoredLine(color, logLevel, msg)));
            }
            else
            {
                AppendColoredLine(color, logLevel, msg);
            }
        }

        private void AppendColoredLine(Color color, LogLevel level, string msg)
        {
            loggerTextBox.SelectionStart = loggerTextBox.TextLength;
            loggerTextBox.SelectionLength = 0;

            loggerTextBox.SelectionColor = color;
            loggerTextBox.AppendText($"[{DateTime.Now:HH:mm:ss}] {level}: {msg}\r\n");
            loggerTextBox.SelectionColor = loggerTextBox.ForeColor;

            loggerTextBox.ScrollToCaret();
        }

        private void VisualLogger_Load(object sender, EventArgs e)
        {
            Visible = true;
        }

        public void StopVisualLogger()
        {
            Close();
        }
    }
}
