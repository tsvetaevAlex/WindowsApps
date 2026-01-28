using System.Windows.Forms;

namespace Budgethelper.Controls
{
    partial class TransactionsGroup : UserControl
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewTransactions;

        /// <summary>
        /// Освобождение ресурсов
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewTransactions = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.AllowUserToAddRows = false;
            this.dataGridViewTransactions.AllowUserToDeleteRows = false;
            this.dataGridViewTransactions.Dock = DockStyle.Fill;
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.ReadOnly = true;
            this.dataGridViewTransactions.RowTemplate.Height = 25;
            this.dataGridViewTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // колонки
            this.dataGridViewTransactions.Columns.Add("Id", "ID");
            this.dataGridViewTransactions.Columns.Add("Date", "Дата");
            this.dataGridViewTransactions.Columns.Add("Amount", "Сумма");
            this.dataGridViewTransactions.Columns.Add("Description", "Описание");

            // 
            // TransactionsGroup
            // 
            this.Controls.Add(this.dataGridViewTransactions);
            this.Name = "TransactionsGroup";
            this.Size = new System.Drawing.Size(500, 300);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
