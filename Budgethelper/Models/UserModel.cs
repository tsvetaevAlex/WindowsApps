namespace Budgethelper.Models
{
    public class UserModel
    {
        public string Uid { get; set; }
        public string Name { get; set; }
        public string SureName { get; set; }
        public string LastName { get; set; }
        public string PasswordHash { get; set; }

        public UserModel(string _id, string _Name, string _SureName, string _LastName, string _PasswordHash)
        {
            Uid = _id;
            Name = _Name;
            SureName = _SureName;
            LastName = _LastName;
            PasswordHash = _PasswordHash;

        }
    }
}
