using Budgethelper.Controls;

namespace Budgethelper.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.accountsGroup1 = new Budgethelper.Controls.AccountsGroup();
            this.transactionsGroup1 = new Budgethelper.Controls.TransactionsGroup();
            this.SuspendLayout();
            // 
            // accountsGroup1
            // 
            this.accountsGroup1.Location = new System.Drawing.Point(20, 20);
            this.accountsGroup1.Name = "accountsGroup1";
            this.accountsGroup1.Size = new System.Drawing.Size(760, 185);
            this.accountsGroup1.TabIndex = 0;
            // 
            // transactionsGroup1
            // 
            this.transactionsGroup1.Location = new System.Drawing.Point(0, 0);
            this.transactionsGroup1.Name = "transactionsGroup1";
            this.transactionsGroup1.Size = new System.Drawing.Size(800, 600);
            this.transactionsGroup1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.transactionsGroup1);
            this.Controls.Add(this.accountsGroup1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudgetHelper";
            this.ResumeLayout(false);

        }

        private AccountsGroup accountsGroup1;
        private TransactionsGroup transactionsGroup1;
    }
}
