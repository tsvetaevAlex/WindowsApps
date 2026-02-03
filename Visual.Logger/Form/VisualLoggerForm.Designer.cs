namespace Visual.Logger.Forms
{
    partial class VisualLoggerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox txtLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();

            // txtLog
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.ForeColor = System.Drawing.Color.White;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.ReadOnly = true;
            this.txtLog.HideSelection = false;

            // VisualLoggerForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.txtLog);
            this.BackColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Visual Logger";
            this.ResumeLayout(false);
        }
    }
}
