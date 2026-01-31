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
            this.transactionsGroupRur = new Budgethelper.Controls.TransactionsGroup();
            this.accountsGroupRur = new Budgethelper.Controls.AccountsGroup();
            this.tabUsd = new System.Windows.Forms.TabPage();
            this.transactionsGroupUsd = new Budgethelper.Controls.TransactionsGroup();
            this.accountsGroupUsd = new Budgethelper.Controls.AccountsGroup();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUid = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabRur.SuspendLayout();
            this.tabUsd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabRur);
            this.tabControl.Controls.Add(this.tabUsd);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 40);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(884, 621);
            this.tabControl.TabIndex = 0;
            // 
            // tabRur
            // 
            this.tabRur.Controls.Add(this.transactionsGroupRur);
            this.tabRur.Controls.Add(this.accountsGroupRur);
            this.tabRur.Location = new System.Drawing.Point(4, 22);
            this.tabRur.Name = "tabRur";
            this.tabRur.Size = new System.Drawing.Size(876, 595);
            this.tabRur.TabIndex = 0;
            this.tabRur.Text = "RUR";
            // 
            // transactionsGroupRur
            // 
            this.transactionsGroupRur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionsGroupRur.Enabled = false;
            this.transactionsGroupRur.Location = new System.Drawing.Point(0, 220);
            this.transactionsGroupRur.Name = "transactionsGroupRur";
            this.transactionsGroupRur.Size = new System.Drawing.Size(876, 375);
            this.transactionsGroupRur.TabIndex = 0;
            // 
            // accountsGroupRur
            // 
            this.accountsGroupRur.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountsGroupRur.Location = new System.Drawing.Point(0, 0);
            this.accountsGroupRur.Name = "accountsGroupRur";
            this.accountsGroupRur.Size = new System.Drawing.Size(876, 220);
            this.accountsGroupRur.TabIndex = 1;
            // 
            // tabUsd
            // 
            this.tabUsd.Controls.Add(this.transactionsGroupUsd);
            this.tabUsd.Controls.Add(this.accountsGroupUsd);
            this.tabUsd.Location = new System.Drawing.Point(4, 22);
            this.tabUsd.Name = "tabUsd";
            this.tabUsd.Size = new System.Drawing.Size(876, 595);
            this.tabUsd.TabIndex = 1;
            this.tabUsd.Text = "USD";
            // 
            // transactionsGroupUsd
            // 
            this.transactionsGroupUsd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionsGroupUsd.Enabled = false;
            this.transactionsGroupUsd.Location = new System.Drawing.Point(0, 220);
            this.transactionsGroupUsd.Name = "transactionsGroupUsd";
            this.transactionsGroupUsd.Size = new System.Drawing.Size(876, 375);
            this.transactionsGroupUsd.TabIndex = 0;
            // 
            // accountsGroupUsd
            // 
            this.accountsGroupUsd.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountsGroupUsd.Location = new System.Drawing.Point(0, 0);
            this.accountsGroupUsd.Name = "accountsGroupUsd";
            this.accountsGroupUsd.Size = new System.Drawing.Size(876, 220);
            this.accountsGroupUsd.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUser.Location = new System.Drawing.Point(0, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(884, 22);
            this.lblUser.TabIndex = 2;
            // 
            // lblUid
            // 
            this.lblUid.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUid.Location = new System.Drawing.Point(0, 22);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(884, 18);
            this.lblUid.TabIndex = 1;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblUid);
            this.Controls.Add(this.lblUser);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudgetHelper";
            this.tabControl.ResumeLayout(false);
            this.tabRur.ResumeLayout(false);
            this.tabUsd.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
