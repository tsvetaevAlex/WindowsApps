using Budgethelper.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace Budgethelper.Services
{
    public static class SqlService
    {
        private static string GetConnectionString()
        {
            return $"Data Source={Session.DbPath};Version=3;";
        }

        #region Initialization

        public static void InitializeDatabase()
        {
            if (string.IsNullOrWhiteSpace(Session.DbPath))
                throw new Exception("Session.DbPath is not set.");

            if (!File.Exists(Session.DbPath))
                SQLiteConnection.CreateFile(Session.DbPath);

            using (var conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();

                string sqlUsers = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Uid TEXT PRIMARY KEY,
                    Name TEXT NOT NULL,
                    SureName TEXT NOT NULL,
                    LastName TEXT,
                    PasswordHash TEXT NOT NULL
                );";

                string sqlAccounts = @"
                CREATE TABLE IF NOT EXISTS Accounts (
                    AccountID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Uid TEXT NOT NULL,
                    AccountName TEXT NOT NULL,
                    Description TEXT NOT NULL,
                    Balance REAL NOT NULL DEFAULT 0,
                    FOREIGN KEY(Uid) REFERENCES Users(Uid)
                );";

                string sqlTransactions = @"
                CREATE TABLE IF NOT EXISTS Transactions (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    AccountId INTEGER NOT NULL,
                    Date TEXT NOT NULL,
                    Amount REAL NOT NULL,
                    OperationType INTEGER NOT NULL,
                    Description TEXT,
                    FOREIGN KEY(AccountId) REFERENCES Accounts(AccountID)
                );";

                using (var cmd = new SQLiteCommand(sqlUsers, conn)) cmd.ExecuteNonQuery();
                using (var cmd = new SQLiteCommand(sqlAccounts, conn)) cmd.ExecuteNonQuery();
                using (var cmd = new SQLiteCommand(sqlTransactions, conn)) cmd.ExecuteNonQuery();
            }
        }

        #endregion

        #region Users

        public static void CreateUser(User user)
        {
            using (var conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();

                string sql = @"INSERT OR IGNORE INTO Users
                               (Uid, Name, SureName, LastName, PasswordHash)
                               VALUES (@Uid, @Name, @SureName, @LastName, @PasswordHash)";

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

        public static User LoadUserByUid(string uid)
        {
            using (var conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();

                string sql = "SELECT * FROM Users WHERE Uid = @Uid";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Uid", uid);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User(
                                reader["Uid"].ToString(),
                                reader["Name"].ToString(),
                                reader["SureName"].ToString(),
                                reader["LastName"].ToString(),
                                reader["PasswordHash"].ToString()
                            );
                        }
                    }
                }
            }

            return null;
        }

        #endregion

        #region Accounts

        public static void CreateAccount(Account account)
        {
            using (var conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();

                string sql = @"INSERT INTO Accounts
                               (Uid, AccountName, Description, Balance)
                               VALUES (@Uid, @AccountName, @Description, @Balance)";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Uid", account.AccountID);
                    cmd.Parameters.AddWithValue("@AccountName", account.AccountName);
                    cmd.Parameters.AddWithValue("@Description", account.Description);
                    cmd.Parameters.AddWithValue("@Balance", account.Balance);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Account> GetAccounts(string userUid)
        {
            var list = new List<Account>();

            using (var conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();

                string sql = "SELECT * FROM Accounts WHERE Uid = @Uid";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Uid", userUid);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Account(
                                Convert.ToInt32(reader["AccountID"]),
                                reader["AccountName"].ToString(),
                                Convert.ToDecimal(reader["Balance"]),
                                reader["Description"].ToString()
                            ));
                        }
                    }
                }
            }

            return list;
        }

        #endregion

        #region Transactions

        public static void CreateTransaction(int accountId, DateTime date,
            decimal amount, int operationType, string description = "")
        {
            using (var conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();

                string sql = @"INSERT INTO Transactions
                               (AccountId, Date, Amount, OperationType, Description)
                               VALUES (@AccountId, @Date, @Amount, @OperationType, @Description)";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountId", accountId);
                    cmd.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@OperationType", operationType);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Transaction> GetTransactions(int accountId)
        {
            var list = new List<Transaction>();

            using (var conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();

                string sql = @"SELECT * FROM Transactions
                               WHERE AccountId = @AccountId
                               ORDER BY Date DESC";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountId", accountId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Transaction
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                AccountId = accountId,
                                Date = DateTime.Parse(reader["Date"].ToString()),
                                Amount = Convert.ToDecimal(reader["Amount"]),
                                OperationType = (TransactionType)
                                    Convert.ToInt32(reader["OperationType"]),
                                Description = reader["Description"].ToString()
                            });
                        }
                    }
                }
            }

            return list;
        }

        #endregion

        #region TestData

        public static void SeedTestData()
        {
            var user = new User(
                "test-user-001",
                "Test",
                "User",
                "Alpha",
                "123"
            );

            CreateUser(user);

            var acc1 = new Account(0, "School Canteen", 5000, "Катя питание");
            var acc2 = new Account(0, "ЖКХ", 20000, "Коммунальные услуги");
            var acc3 = new Account(0, "Honda", 30000, "Авто расходы");

            CreateAccount(acc1);
            CreateAccount(acc2);
            CreateAccount(acc3);
        }

        #endregion
    }
}
