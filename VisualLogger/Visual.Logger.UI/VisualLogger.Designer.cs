namespace WebAutomation.Logger.Visual
{
    sealed partial class VisualLogger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualLogger));
            this.loggerTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // loggerTextBox
            // 
            this.loggerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loggerTextBox.Location = new System.Drawing.Point(0, 0);
            this.loggerTextBox.Name = "loggerTextBox";
            this.loggerTextBox.ReadOnly = true;
            this.loggerTextBox.Size = new System.Drawing.Size(780, 180);
            this.loggerTextBox.TabIndex = 0;
            this.loggerTextBox.Text = "";
            this.loggerTextBox.Visible = false;
            // 
            // VisualLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 200);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisualLogger";
            this.Text = "Visual Logger 1.0";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VisualLogger_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox loggerTextBox;

    }
}