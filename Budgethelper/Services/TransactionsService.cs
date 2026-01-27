using BudgetHelper.Models;
using BudgetHelper.Services;
using System.Collections.Generic;

namespace Budgethelper.Services
{
    public class TransactionsService
    {
        private readonly SqlService _sql;

        public TransactionsService(SqlService sql)
        {
            _sql = sql;
        }

        // UI ожидает List<Transaction>
        public List<Transaction> GetByAccount(long accountId)
        {
            // 🔧 ВРЕМЕННО: заглушка
            return new List<Transaction>();
        }

        // UI ожидает decimal
        public decimal GetBalance(long accountId)
        {
            // 🔧 ВРЕМЕННО: заглушка
            return 0m;
        }

        public void InsertTransaction(Transaction transaction)
        {
            // 🔧 позже подключим SQLite
        }
    }
}
