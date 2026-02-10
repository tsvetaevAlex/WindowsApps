namespace Budgethelper.Models
{
    public class Account
    {
        public int AccountID { get; set; } // account order number in creation order 
        public string AccountName { get; set; }   // must have
        public decimal Balance { get; set; }
        public string Description { get; set; }   // must have

        public Account(int _id, string _accName, decimal _balanse, string _description)
        {
            AccountID = _id;
            AccountName = _accName;
            Balance = _balanse;
            Description = _description;
        }
    }
}
