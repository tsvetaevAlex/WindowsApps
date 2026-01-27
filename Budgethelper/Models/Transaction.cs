using System;

namespace BudgetHelper.Models
{
    public enum TransactionType
    {
        Income,
        Expense
    }

    public class Transaction
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public decimal Amount { get; set; }
        public TransactionType Operation { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
    }
}
