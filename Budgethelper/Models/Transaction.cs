using System;

namespace Budgethelper.Models
{
    public class Transaction
    {
        public int Id { get; set; }                 // AUTOINCREMENT
        public string AccountName { get; set; }       // string
        public decimal Amount { get; set; }
        public TransactionType OperationType { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
