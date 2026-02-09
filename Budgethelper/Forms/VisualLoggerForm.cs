
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    public partial class VisualLoggerForm : Form
    {
        private RichTextBox rtbLog;

        public VisualLoggerForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.rtbLog = new RichTextBox();
            this.SuspendLayout();
            this.rtbLog.BackColor = Color.Black;
            this.rtbLog.ForeColor = Color.White;
            this.rtbLog.Font = new Font("Consolas", 10);
            this.rtbLog.ReadOnly = true;
            this.Controls.Add(this.rtbLog);
            this.Text = "Visual Logger";
            this.Size = new Size(600, 300);
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.StartPosition = FormStartPosition.Manual;
            this.ResumeLayout(false);
        }

        public void Append(string message, Color color)
        {
            rtbLog.Invoke((Action)(() =>
            {
                rtbLog.SelectionStart = rtbLog.TextLength;
                rtbLog.SelectionColor = color;
                rtbLog.AppendText(message + Environment.NewLine);
                rtbLog.SelectionColor = rtbLog.ForeColor;
                rtbLog.ScrollToCaret();
            }));
        }
    }

    //public static class Logger
    //{
    //    private static VisualLoggerForm _instance;

    //    public static void Initialize()
    //    {
    //        if (_instance == null)
    //        {
    //            _instance = new VisualLoggerForm();
    //            _instance.Show();
    //        }
    //    }

        //public static void SendMessage(string message, Color color)
        //{
        //    _instance?.Append(message, color);
        //}
    //}
}
