using System.Collections.Generic;
using Budgethelper.Models;

namespace Budgethelper.Services
{
    public static class TransactionsService
    {
        /// <summary>
        /// Добавление транзакции.
        /// Возвращает объект уже с заполненным Id (AUTOINCREMENT).
        /// </summary>
        public static Transaction Add(Transaction transaction)
        {
            return SqlService.InsertTransaction(transaction);
        }

        /// <summary>
        /// Все транзакции
        /// </summary>
        public static List<Transaction> GetAll()
        {
            return SqlService.LoadAllTransactions();
        }

        /// <summary>
        /// Транзакции по конкретному счету
        /// </summary>
        public static List<Transaction> GetByAccount(string accountName)
        {
            return SqlService.LoadTransactionsByAccount(accountName);
        }

        /// <summary>
        /// Баланс счета (Income - Expense)
        /// </summary>
        public static decimal GetBalance(string accountName)
        {
            return SqlService.CalculateBalance(accountName);
        }
    }
}
