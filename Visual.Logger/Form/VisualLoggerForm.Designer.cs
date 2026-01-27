namespace Visual.Logger.Forms
{
    partial class VisualLoggerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox richTextBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.Black;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.richTextBox.ForeColor = System.Drawing.Color.White;
            this.richTextBox.ReadOnly = true;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // VisualLoggerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Controls.Add(this.richTextBox);
            this.Name = "VisualLoggerForm";
            this.Text = "Visual.Logger";
            this.ResumeLayout(false);
        }
    }
}
