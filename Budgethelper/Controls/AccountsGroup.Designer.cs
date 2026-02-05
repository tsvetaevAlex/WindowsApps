namespace Budgethelper.Controls
{
    partial class AccountsGroup
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListBox listAccounts;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Button btnAdd;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listAccounts = new System.Windows.Forms.ListBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // listAccounts
            this.listAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.listAccounts.Height = 150;
            this.listAccounts.SelectedIndexChanged +=
                new System.EventHandler(this.listAccounts_SelectedIndexChanged);

            // txtAccountName
            this.txtAccountName.Dock = System.Windows.Forms.DockStyle.Top;

            // btnAdd
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Text = "Добавить счет";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // AccountsGroup
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.listAccounts);
            this.Height = 220;

            this.ResumeLayout(false);
        }
    }
}
