using System.Windows.Forms;
using System.Drawing;

namespace Visual.Logger.Server
{
    public sealed partial class VisualLoggerForm : Form
    {
        public RichTextBox rtvLogger;

        private void InitializeComponent()
        {
            this.rtvLogger = new RichTextBox();

            this.SuspendLayout();

            // 
            // rtvLogger
            // 
            this.rtvLogger.Dock = DockStyle.Fill;
            this.rtvLogger.ReadOnly = true;
            this.rtvLogger.BackColor = Color.Black;
            this.rtvLogger.ForeColor = Color.Lime;
            this.rtvLogger.Font = new Font("Consolas", 12);
            this.rtvLogger.BorderStyle = BorderStyle.None;

            // 
            // VisualLoggerForm
            // 
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.rtvLogger);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(50, 50);
            this.Text = "Visual Logger";

            this.ResumeLayout(false);
        }
    }
}
