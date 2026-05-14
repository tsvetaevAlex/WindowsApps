using System;

namespace Budgethelper.Models
{
    public class TransactionModel
    {
        public int Id { get; set; }
        public int AccountId { get; set; }  // must have
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public TransactionType OperationType { get; set; }
        public string Description { get; set; }
    }
}
