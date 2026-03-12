using System.Windows.Forms;

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
            this.tabContro1 = new System.Windows.Forms.TabControl();
            this.Wallet = new System.Windows.Forms.TabPage();
            this.Transactions = new System.Windows.Forms.TabPage();
            this.tabContro1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContro1
            // 
            this.tabContro1.Controls.Add(this.Wallet);
            this.tabContro1.Controls.Add(this.Transactions);
            this.tabContro1.Location = new System.Drawing.Point(10, 10);
            this.tabContro1.Name = "tabContro1";
            this.tabContro1.Padding = new System.Drawing.Point(10, 10);
            this.tabContro1.SelectedIndex = 0;
            this.tabContro1.Size = new System.Drawing.Size(675, 450);
            this.tabContro1.TabIndex = 0;
            // 
            // Wallet
            // 
            this.Wallet.Location = new System.Drawing.Point(4, 36);
            this.Wallet.Name = "Wallet";
            this.Wallet.Padding = new System.Windows.Forms.Padding(3);
            this.Wallet.Size = new System.Drawing.Size(667, 410);
            this.Wallet.TabIndex = 0;
            this.Wallet.Text = "Кошелёк";
            this.Wallet.UseVisualStyleBackColor = true;
            // 
            // Transactions
            // 
            this.Transactions.Location = new System.Drawing.Point(4, 36);
            this.Transactions.Name = "Transactions";
            this.Transactions.Padding = new System.Windows.Forms.Padding(3);
            this.Transactions.Size = new System.Drawing.Size(667, 410);
            this.Transactions.TabIndex = 1;
            this.Transactions.Text = "Транзакции";
            this.Transactions.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.tabContro1);
            this.Name = "MainForm";
            this.Text = "BudgetHelper";
            this.tabContro1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private TabControl tabContro1;
        private TabPage Wallet;
        private TabPage Transactions;
    }
}