using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using Budgethelper.Models;

namespace Budgethelper.Services
{
    public static class SqlService
    {
        private static string ConnectionString
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Session.DbPath))
                    throw new Exception("Session.DbPath не установлен.");

                return $"Data Source={Session.DbPath};Version=3;";
            }
        }

        private static SQLiteConnection Open()
        {
            var dir = Path.GetDirectoryName(Session.DbPath);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            var connection = new SQLiteConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        // =========================
        // USER
        // =========================

        public static void SaveUser(Account user)
        {
            using (var con = Open())
            using (var cmd = new SQLiteCommand(con))
            {
                cmd.CommandText =
                @"CREATE TABLE IF NOT EXISTS User(
                    Uid TEXT PRIMARY KEY,
                    Name TEXT NOT NULL,
                    SureName TEXT NOT NULL,
                    LastName TEXT,
                    PasswordHash TEXT NOT NULL
                );";
                cmd.ExecuteNonQuery();

                cmd.CommandText =
                @"INSERT OR REPLACE INTO User
                  (Uid, Name, SureName, LastName, PasswordHash)
                  VALUES (@Uid,@Name,@SureName,@LastName,@PasswordHash);";

                cmd.Parameters.AddWithValue("@Uid", user.Uid);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@SureName", user.SureName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);

                cmd.ExecuteNonQuery();
            }
        }

        public static Account LoadUser()
        {
            using (var con = Open())
            using (var cmd = new SQLiteCommand(con))
            {
                cmd.CommandText =
                @"CREATE TABLE IF NOT EXISTS User(
                    Uid TEXT PRIMARY KEY,
                    Name TEXT NOT NULL,
                    SureName TEXT NOT NULL,
                    LastName TEXT,
                    PasswordHash TEXT NOT NULL
                );";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT * FROM User LIMIT 1;";

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Account
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

            return null;
        }

        // =========================
        // ACCOUNTS
        // =========================

        public static List<Account> LoadAccounts()
        {
            var list = new List<Account>();

            using (var con = Open())
            using (var cmd = new SQLiteCommand(con))
            {
                cmd.CommandText =
                @"CREATE TABLE IF NOT EXISTS Accounts(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Currency TEXT NOT NULL,
                    Description TEXT
                );";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT * FROM Accounts;";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Account
                        {
                            Uid = reader["Id"].ToString(),
                            Name = reader["Name"].ToString(),
                            SureName = reader["Currency"].ToString(),
                            LastName = reader["Description"].ToString()
                        });
                    }
                }
            }

            return list;
        }

        // =========================
        // TRANSACTIONS
        // =========================

        public static Transaction InsertTransaction(Transaction t)
        {
            using (var con = Open())
            using (var cmd = new SQLiteCommand(con))
            {
                cmd.CommandText =
                @"CREATE TABLE IF NOT EXISTS Transactions(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    AccountName TEXT NOT NULL,
                    Amount REAL NOT NULL,
                    OperationType INTEGER NOT NULL,
                    Date TEXT NOT NULL,
                    Description TEXT
                );";
                cmd.ExecuteNonQuery();

                cmd.CommandText =
                @"INSERT INTO Transactions
                  (AccountName,Amount,OperationType,Date,Description)
                  VALUES (@AccountName,@Amount,@OperationType,@Date,@Description);";

                cmd.Parameters.AddWithValue("@AccountName", t.AccountName);
                cmd.Parameters.AddWithValue("@Amount", t.Amount);
                cmd.Parameters.AddWithValue("@OperationType", (int)t.OperationType);
                cmd.Parameters.AddWithValue("@Date", t.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Description", t.Description);

                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT last_insert_rowid();";
                t.Id = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return t;
        }

        public static List<Transaction> LoadAllTransactions()
        {
            var list = new List<Transaction>();

            using (var con = Open())
            using (var cmd = new SQLiteCommand(con))
            {
                cmd.CommandText = "SELECT * FROM Transactions;";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Transaction
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            AccountName = reader["AccountName"].ToString(),
                            Amount = Convert.ToDecimal(reader["Amount"]),
                            OperationType = (TransactionType)Convert.ToInt32(reader["OperationType"]),
                            Date = DateTime.Parse(reader["Date"].ToString()),
                            Description = reader["Description"].ToString()
                        });
                    }
                }
            }

            return list;
        }

        public static List<Transaction> LoadTransactionsByAccount(string accountName)
        {
            var list = new List<Transaction>();

            using (var con = Open())
            using (var cmd = new SQLiteCommand(con))
            {
                cmd.CommandText =
                "SELECT * FROM Transactions WHERE AccountName=@AccountName;";

                cmd.Parameters.AddWithValue("@AccountName", accountName);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Transaction
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            AccountName = reader["AccountName"].ToString(),
                            Amount = Convert.ToDecimal(reader["Amount"]),
                            OperationType = (TransactionType)Convert.ToInt32(reader["OperationType"]),
                            Date = DateTime.Parse(reader["Date"].ToString()),
                            Description = reader["Description"].ToString()
                        });
                    }
                }
            }

            return list;
        }

        public static decimal CalculateBalance(string accountName)
        {
            decimal balance = 0;

            var transactions = LoadTransactionsByAccount(accountName);

            foreach (var t in transactions)
            {
                if (t.OperationType == TransactionType.Income)
                    balance += t.Amount;
                else
                    balance -= t.Amount;
            }

            return balance;
        }
    }
}
