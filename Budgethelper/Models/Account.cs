namespace Budgethelper.Models
{
    public class Account
    {
        public string Uid { get; set; } // md5 хэш для UID
        public string Name { get; set; }
        public string SureName { get; set; }
        public string LastName { get; set; }
        public string PasswordHash { get; set; }

        public override string ToString() => $"{SureName} {Name} {LastName}";
    }
}
