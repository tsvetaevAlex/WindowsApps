using System;
using System.Windows.Forms;
using Budgethelper.Models;

namespace Budgethelper.Forms
{
    public partial class AddTransactionForm : Form
    {
        public int Amount { get; private set; }
        public TransactionType TransactionKind { get; private set; }
        public DateTime Date { get; private set; }
        public string Description { get; private set; }

        public AddTransactionForm()
        {
            InitializeComponent();

            cbType.Items.Add(TransactionType.Income);
            cbType.Items.Add(TransactionType.Expense);
            cbType.SelectedIndex = 0;

            dtpDate.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAmount.Text, out int amount) || amount <= 0)
            {
                MessageBox.Show("Invalid amount");
                return;
            }

            Amount = amount;
            TransactionKind = (TransactionType)cbType.SelectedItem;
            Date = dtpDate.Value.Date;
            Description = txtDescription.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
