using System.Collections.Generic;
using Budgethelper.Models;

namespace Budgethelper.Services
{
    /// <summary>
    /// Тонкий слой над SqlService для работы с транзакциями
    /// </summary>
    public static class TransactionsService
    {
        /// <summary>
        /// Добавить транзакцию и получить объект с Id
        /// </summary>
        public static Transaction Add(Transaction t)
        {
            return SqlService.AddTransaction(t);
        }

        /// <summary>
        /// Все транзакции
        /// </summary>
        public static List<Transaction> GetAll()
        {
            return SqlService.LoadTransactions();
        }

        /// <summary>
        /// Все транзакции конкретного аккаунта
        /// </summary>
        public static List<Transaction> GetByAccount(string accountId)
        {
            return SqlService.LoadTransactionsByAccount(accountId);
        }

        /// <summary>
        /// Баланс аккаунта
        /// </summary>
        public static decimal GetBalance(string accountId)
        {
            return SqlService.CalculateBalance(accountId);
        }
    }
}
