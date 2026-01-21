namespace Visual.Logger
{
    partial class VisualLogger
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox rtbLogger;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.rtbLogger = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbLogger
            // 
            this.rtbLogger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLogger.ReadOnly = true;
            this.rtbLogger.BackColor = System.Drawing.Color.Black;
            this.rtbLogger.ForeColor = System.Drawing.Color.Lime;
            this.rtbLogger.Font = new System.Drawing.Font("Consolas", 10F);
            this.rtbLogger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // VisualLogger
            // 
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.rtbLogger);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(40, 40);
            this.Text = "Visual Logger";
            this.ResumeLayout(false);
        }
    }
}
