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

        /// <summary>
        /// Инициализация базы данных: создаёт файл и все таблицы, если их нет
        /// </summary>
        public static void InitializeDatabase()
        {
            if (string.IsNullOrWhiteSpace(Session.DbPath))
                throw new Exception("Путь к базе данных не установлен в Session.DbPath");

            if (!File.Exists(Session.DbPath))
            {
                SQLiteConnection.CreateFile(Session.DbPath);
            }

            using (var conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();

                // Таблица Users
                string sqlUsers = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Uid TEXT PRIMARY KEY,
                        Name TEXT NOT NULL,
                        SureName TEXT NOT NULL,
                        LastName TEXT,
                        PasswordHash TEXT NOT NULL
                    );
                ";
                using (var cmd = new SQLiteCommand(sqlUsers, conn)) { cmd.ExecuteNonQuery(); }

                // Таблица Accounts
                string sqlAccounts = @"
                    CREATE TABLE IF NOT EXISTS Accounts (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Uid TEXT NOT NULL,
                        AccountName TEXT NOT NULL,
                        Balance REAL NOT NULL DEFAULT 0,
                        FOREIGN KEY(Uid) REFERENCES Users(Uid)
                    );
                ";
                using (var cmd = new SQLiteCommand(sqlAccounts, conn)) { cmd.ExecuteNonQuery(); }

                // Таблица Transactions
                string sqlTransactions = @"
                    CREATE TABLE IF NOT EXISTS Transactions (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        AccountId INTEGER NOT NULL,
                        Date TEXT NOT NULL,
                        Amount REAL NOT NULL,
                        OperationType INTEGER NOT NULL,
                        Description TEXT,
                        FOREIGN KEY(AccountId) REFERENCES Accounts(Id)
                    );
                ";
                using (var cmd = new SQLiteCommand(sqlTransactions, conn)) { cmd.ExecuteNonQuery(); }
            }
        }

        // ===================== Пользователи =====================
        public static void CreateUser(User user)
        {
            InitializeDatabase();

            using (var conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();
                string sql = "INSERT INTO Users (Uid, Name, SureName, LastName, PasswordHash) VALUES (@Uid, @Name, @SureName, @LastName, @PasswordHash)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Uid", user.Uid);
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@SureName", user.SureName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName ?? "");
                    cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static User LoadUserByUid(string uid)
        {
            InitializeDatabase();

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
                            return new User
                            {
                                Uid = reader["Uid"].ToString(),
                                Name = reader["Name"].ToString(),
                                SureName = reader["SureName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                PasswordHash = reader["PasswordHash"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        // ===================== Аккаунты =====================
        public static void CreateAccount(string userUid, string accountName, decimal initialBalance = 0)
        {
            InitializeDatabase();

            using (var conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();
                string sql = "INSERT INTO Accounts (Uid, AccountName, Balance) VALUES (@Uid, @AccountName, @Balance)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Uid", userUid);
                    cmd.Parameters.AddWithValue("@AccountName", accountName);
                    cmd.Parameters.AddWithValue("@Balance", initialBalance);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Account> GetAccounts(string userUid)
        {
            InitializeDatabase();
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
                            list.Add(new Account
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Uid = userUid,
                                AccountName = reader["AccountName"].ToString(),
                                Balance = Convert.ToDecimal(reader["Balance"])
                            });
                        }
                    }
                }
            }

            return list;
        }

        // ===================== Транзакции =====================
        public static void CreateTransaction(int accountId, DateTime date, decimal amount, int operationType, string description = "")
        {
            InitializeDatabase();

            using (var conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();
                string sql = "INSERT INTO Transactions (AccountId, Date, Amount, OperationType, Description) VALUES (@AccountId, @Date, @Amount, @OperationType, @Description)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountId", accountId);
                    cmd.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@OperationType", operationType);
                    cmd.Parameters.AddWithValue("@Description", description ?? "");
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Transaction> GetTransactions(int accountId)
        {
            InitializeDatabase();
            var list = new List<Transaction>();

            using (var conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();
                string sql = "SELECT * FROM Transactions WHERE AccountId = @AccountId ORDER BY Date DESC";
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
                                OperationType = (TransactionType)Convert.ToInt32(reader["OperationType"]),
                                Description = reader["Description"].ToString()
                            });
                        }
                    }
                }
            }

            return list;
        }

    } // End of public static class SqlService
} // End of namespace Budgethelper.Services

