using System;
using System.Windows.Forms;
using BudgetHelper.Services;
using BudgetHelper.Models;

namespace Budgethelper.Controls
{
    public partial class AccountsGroup : UserControl
    {
        private readonly AccountsService _accountsService;

        public event Action<long> AccountSelected;

        public AccountsGroup(AccountsService accountsService)
        {
            InitializeComponent();
            _accountsService = accountsService;
        }

        public void LoadAccounts()
        {
            var accounts = _accountsService.GetAccounts();
            accountsGrid.DataSource = accounts;
        }

        private void accountsGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (accountsGrid.CurrentRow?.DataBoundItem is Account account)
                AccountSelected?.Invoke(account.Id);
        }
    }
}
