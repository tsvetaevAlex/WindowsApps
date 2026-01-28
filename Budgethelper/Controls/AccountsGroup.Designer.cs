namespace Budgethelper.Controls
{
    partial class AccountsGroup
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxAccounts;
        private System.Windows.Forms.Button btnAddAccount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxAccounts = new System.Windows.Forms.ListBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // listBoxAccounts
            // 
            this.listBoxAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAccounts.FormattingEnabled = true;
            this.listBoxAccounts.ItemHeight = 15;
            this.listBoxAccounts.Name = "listBoxAccounts";
            this.listBoxAccounts.TabIndex = 0;
            this.listBoxAccounts.SelectedIndexChanged +=
                new System.EventHandler(this.listBoxAccounts_SelectedIndexChanged);

            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddAccount.Height = 36;
            this.btnAddAccount.Text = "➕ Добавить аккаунт";
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // обработчик можно добавить позже:
            // this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);

            // 
            // AccountsGroup
            // 
            this.Controls.Add(this.listBoxAccounts);
            this.Controls.Add(this.btnAddAccount);
            this.Name = "AccountsGroup";
            this.Size = new System.Drawing.Size(400, 200);
            this.ResumeLayout(false);
        }
    }
}
