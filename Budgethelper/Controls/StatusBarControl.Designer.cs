namespace Budgethelper.Controls
{
    partial class StatusBarControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBalance;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(10, 5);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(80, 15);
            this.lblBalance.Text = "Balance: 0.00";
            // 
            // StatusBarControl
            // 
            this.Controls.Add(this.lblBalance);
            this.Name = "StatusBarControl";
            this.Size = new System.Drawing.Size(200, 25);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
