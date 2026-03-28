namespace Budgethelper.Models
{
    public class WalletModel
    {
        public int Id { get; set; }          // ID кошелька в БД
                                             // получено при помощи функции last_insert_rowid()
                                             // из using Microsoft.Data.Sqlite;

        public string Name { get; set; }     // Имя кошелька (например "Основной")
        public string Description { get; set; }     // коорткое описание (назначение)

        public string UserUid { get; set; }  // UID пользователя (Session.Uid) | Owner ID equivalent of  UserUid

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