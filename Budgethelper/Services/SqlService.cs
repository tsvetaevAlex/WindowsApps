using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Budgethelper.Models;

namespace Budgethelper.Services
{
    public static class SqlService
    {
        private static string connection = "Data Source=" + Session.DbPath + ";Version=3;";

        private static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connection);
        }

        // ================== INIT DATABASE ==================
        public static void Initialize_Database()
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                string users = @"CREATE TABLE IF NOT EXISTS Users(
                                Uid TEXT PRIMARY KEY,
                                Name TEXT,
                                SureName TEXT,
                                LastName TEXT,
                                PasswordHash TEXT
                             );";

                string wallets = @"CREATE TABLE IF NOT EXISTS Wallets(
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                UserUid TEXT,
                                Name TEXT,
                                Description TEXT
                               );";

                string accounts = @"CREATE TABLE IF NOT EXISTS Accounts(
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                WalletId INTEGER,
                                Name TEXT,
                                Type TEXT,
                                Balance REAL,
                                Description TEXT
                                );";

                string transactions = @"CREATE TABLE IF NOT EXISTS Transactions(
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        AccountId INTEGER,
                                        Amount REAL,
                                        Type TEXT,
                                        Date TEXT,
                                        Comment TEXT
                                   );";

                new SQLiteCommand(users, conn).ExecuteNonQuery();
                new SQLiteCommand(wallets, conn).ExecuteNonQuery();
                new SQLiteCommand(accounts, conn).ExecuteNonQuery();
                new SQLiteCommand(transactions, conn).ExecuteNonQuery();
            }
        }

        // ================== USER ==================
        public static void CreateUser(User user)
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                string sql = @"INSERT INTO Users(Uid,Name,SureName,LastName,PasswordHash)
                               VALUES(@Uid,@Name,@SureName,@LastName,@PasswordHash);";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Uid", user.Uid);
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@SureName", user.SureName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static User GetUser(string uid)
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                string sql = @"SELECT Uid,Name,SureName,LastName,PasswordHash FROM Users WHERE Uid=@Uid";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Uid", uid);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Uid = reader.GetString(0),
                                Name = reader.GetString(1),
                                SureName = reader.GetString(2),
                                LastName = reader.GetString(3),
                                PasswordHash = reader.GetString(4)
                            };
                        }
                    }
                }
            }
            return null;
        }

        // ================== WALLET ==================
        public static int CreateWallet()
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                string sql = @"INSERT INTO Wallets(UserUid, Name, Description)
                               VALUES(@UserUid,@Name,@Description);
                               SELECT last_insert_rowid();";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserUid", wallet.UserUid);
                    cmd.Parameters.AddWithValue("@Name", wallet.Name);
                    cmd.Parameters.AddWithValue("@Description", wallet.Description);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public static List<WalletControl> GetWallets(string userUid)
        {
            var list = new List<WalletControl>();

            using (var conn = GetConnection())
            {
                conn.Open();

                string sql = @"SELECT Id,UserUid,Name,Description FROM Wallets WHERE UserUid=@UserUid";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserUid", userUid);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new WalletControl
                            {
                                Id = reader.GetInt32(0),
                                UserUid = reader.GetString(1),
                                Name = reader.GetString(2),
                                Description = reader.GetString(3)
                            });
                        }
                    }
                }
            }

            return list;
        }

        // ================== ACCOUNT ==================
        public static int CreateAccount(AccountModel acc)
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                string sql = @"INSERT INTO Accounts(WalletId, Name, Type, Balance, Description)
                               VALUES(@WalletId,@Name,@Type,@Balance,@Description);
                               SELECT last_insert_rowid();";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@WalletId", acc.WalletId);
                    cmd.Parameters.AddWithValue("@Name", acc.AccountName);
                    cmd.Parameters.AddWithValue("@Type", acc.sourceType.ToString());
                    cmd.Parameters.AddWithValue("@Balance", acc.Balance);
                    cmd.Parameters.AddWithValue("@Description", acc.Description);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public static List<AccountModel> GetAccounts(int walletId)
        {
            var list = new List<AccountModel>();

            using (var conn = GetConnection())
            {
                conn.Open();

                string sql = @"SELECT Id,WalletId,Name,Type,Balance,Description FROM Accounts WHERE WalletId=@WalletId";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@WalletId", walletId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AccountModel acc = new AccountModel(
                                reader.GetString(2),
                                (Money_SourceType)Enum.Parse(typeof(Money_SourceType), reader.GetString(3)),
                                reader.GetDecimal(4),
                                reader.GetString(5)
                            );
                            acc.AccountID = reader.GetInt32(0);
                            acc.WalletId = reader.GetInt32(1);
                            list.Add(acc);
                        }
                    }
                }
            }

            return list;
        }

        public static AccountModel GetAccount(int accountId)
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                string sql = @"SELECT Id,WalletId,Name,Type,Balance,Description FROM Accounts WHERE Id=@Id";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", accountId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            AccountModel acc = new AccountModel(
                                reader.GetString(2),
                                (Money_SourceType)Enum.Parse(typeof(Money_SourceType), reader.GetString(3)),
                                reader.GetDecimal(4),
                                reader.GetString(5)
                            );
                            acc.AccountID = reader.GetInt32(0);
                            acc.WalletId = reader.GetInt32(1);
                            return acc;
                        }
                    }
                }
            }

            return null;
        }

        // ================== TRANSACTION ==================
        public static int CreateTransaction(Transaction t)
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                string sql = @"INSERT INTO Transactions(AccountId, Amount, Type, Date, Comment)
                       VALUES(@AccountId,@Amount,@Type,@Date,@Comment);
                       SELECT last_insert_rowid();";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountId", t.AccountId);
                    cmd.Parameters.AddWithValue("@Amount", t.Amount);
                    cmd.Parameters.AddWithValue("@Type", t.OperationType.ToString());
                    cmd.Parameters.AddWithValue("@Date", t.Date.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Comment", t.Description);

                    long id = (long)cmd.ExecuteScalar();   // SQLite возвращает long
                    return (int)id;
                }
            }
        }

        public static void CreateTransaction(int accountId, DateTime date, decimal amount, TransactionType type, string description = "")
        {
            CreateTransaction(new Transaction
            {
                AccountId = accountId,
                Date = date,
                Amount = amount,
                OperationType = type,
                Description = description
            });
        }

        public static List<Transaction> GetTransactions(int accountId)
        {
            var list = new List<Transaction>();

            using (var conn = GetConnection())
            {
                conn.Open();

                string sql = @"SELECT Id,AccountId,Amount,Type,Date,Comment FROM Transactions WHERE AccountId=@AccountId";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountId", accountId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Transaction
                            {
                                Id = reader.GetInt32(0),
                                AccountId = reader.GetInt32(1),
                                Amount = reader.GetDecimal(2),
                                OperationType = (TransactionType)Enum.Parse(typeof(TransactionType), reader.GetString(3)),
                                Date = DateTime.Parse(reader.GetString(4)),
                                Description = reader.GetString(5)
                            });
                        }
                    }
                }
            }

            return list;
        }

        // ================== SESSION HELPERS ==================
        public static void LoadWalletsToSession()
        {
            if (Session.CurrentUser != null)
                Session.WalletsList = GetWallets(Session.CurrentUser.Uid);
        }

        public static void LoadAccountsToSession(int walletId)
        {
            Session.AccountsList = GetAccounts(walletId);
        }
    }
}
