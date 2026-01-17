using System;
using System.Windows.Forms;
using BudgetHelper.Services;
using Budgethelper.Models;

namespace Budgethelper.Controls
{
    public partial class AccountsGroup : UserControl
    {
        private SqlService _sql;

        public event Action<string> AccountChanged;

        public string SelectedAccountId =>
            cmbAccounts.SelectedItem is AccountItem a ? a.Id : null;

        public AccountsGroup()
        {
            InitializeComponent();
        }

        public void Bind(SqlService sql)
        {
            _sql = sql;
            Reload();
        }

        public void Reload()
        {
            cmbAccounts.Items.Clear();
            foreach (var acc in _sql.GetAccounts())
                cmbAccounts.Items.Add(acc);

            if (cmbAccounts.Items.Count > 0)
                cmbAccounts.SelectedIndex = 0;
        }

        private void cmbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccountChanged?.Invoke(SelectedAccountId);
        }
    }
}
