using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Collections.Generic;

namespace Budgethelper.Services
{
    public static class TransactionsService
    {
        public static List<Transaction> GetTransactions(int accountId)
        {
            return SqlService.GetTransactions(accountId);
        }

        public static void CreateTransaction(int accountId, DateTime date, decimal amount, TransactionType operationType, string description = "")
        {
            SqlService.CreateTransaction(accountId, date, amount, (int)operationType, description);
        }
    }
}
