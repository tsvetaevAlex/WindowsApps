
using Budgethelper.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using Budgethelper.Services;

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
            this.rtbLog.Font = new Font("Consolas", 12);
            this.rtbLog.ReadOnly = true;
            this.Controls.Add(this.rtbLog);
            this.Text = "Visual Logger";
            this.Size = new Size(600, 300);
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.StartPosition = FormStartPosition.Manual;
            this.ResumeLayout(false);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            Logger.SendMessage(MessageType.Info,
                "logger successfully initiated.");
        }

    }// end of class VisualLoggerForm : Form
} // end of namespace Budgethelper.Forms
