namespace Budgethelper.Controls
{
    partial class AccountsGroup
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView accountsGrid;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.accountsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.accountsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // accountsGrid
            // 
            this.accountsGrid.AllowUserToAddRows = false;
            this.accountsGrid.AllowUserToDeleteRows = false;
            this.accountsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accountsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountsGrid.MultiSelect = false;
            this.accountsGrid.ReadOnly = true;
            this.accountsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountsGrid.SelectionChanged += new System.EventHandler(this.accountsGrid_SelectionChanged);
            // 
            // AccountsGroup
            // 
            this.Controls.Add(this.accountsGrid);
            this.Name = "AccountsGroup";
            this.Size = new System.Drawing.Size(300, 400);
            ((System.ComponentModel.ISupportInitialize)(this.accountsGrid)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
