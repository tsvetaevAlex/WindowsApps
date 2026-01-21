namespace Budgethelper.Controls
{
    partial class AccountsGroup
    {
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox cmbAccounts;
        private System.Windows.Forms.Button btnAdd;

        private void InitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cmbAccounts = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Text = "Accounts";
            this.groupBox.Controls.Add(this.cmbAccounts);
            this.groupBox.Controls.Add(this.btnAdd);
            // 
            // cmbAccounts
            // 
            this.cmbAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccounts.Location = new System.Drawing.Point(12, 32);
            this.cmbAccounts.Size = new System.Drawing.Size(400, 23);
            this.cmbAccounts.SelectedIndexChanged += new System.EventHandler(this.cmbAccounts_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(430, 31);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AccountsGroup
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.groupBox);
            this.Load += new System.EventHandler(this.AccountsGroup_Load);
            this.Size = new System.Drawing.Size(600, 80);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
