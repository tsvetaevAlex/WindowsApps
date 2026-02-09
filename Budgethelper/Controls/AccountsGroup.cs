using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Budgethelper.Controls
{
    public partial class AccountsGroup : UserControl
    {
        public event Action<int> AccountSelected;

        private List<Account> _accounts = new List<Account>();
        public AccountsGroup()
        {
            InitializeComponent();
            Logger.SendMessage(MessageType.UI, "AccountsGroup initialized.", Color.LightBlue);
//            LoadAccounts();
        }
        /*
        private void LoadAccounts()
        {
            if (!Session.IsAuthorized)
                return;

            _accounts = SqlService.GetAccounts(Session.Uid);

            listAccounts.Items.Clear();

            foreach (var acc in _accounts)
            {
                listAccounts.Items.Add($"{acc.AccountName} ({acc.Balance})");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccountName.Text))
                return;

            SqlService.CreateAccount(Session.Uid, txtAccountName.Text.Trim(), 0);

            txtAccountName.Clear();
            LoadAccounts();
        }

        private void listAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAccounts.SelectedIndex < 0)
            {
                AccountSelected?.Invoke(0);
                return;
            }

            var selected = _accounts[listAccounts.SelectedIndex];
            AccountSelected?.Invoke(selected.Id);
        }
        */
    }
}
