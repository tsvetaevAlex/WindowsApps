using System;
using System.Drawing;
using System.ServiceModel;
using System.Windows.Forms;

namespace Visual.Logger.Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public partial class VisualLoggerForm : Form, IVisualLogger
    {
        private RichTextBox rtbLogger;

        public VisualLoggerForm()
        {
            InitializeComponent();
        }
        /*
        private void InitializeComponent()
        {
            this.rtbLogger = new RichTextBox();
            this.SuspendLayout();

            // rtbLogger
            this.rtbLogger.Dock = DockStyle.Fill;
            this.rtbLogger.ReadOnly = true;
            this.rtbLogger.BackColor = Color.Black;
            this.rtbLogger.ForeColor = Color.Lime;
            this.rtbLogger.Font = new Font("Consolas", 10);
            this.rtbLogger.BorderStyle = BorderStyle.None;

            // VisualLoggerForm
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.rtbLogger);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(50, 50);
            this.Text = "Visual Logger";

            this.ResumeLayout(false);
        }*/

        public void SendMessage(string message, Color teztColor)
        {
            if (this.rtbLogger.InvokeRequired)
            {
                this.rtbLogger.Invoke(new Action(() => SendMessage(message, teztColor)));
                return;
            }

            int start = rtbLogger.TextLength;
            rtbLogger.AppendText(message + Environment.NewLine);
            int end = rtbLogger.TextLength;

            rtbLogger.Select(start, end - start);
            rtbLogger.SelectionColor = teztColor;
            rtbLogger.SelectionLength = 0;
            rtbLogger.ScrollToCaret();
        }

        public void SendMessage(string message)
        {
            SendMessage(message, Color.Lime);
        }

        public ServiceHost StartService()
        {
            var baseAddress = new Uri("http://localhost:8000/VisualLogger");
            var host = new ServiceHost(this, baseAddress);

            host.AddServiceEndpoint(typeof(IVisualLogger), new BasicHttpBinding(), "");
            host.Open();

            return host;
        }
    }
}
