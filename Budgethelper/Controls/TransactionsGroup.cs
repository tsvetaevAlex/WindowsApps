using System;
using System.Windows.Forms;
using Budgethelper.Models;

namespace Budgethelper.Controls
{
    public partial class TransactionsGroup : UserControl
    {
        private string _currentAccountName;
        private int _currentAccountId;

        public TransactionsGroup()
        {
            InitializeComponent();

            comboType.DataSource = Enum.GetValues(typeof(TransactionType));
            SetInactive();
        }

        public void SetInactive()
        {
            Enabled = false;
            grid.Rows.Clear();
        }

        public void SetActive(string accountName, int accountId)
        {
            Enabled = true;
            _currentAccountName = accountName;
            _currentAccountId = accountId;
            lblAccountName.Text = accountName;
        }

        public void SetAccountName(string name)
        {
            _currentAccountName = name;
            lblAccountName.Text = name;
        }

        public Transaction GetTransactionFromInputs()
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
                throw new Exception("Сумма введена неверно.");

            return new Transaction
            {
                AccountId = _currentAccountId,
                Date = datePicker.Value,
                Amount = amount,
                OperationType = (TransactionType)comboType.SelectedItem,
                Description = txtDescription.Text
            };
        }

        private void BtnYesterday_Click(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Today.AddDays(-1);
        }

        private void BtnToday_Click(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Today;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
