using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace Budgethelper.Services
{
    public static class SqlService
    {


           
        private static string connection = "Data Source=" + Session.DbPath + ";Version=3;";

        private static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connection);
        }

        // ================= INIT DATABASE =================
        public static void Initialize_Database()
        {
            Logger.SendMessage(Message_Type.traceroute, "SqlService.Initialize_Database()");
            string roamingAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "Roaming";
            string DbPath = Path.Combine(roamingAppDataPath, "Budgethelper\\budgethelper.sqlite");
            Session.DbPath = DbPath;
            Logger.SendMessage(Message_Type.DB, $"DbPath: ${DbPath}");

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

                //"Create table: TUser
                try
                {
                    new SQLiteCommand(users, conn).ExecuteNonQuery();
                    Logger.SendMessage(Message_Type.DB, $"Создаем таблицу: TUser");
                    Logger.SendMessage(Message_Type.DB_success, $"Таблица: TUser, успешно срздана");
                }
                catch (Exception e)
                {
                    Logger.SendMessage(Message_Type.DB_fail, $"Создание Таблицы: TUser. не удалось.");
                    Logger.SendMessage(Message_Type.Error, $"exception thrown {e.Message}");
                }

                //Create table: wallets
                try
                {
                    new SQLiteCommand(wallets, conn).ExecuteNonQuery();
                    Logger.SendMessage(Message_Type.DB, $"Создаем таблицу: wallets");
                }
                catch (Exception e)
                {
                Logger.SendMessage(Message_Type.DB_fail, $"Создание Таблицы: wallets. не удалось.");
                Logger.SendMessage(Message_Type.Error, $"exception thrown {e.Message}");
                }
                //Create table: accounts
                try
                {
                    new SQLiteCommand(accounts, conn).ExecuteNonQuery();
                    Logger.SendMessage(Message_Type.DB, $"Создаем таблицу: accounts");
                }
                catch (Exception e)
                {
                    Logger.SendMessage(Message_Type.DB_fail, $"Создание Таблицы: accounts. не удалось.");
                    Logger.SendMessage(Message_Type.Error, $"exception thrown {e.Message}");
                }
                //Create table: transactions
                try
                {
                    new SQLiteCommand(transactions, conn).ExecuteNonQuery();
                    Logger.SendMessage(Message_Type.DB, $"Создаем таблицу: transactions");
                }
                catch (Exception e)
                {
                    Logger.SendMessage(Message_Type.DB_fail, $"Создание Таблицы: transactions. не удалось.");
                    Logger.SendMessage(Message_Type.Error, $"exception thrown {e.Message}");
                }
            }
        }

        // ================= USER =================
        public static void CreateUser(User user)
        {
            Logger.SendMessage(Message_Type.traceroute, "SqlService.CreateUser(User user)");
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
            Logger.SendMessage(Message_Type.traceroute, "SqlService.GetUser(string uid)");

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
                            return new User(
                                reader.GetString(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4)
                            );
                        }
                    }
                }
            }

            return null;
        }

        // ================= WALLET =================
        public static int CreateWallet(WalletModel wallet)
        {
            Logger.SendMessage(Message_Type.traceroute, "SqlService.CreateWallet(WalletModel wallet)");
            int returnValue = -1;
            using (var conn = GetConnection())
            {
                conn.Open();

                string sql = @"INSERT INTO Wallets(UserUid,Name,Description)
                               VALUES(@UserUid,@Name,@Description);
                               SELECT last_insert_rowid();";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UserUid", wallet.UserUid);
                    cmd.Parameters.AddWithValue("@Name", wallet.Name);
                    cmd.Parameters.AddWithValue("@Description", wallet.Description);
                    returnValue =  Convert.ToInt32(cmd.ExecuteScalar());
                    Logger.SendMessage(Message_Type.DB_success,$"запись успешно добавлена в БазуДанных, присвоен iD: {returnValue}");
                }
                return returnValue;
            }
        }

        public static List<WalletModel> GetWallets(string userUid)
        {
            Logger.SendMessage(Message_Type.traceroute, "SqlService.GetWallets(string userUid)");

            var list = new List<WalletModel>();

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
                            list.Add(new WalletModel
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

        // ================= ACCOUNT =================
        public static int CreateAccount(AccountModel acc)
        {
            Logger.SendMessage(Message_Type.traceroute, "SqlService.CreateAccount(AccountModel acc)");

            using (var conn = GetConnection())
            {
                conn.Open();

                string sql = @"INSERT INTO Accounts(WalletId,Name,Type,Balance,Description)
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
            Logger.SendMessage(Message_Type.traceroute, "SqlService.GetAccounts(int walletId)");

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
                                (FundsSource_Type)Enum.Parse(typeof(FundsSource_Type), reader.GetString(3)),
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

        // ================= TRANSACTIONS =================
        public static int CreateTransaction(Transaction t)
        {
            Logger.SendMessage(Message_Type.traceroute, "SqlService.CreateTransaction(Transaction t)");

            using (var conn = GetConnection())
            {
                conn.Open();

                string sql = @"INSERT INTO Transactions(AccountId,Amount,Type,Date,Comment)
                               VALUES(@AccountId,@Amount,@Type,@Date,@Comment);
                               SELECT last_insert_rowid();";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountId", t.AccountId);
                    cmd.Parameters.AddWithValue("@Amount", t.Amount);
                    cmd.Parameters.AddWithValue("@Type", t.OperationType.ToString());
                    cmd.Parameters.AddWithValue("@Date", t.Date.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Comment", t.Description);

                    return Convert.ToInt32((long)cmd.ExecuteScalar());
                }
            }
        }

        public static void CreateTransaction(int accountId, DateTime date, decimal amount, TransactionType type, string description = "")
        {
            Logger.SendMessage(Message_Type.traceroute, "SqlService.CreateTransaction(int accountId, DateTime date, decimal amount, TransactionType type, string description = \"\")");

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

                string sql = @"SELECT Id,AccountId,Amount,Type,Date,Comment 
                               FROM Transactions 
                               WHERE AccountId=@AccountId";

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

        // ================= SESSION HELPERS =================
        public static void LoadWalletsToSession()
        {
            if (Session.CurrentUser != null)
                Session.WalletsList = GetWallets(Session.CurrentUser.Uid);
        }

        public static void LoadAccountsToSession(int walletId)
        {
            Session.AccountsList = GetAccounts(walletId);
        }

        // ================= TEST DATA =================
        public static void SeedTestData()
        {
            if (Session.CurrentUser == null)
                return;

            if (GetWallets(Session.CurrentUser.Uid).Count > 0)
                return;

            WalletModel fatherWallet = new WalletModel
            {
                UserUid = Session.CurrentUser.Uid,
                Name = "Father Black Leather Wallet",
                Description = "Father wallet"
            };

            int fatherWalletId = CreateWallet(fatherWallet);

            int fatherCash = CreateAccount(new AccountModel("Father Cash", FundsSource_Type.Cash, 500, "Добрый Папа")
            { WalletId = fatherWalletId });

            int fatherVisa = CreateAccount(new AccountModel("Father Visa", FundsSource_Type.Card, 2000, "Мамина Виза")
            { WalletId = fatherWalletId });

            int fatherMaster = CreateAccount(new AccountModel("Father MasterCard", FundsSource_Type.Card, 1500, "Папа МАстер")
            { WalletId = fatherWalletId });


            var Gift  = new Transaction
            {
                AccountId = fatherCash,
                Date = DateTime.Now.AddDays(-2),
                Amount = 120,
                OperationType = TransactionType.Income,
                Description = "Gift"
            };
            CreateTransaction(Gift);

            //CreateTransaction(fatherCash, DateTime.Now.AddDays(-1), 50, TransactionType.Expense, "Groceries");
            var Groceries = new Transaction
            {
                AccountId = fatherCash,
                Date = DateTime.Now.AddDays(-1),
                Amount = 50,
                OperationType = TransactionType.Expense,
                Description = "Groceries"
            };
            CreateTransaction(Groceries);
            var Fuel = new Transaction
            {
                AccountId = fatherCash,
                Date = DateTime.Now.AddDays(-1),
                Amount = 150,
                OperationType = TransactionType.Expense,
                Description = "Fuel"
            };
            //CreateTransaction(fatherVisa, DateTime.Now.AddDays(-1), 150, TransactionType.Expense, "Fuel");
            CreateTransaction(Fuel);

            WalletModel motherWallet = new WalletModel
            {
                UserUid = Session.CurrentUser.Uid,
                Name = "Mother Red Wallet",
                Description = "Mother wallet"
            };

            int motherWalletId = CreateWallet(motherWallet);

            int motherCash = CreateAccount(new AccountModel("Mother Cash", FundsSource_Type.Cash, 300, "")
            { WalletId = motherWalletId });

            int motherVisa = CreateAccount(new AccountModel("Mother Visa", FundsSource_Type.Card, 2500, "")
            { WalletId = motherWalletId });

            int motherDebit = CreateAccount(new AccountModel("Mother Debit Card", FundsSource_Type.Card, 1800, "")
            { WalletId = motherWalletId });

            CreateTransaction(motherCash, DateTime.Now.AddDays(-2), 80, TransactionType.Expense, "Cosmetics");
            CreateTransaction(motherVisa, DateTime.Now.AddDays(-5), 1500, TransactionType.Income, "Salary");
            CreateTransaction(motherDebit, DateTime.Now.AddDays(-1), 90, TransactionType.Expense, "Taxi");
        }
    }
}