namespace Budgethelper.Controls
{
    partial class TransactionsGroup
    {
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label lblHint;

        private void InitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Text = "Transactions";
            this.groupBox.Controls.Add(this.lblHint);
            this.groupBox.Controls.Add(this.listBox);
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // lblHint
            // 
            this.lblHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHint.Text = "Select an account";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransactionsGroup
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.groupBox);
            this.Size = new System.Drawing.Size(600, 250);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
