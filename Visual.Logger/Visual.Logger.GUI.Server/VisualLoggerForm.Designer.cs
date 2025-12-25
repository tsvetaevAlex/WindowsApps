using System.Windows.Forms;

namespace Visual.Logger.GUI
{
    public sealed partial class VisualLoggerForm
    {
        private RichTextBox loggerTextBox;

        private void InitializeComponent()
        {
            this.loggerTextBox = new System.Windows.Forms.RichTextBox();

            this.SuspendLayout();

            this.loggerTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loggerTextBox.ReadOnly = true;

            this.Controls.Add(this.loggerTextBox);

            this.Text = "Visual Logger";
            this.ClientSize = new System.Drawing.Size(800, 450);

            this.ResumeLayout(false);
        }
    }
}
