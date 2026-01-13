using Budgethelper.Models;
using System;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    public partial class AddTransactionForm : Form
    {
        public int Amount => (int)nudAmount.Value;
        public TransactionType Type =>
            rbIncome.Checked ? TransactionType.Income : TransactionType.Expense;
        public string Description => txtDescription.Text;

        public AddTransactionForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Amount <= 0)
            {
                MessageBox.Show("Сумма должна быть больше 0");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
