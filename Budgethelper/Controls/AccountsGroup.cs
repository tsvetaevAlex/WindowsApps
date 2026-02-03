using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Budgethelper.Controls
{
    public partial class AccountsGroup : UserControl
    {
        public event Action<Account> AccountSelected;

        public AccountsGroup()
        {
            InitializeComponent();
        }

        public void LoadAccounts()
        {
            listAccounts.Items.Clear();
            if (!Session.IsAuthorized) return;

            var accounts = SqlService.GetAccounts(Session.Uid);
            foreach (var acc in accounts)
                listAccounts.Items.Add(acc);
        }

        private void listAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAccounts.SelectedItem is Account acc)
                AccountSelected?.Invoke(acc);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)) return;

            string currency = tabControl1.SelectedTab == tabRur ? "RUR" : "USD";

            var account = new Account
            {
                Uid = Session.Uid,
                Name = txtName.Text.Trim(),
                Currency = currency,
                Description = txtDescription.Text.Trim(),
                Balance = 0
            };

            SqlService.CreateAccount(account);
            txtName.Clear();
            txtDescription.Clear();
            LoadAccounts();
        }
    }
}
        