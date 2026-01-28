using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Windows.Forms;

namespace Budgethelper.Controls
{
    public partial class AccountsGroup : UserControl
    {
        /// <summary>
        /// Срабатывает при выборе аккаунта.
        /// string = Account.Uid
        /// </summary>
        public event Action<string> AccountSelected;

        public AccountsGroup()
        {
            InitializeComponent();
            LoadAccounts();
        }

        private void LoadAccounts()
        {
            listBoxAccounts.Items.Clear();

            foreach (var acc in AccountsService.GetAll())
                listBoxAccounts.Items.Add(acc);
        }

        private void listBoxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAccounts.SelectedItem is Account acc)
            {
                AccountSelected?.Invoke(acc.Uid);
            }
        }
    }
}
