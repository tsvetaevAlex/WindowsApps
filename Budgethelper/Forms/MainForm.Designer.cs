namespace Budgethelper.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabRur;
        private System.Windows.Forms.TabPage tabUsd;

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblUid;

        private Budgethelper.Controls.AccountsGroup accountsGroupRur;
        private Budgethelper.Controls.TransactionsGroup transactionsGroupRur;

        private Budgethelper.Controls.AccountsGroup accountsGroupUsd;
        private Budgethelper.Controls.TransactionsGroup transactionsGroupUsd;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabRur = new System.Windows.Forms.TabPage();
            this.tabUsd = new System.Windows.Forms.TabPage();

            this.lblUser = new System.Windows.Forms.Label();
            this.lblUid = new System.Windows.Forms.Label();

            this.accountsGroupRur = new Budgethelper.Controls.AccountsGroup();
            this.transactionsGroupRur = new Budgethelper.Controls.TransactionsGroup();

            this.accountsGroupUsd = new Budgethelper.Controls.AccountsGroup();
            this.transactionsGroupUsd = new Budgethelper.Controls.TransactionsGroup();

            this.tabControl.SuspendLayout();
            this.tabRur.SuspendLayout();
            this.tabUsd.SuspendLayout();
            this.SuspendLayout();

            // ===== MainForm =====
            this.Text = "BudgetHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(900, 700);

            // ===== Header =====
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUser.Height = 22;

            this.lblUid.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUid.Height = 18;

            // ===== TabControl =====
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Controls.Add(this.tabRur);
            this.tabControl.Controls.Add(this.tabUsd);

            // ===== tabRUR =====
            this.tabRur.Text = "RUR";
            this.tabRur.Controls.Add(this.transactionsGroupRur);
            this.tabRur.Controls.Add(this.accountsGroupRur);

            this.accountsGroupRur.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountsGroupRur.Height = 220;

            this.transactionsGroupRur.Dock = System.Windows.Forms.DockStyle.Fill;

            // ===== tabUSD =====
            this.tabUsd.Text = "USD";
            this.tabUsd.Controls.Add(this.transactionsGroupUsd);
            this.tabUsd.Controls.Add(this.accountsGroupUsd);

            this.accountsGroupUsd.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountsGroupUsd.Height = 220;

            this.transactionsGroupUsd.Dock = System.Windows.Forms.DockStyle.Fill;

            // ===== Form layout =====
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblUid);
            this.Controls.Add(this.lblUser);

            this.tabControl.ResumeLayout(false);
            this.tabRur.ResumeLayout(false);
            this.tabUsd.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
