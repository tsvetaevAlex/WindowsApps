namespace Budgethelper.Models
{
    public class AccountModel
    {
        public int AccountID { get; set; }
        public int WalletId { get; set; }
        public string AccountName { get; set; }
        public Money_SourceType sourceType { get; set; }
        public decimal Balance { get; set; }
        public string Description { get; set; }

        public AccountModel() { }

        public AccountModel(string _accName, Money_SourceType _type, decimal _balance, string _description)
        {
            AccountName = _accName;
            sourceType = _type;
            Balance = _balance;
            Description = _description;
        }

        public AccountModel(int id, string _accName, decimal _balance, string _description)
        {
            AccountID = id;
            AccountName = _accName;
            Balance = _balance;
            Description = _description;
        }

        public void SetID(int _id) => AccountID = _id;

        public override string ToString()
        {
            return $"account: id[{AccountID}], Wallet ID[{WalletId}], Account Name: {AccountName}, Account Balance: {Balance}, Description: {Description}";
        }
    }
}
