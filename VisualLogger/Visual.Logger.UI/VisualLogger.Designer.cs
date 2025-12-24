using System.Drawing;
using System.Windows.Forms;

namespace Visual.Logger.Service.UI
{
    sealed partial class VisualLogger
    {
        private System.ComponentModel.IContainer components = null;
        private RichTextBox loggerTextBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.loggerTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // loggerTextBox
            // 
            this.loggerTextBox.BackColor = Color.Black;
            this.loggerTextBox.ForeColor = Color.White;
            this.loggerTextBox.ReadOnly = true;
            this.loggerTextBox.Dock = DockStyle.Fill;
            this.loggerTextBox.BorderStyle = BorderStyle.None;
            this.loggerTextBox.Font = new Font("Consolas", 10);
            // 
            // VisualLogger
            // 
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 400);
            this.Controls.Add(this.loggerTextBox);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Name = "VisualLogger";
            this.Text = "Visual Logger";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VisualLogger_Load);
            this.ResumeLayout(false);
        }
    }
}
