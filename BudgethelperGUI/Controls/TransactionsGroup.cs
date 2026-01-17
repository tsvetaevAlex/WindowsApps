using System;
using System.Windows.Forms;
using BudgetHelper.Services;
using Budgethelper.Models;

namespace Budgethelper.Controls
{
    public partial class TransactionsGroup : UserControl
    {
        private SqlService _sql;
        private Func<string> _getAccount;

        public event Action TransactionAdded;

        public TransactionsGroup()
        {
            InitializeComponent();
            Enabled = false;
        }

        public void Bind(SqlService sql, Func<string> selectedAccount)
        {
            _sql = sql;
            _getAccount = selectedAccount;
        }

        public void EnableForAccount(bool enabled)
        {
            Enabled = enabled;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text, out var amount))
                return;

            _sql.AddTransaction(
                _getAccount(),
                amount,
                (TransactionType)cmbType.SelectedItem,
                txtDescription.Text,
                dtpDate.Value
            );

            txtAmount.Clear();
            txtDescription.Clear();

            TransactionAdded?.Invoke();
        }
    }
}
