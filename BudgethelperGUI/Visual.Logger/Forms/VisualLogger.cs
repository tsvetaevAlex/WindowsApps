using System;
using System.Windows.Forms;

namespace Visual.Logger
{
    public sealed partial class VisualLogger : Form
    {
        public VisualLogger()
        {
            InitializeComponent();
        }

        public void Append(LogMessage message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<LogMessage>(Append), message);
                return;
            }

            rtbLogger.SelectionColor = message.Color;
            rtbLogger.AppendText(message + Environment.NewLine);
            rtbLogger.ScrollToCaret();
        }
    }
}
