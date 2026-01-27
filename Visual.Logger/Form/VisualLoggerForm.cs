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

        public void LogInfo(string message) =>
            Append(message, Color.LightGreen);

        public void LogWarning(string message) =>
            Append(message, Color.Yellow);

        public void LogError(string message) =>
            Append(message, Color.IndianRed);

        private void Append(string message, Color color)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Append(message, color)));
                return;
            }

            richTextBox.SelectionColor = color;
            richTextBox.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}\n");
            richTextBox.ScrollToCaret();
        }
    }
}
