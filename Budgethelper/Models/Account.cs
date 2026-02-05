namespace Budgethelper.Models
{
    public class Account
    {
        public int Id { get; set; } // must have
        public string Uid { get; set; }
        public string AccountName { get; set; }   // must have
        public decimal Balance { get; set; }
    }
}
