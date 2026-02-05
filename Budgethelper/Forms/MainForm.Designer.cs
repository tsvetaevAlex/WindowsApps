using Budgethelper.Controls;

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

        private AccountsGroup accountsGroupRur;
        private TransactionsGroup transactionsGroupRur;

        private AccountsGroup accountsGroupUsd;
        private TransactionsGroup transactionsGroupUsd;

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

            this.accountsGroupRur = new AccountsGroup();
            this.transactionsGroupRur = new TransactionsGroup();

            this.accountsGroupUsd = new AccountsGroup();
            this.transactionsGroupUsd = new TransactionsGroup();

            this.lblUser = new System.Windows.Forms.Label();
            this.lblUid = new System.Windows.Forms.Label();

            this.tabControl.SuspendLayout();
            this.tabRur.SuspendLayout();
            this.tabUsd.SuspendLayout();
            this.SuspendLayout();

            // ================= HEADER =================

            this.lblUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUser.Height = 22;

            this.lblUid.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUid.Height = 18;

            // ================= TAB CONTROL =================

            this.tabControl.Controls.Add(this.tabRur);
            this.tabControl.Controls.Add(this.tabUsd);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 40);
            this.tabControl.SelectedIndex = 0;

            // ================= TAB RUR =================

            this.tabRur.Text = "RUR";
            this.tabRur.Controls.Add(this.transactionsGroupRur);
            this.tabRur.Controls.Add(this.accountsGroupRur);

            this.accountsGroupRur.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountsGroupRur.Height = 220;

            this.transactionsGroupRur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionsGroupRur.Enabled = false;

            // ================= TAB USD =================

            this.tabUsd.Text = "USD";
            this.tabUsd.Controls.Add(this.transactionsGroupUsd);
            this.tabUsd.Controls.Add(this.accountsGroupUsd);

            this.accountsGroupUsd.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountsGroupUsd.Height = 220;

            this.transactionsGroupUsd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionsGroupUsd.Enabled = false;

            // ================= MAIN FORM =================

            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblUid);
            this.Controls.Add(this.lblUser);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudgetHelper";

            this.tabControl.ResumeLayout(false);
            this.tabRur.ResumeLayout(false);
            this.tabUsd.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
