using System;
using System.Windows.Forms;
using Budgethelper.Models;

namespace Budgethelper.Controls
{
    public partial class TransactionsGroup : UserControl
    {
        private static int _AccCounter = 0;
        private static int _currentAccountId = 0;

        public TransactionsGroup()
        {

            // очищаем список при старте
            InitializeComponent();
            rtbTransact_QTY.Text = 0.ToString();
            comboType.DataSource = Enum.GetValues(typeof(TransactionType));
            rtbTransact_QTY.SelectAll();
            rtbTransact_QTY.SelectionAlignment = HorizontalAlignment.Right;
            rtbTransact_QTY.DeselectAll();
            //SetInactive();
        }

        public void Activate()
        {
            GB_Stats.Enabled = true;
        }

        public void SetActive(string accountName, int accountId)
        {
            Enabled = true;
            Session.CurrentAccount.AccountName = accountName;
            _currentAccountId = accountId;
            lblAccountName.Text = accountName;
        }

        public void SetAccount()
        {
            _currentAccountId = Session.CurrentAccount.AccountID;
            lblAccountName.Text = Session.CurrentAccount.AccountName;
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

        private void bAddTransact_Click(object sender, EventArgs e)
        {
            _AccCounter++;
            rtbTransact_QTY.Text = _AccCounter.ToString();
        }
    }
}
