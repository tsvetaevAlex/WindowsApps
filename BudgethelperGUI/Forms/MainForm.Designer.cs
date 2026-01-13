using System.Windows.Forms;

namespace Budgethelper.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private ListView lvUsdAccounts;
        private Button btnAddTransaction;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lvUsdAccounts = new ListView();
            btnAddTransaction = new Button();

            SuspendLayout();

            // lvUsdAccounts
            lvUsdAccounts.Dock = DockStyle.Top;
            lvUsdAccounts.Height = 250;
            lvUsdAccounts.View = View.Details;
            lvUsdAccounts.FullRowSelect = true;
            lvUsdAccounts.GridLines = true;

            lvUsdAccounts.Columns.Add("Account", 200);
            lvUsdAccounts.Columns.Add("Balance", 120);

            // btnAddTransaction
            btnAddTransaction.Text = "Add transaction";
            btnAddTransaction.Dock = DockStyle.Top;
            btnAddTransaction.Height = 40;
            btnAddTransaction.Click += btnAddTransaction_Click;

            // MainForm
            ClientSize = new System.Drawing.Size(600, 400);
            Controls.Add(btnAddTransaction);
            Controls.Add(lvUsdAccounts);
            Text = "BudgetHelper";
            Load += MainForm_Load;

            ResumeLayout(false);
        }
    }
}
