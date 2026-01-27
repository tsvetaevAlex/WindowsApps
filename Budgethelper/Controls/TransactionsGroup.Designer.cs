namespace Budgethelper.Controls
{
    partial class TransactionsGroup
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView transactionsGrid;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.transactionsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionsGrid
            // 
            this.transactionsGrid.AllowUserToAddRows = false;
            this.transactionsGrid.AllowUserToDeleteRows = false;
            this.transactionsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionsGrid.MultiSelect = false;
            this.transactionsGrid.ReadOnly = true;
            this.transactionsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // TransactionsGroup
            // 
            this.Controls.Add(this.transactionsGrid);
            this.Name = "TransactionsGroup";
            this.Size = new System.Drawing.Size(400, 400);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
