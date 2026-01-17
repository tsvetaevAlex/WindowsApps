namespace Budgethelper.Models
{
    public class AccountItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Name} | Balance: {Balance:N2}";
        }
    }
}
