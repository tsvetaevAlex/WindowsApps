namespace Budgethelper.Models
{
    public class Account
    {
        public int Id { get; set; }  // must have
        public string Uid { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
        public decimal Balance { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Currency})";
        }
    }
}
