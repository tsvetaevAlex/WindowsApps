using System;
using System.Collections.Generic;
using Budgethelper.Models;

namespace BudgetHelper.Services
{
    public class SqlService
    {
        public SqlService(string userId) { }

        public List<AccountItem> GetAccounts()
        {
            return new List<AccountItem>
            {
                new AccountItem { Id="1", Name="Cash", Balance=1200 },
                new AccountItem { Id="2", Name="Card", Balance=5400 }
            };
        }

        public void AddTransaction(
            string accountId,
            decimal amount,
            TransactionType type,
            string description,
            DateTime date)
        {
            // INSERT INTO transactions
            // UPDATE accounts SET balance = balance +/- amount
        }

        public List<Transaction> LoadTransactions(
            string accountId,
            DateTime from,
            DateTime to,
            TransactionType? type)
        {
            return new List<Transaction>
            {
                new Transaction
                {
                    Date = DateTime.Today,
                    Type = TransactionType.Income,
                    Amount = 500,
                    Description = "Salary"
                },
                new Transaction
                {
                    Date = DateTime.Today,
                    Type = TransactionType.Expense,
                    Amount = 120,
                    Description = "Food"
                }
            };
        }
    }
}
