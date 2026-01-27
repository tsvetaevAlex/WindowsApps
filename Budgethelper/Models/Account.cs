namespace BudgetHelper.Models
{
    public class Account
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; } // добавлено
        public string Currency { get; set; } // если нужно для SQL
    }
}
