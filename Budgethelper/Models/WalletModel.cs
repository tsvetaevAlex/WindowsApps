namespace Budgethelper.Models
{
    public class WalletModel
    {
        public int Id { get; set; }          // ID кошелька в БД

        public string Name { get; set; }     // Имя кошелька (например "Основной")
        public string Description { get; set; }     // коорткое описание (назначение)

        public string UserUid { get; set; } // UID пользователя (Session.Uid)

        public WalletModel()
        {
        }

        public WalletModel(string name, string ownerUid)
        {
            Name = name;
            UserUid = ownerUid;
        }
    }
}