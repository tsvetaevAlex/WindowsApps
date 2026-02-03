using System.Collections.Generic;
using Budgethelper.Models;

namespace Budgethelper.Services
{
    public static class TransactionsService
    {
        public static List<Transaction> LoadTransactions(string accountName)
        {
            return SqlService.GetTransactions(accountName);
        }

        public static void Create(Transaction transaction)
        {
            SqlService.CreateTransaction(transaction);
        }
    }
}
