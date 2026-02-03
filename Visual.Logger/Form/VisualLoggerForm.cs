using System;
using System.Drawing;
using System.Windows.Forms;

namespace Visual.Logger.Forms
{
    public partial class VisualLoggerForm : Form
    {
        public VisualLoggerForm()
        {
            InitializeComponent();
        }

        public void LogInfo(string message)
        {
            AppendText("[INFO]  " + message + Environment.NewLine, Color.LightGreen);
        }

        public void LogWarning(string message)
        {
            AppendText("[WARN]  " + message + Environment.NewLine, Color.Yellow);
        }

        public void LogError(string message)
        {
            AppendText("[ERROR] " + message + Environment.NewLine, Color.IndianRed);
        }

        private void AppendText(string text, Color color)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string, Color>(AppendText), text, color);
                return;
            }

            txtLog.SelectionStart = txtLog.TextLength;
            txtLog.SelectionLength = 0;

            txtLog.SelectionColor = color;
            txtLog.AppendText(text);
            txtLog.SelectionColor = txtLog.ForeColor;

            txtLog.ScrollToCaret();
        }
    }
}
