using System;

namespace Budgethelper.Models
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
