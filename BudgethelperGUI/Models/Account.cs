namespace BudgethelperGUI.Models
{
    public class Account
    {
        public string Name { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }

        public Account(string name, string currency, decimal balance)
        {
            Name = name;
            Currency = currency;
            Balance = balance;
        }
    }
}
