using System;
using System.Windows.Forms;
using BudgetHelper.Services;
using BudgetHelper.Models;
using System.Collections.Generic;
using Budgethelper.Services;

namespace Budgethelper.Controls
{
    public partial class TransactionsGroup : UserControl
    {
        private readonly TransactionsService _transactionsService;
        private long _accountId;

        public event Action<decimal> BalanceChanged;

        public TransactionsGroup(TransactionsService service)
        {
            InitializeComponent();
            _transactionsService = service;
        }

        public void SetAccount(long accountId)
        {
            _accountId = accountId;
            RefreshTransactions();
        }

        private void RefreshTransactions()
        {
            if (_accountId == 0) return;

            List<Transaction> transactions = _transactionsService.GetByAccount(_accountId);
            transactionsGrid.DataSource = transactions;

            decimal balance = _transactionsService.GetBalance(_accountId);
            BalanceChanged?.Invoke(balance);
        }
    }
}
