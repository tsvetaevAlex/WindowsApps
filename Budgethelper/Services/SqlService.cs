using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using Budgethelper.Models;

namespace Budgethelper.Services
{
    public static class SqlService
    {
        /// <summary>
        /// Открыть соединение с базой текущего пользователя
        /// </summary>
        public static SQLiteConnection Open()
        {
            if (string.IsNullOrWhiteSpace(Session.DbPath))
                throw new Exception("UID не установлен, база данных недоступна.");

            Directory.CreateDirectory(Path.GetDirectoryName(Session.DbPath));
            return new SQLiteConnection($"Data Source={Session.DbPath};Version=3;");
        }

        #region Users

        public static void SaveUser(Account user, string passwordHash)
        {
            var db = Open();
            db.Open();

            using (var cmd = new SQLiteCommand(db))
            {
                cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Accounts (
                                        Uid TEXT PRIMARY KEY,
                                        Name TEXT,
                                        SureName TEXT,
                                        LastName TEXT,
                                        PasswordHash TEXT
                                    );";
                cmd.ExecuteNonQuery();

                cmd.CommandText = @"INSERT OR REPLACE INTO Accounts (Uid, Name, SureName, LastName, PasswordHash)
                                    VALUES (@Uid, @Name, @SureName, @LastName, @PasswordHash);";
                cmd.Parameters.AddWithValue("@Uid", user.Uid);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@SureName", user.SureName);
                cmd.Parameters.AddWithValue("@LastName", user.LastName);
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                cmd.ExecuteNonQuery();
            }

            db.Close();
        }

        public static Account LoadUser()
        {
            if (string.IsNullOrWhiteSpace(Session.Uid))
                return null;

            var db = Open();
            db.Open();

            Account user = null;
            using (var cmd = new SQLiteCommand(db))
            {
                cmd.CommandText = "SELECT * FROM Accounts WHERE Uid = @Uid;";
                cmd.Parameters.AddWithValue("@Uid", Session.Uid);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new Account
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

            db.Close();
            return user;
        }

        #endregion

        #region Transactions

        public static Transaction AddTransaction(Transaction t)
        {
            var db = Open();
            db.Open();

            using (var cmd = new SQLiteCommand(db))
            {
                cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Transactions (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        AccountId TEXT,
                                        Date TEXT,
                                        Amount REAL,
                                        Description TEXT
                                    );";
                cmd.ExecuteNonQuery();

                cmd.CommandText = @"INSERT INTO Transactions (AccountId, Date, Amount, Description)
                                    VALUES (@AccountId, @Date, @Amount, @Description);";
                cmd.Parameters.AddWithValue("@AccountId", t.AccountId);
                cmd.Parameters.AddWithValue("@Date", t.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Amount", t.Amount);
                cmd.Parameters.AddWithValue("@Description", t.Description);
                cmd.ExecuteNonQuery();

                // Получаем Id последней вставленной транзакции
                cmd.CommandText = "SELECT last_insert_rowid();";
                t.Id = Convert.ToInt32(cmd.ExecuteScalar());
            }

            db.Close();
            return t;
        }

        public static List<Transaction> LoadTransactions()
        {
            var db = Open();
            db.Open();

            var list = new List<Transaction>();
            using (var cmd = new SQLiteCommand("SELECT * FROM Transactions;", db))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new Transaction
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        AccountId = reader["AccountId"].ToString(),
                        Date = DateTime.Parse(reader["Date"].ToString()),
                        Amount = Convert.ToDecimal(reader["Amount"]),
                        Description = reader["Description"].ToString()
                    });
                }
            }

            db.Close();
            return list;
        }

        public static List<Transaction> LoadTransactionsByAccount(string accountId)
        {
            var all = LoadTransactions();
            return all.FindAll(t => t.AccountId == accountId);
        }

        public static decimal CalculateBalance(string accountId)
        {
            var transactions = LoadTransactionsByAccount(accountId);
            decimal sum = 0;
            foreach (var t in transactions)
                sum += t.Amount;
            return sum;
        }

        #endregion
    }
}
