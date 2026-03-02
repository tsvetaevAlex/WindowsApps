using Budgethelper.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text.RegularExpressions;

namespace Budgethelper.Services
{
    public static class SqlService
    {
        private static string GetConnectionString()
        {
            return $"Data Source={Session.DbPath};Version=3;";
        }

        #region Initialization

        public static void Initialize_Database()
        {
            Logger.SendMessage(MessageType.traceroute, "SqlService/InitializeDatabase");

            if (string.IsNullOrWhiteSpace(Session.DbPath))
                throw new Exception("Session.DbPath is not set.");

            if (!File.Exists(Session.DbPath))
                SQLiteConnection.CreateFile(Session.DbPath);

            using (SQLiteConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();

                string sqlTUser =
                    "CREATE TABLE IF NOT EXISTS TUser (" +
                    "Uid TEXT PRIMARY KEY, " +
                    "Name TEXT NOT NULL, " +
                    "SureName TEXT NOT NULL, " +
                    "LastName TEXT, " +
                    "PasswordHash TEXT NOT NULL);";

                string sqlAccounts =
                    "CREATE TABLE IF NOT EXISTS Accounts (" +
                    "AccountID INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    "AccountName TEXT NOT NULL, " +
                    "Description TEXT NOT NULL, " +
                    "Balance REAL NOT NULL DEFAULT 0);";

                string sqlTransactions =
                    "CREATE TABLE IF NOT EXISTS Transactions (" +
                    "Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    "AccountId INTEGER NOT NULL, " +
                    "Date TEXT NOT NULL, " +
                    "Amount REAL NOT NULL, " +
                    "OperationType INTEGER NOT NULL, " +
                    "Description TEXT, " +
                    "FOREIGN KEY(AccountId) REFERENCES Accounts(AccountID));";

                ExecuteNonQuery(conn, sqlTUser); VerifyTableCreation("TUser");
                ExecuteNonQuery(conn, sqlAccounts); VerifyTableCreation("Accounts");
                ExecuteNonQuery(conn, sqlTransactions); VerifyTableCreation("Transactions");
            }

            SeedTestData();
            LoadAccountsToSession();
        }

        private static void ExecuteNonQuery(SQLiteConnection conn, string sql)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(Normalize_SQL_Request(sql), conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        #endregion

        #region Users

        public static void CreateUser(User user)
        {
            using (SQLiteConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();

                string sql =
                    @"INSERT OR IGNORE INTO TUser 
                      (Uid, Name, SureName, LastName, PasswordHash)
                      VALUES 
                      (@Uid, @Name, @SureName, @LastName, @PasswordHash)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Uid", user.Uid);
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@SureName", user.SureName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);

                    int result = cmd.ExecuteNonQuery();

                    Logger.SendMessage(
                        result > 0 ? MessageType.DB_success : MessageType.DB_fail,
                        result > 0 ? "User inserted" : "User not inserted");
                }
            }
        }

        #endregion

        #region Accounts

        public static void CreateAccount(Account account)
        {
            using (SQLiteConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();

                string sql =
                    "INSERT INTO Accounts (AccountName, Description, Balance) " +
                    "VALUES (@name, @description, @balance); " +
                    "SELECT last_insert_rowid();";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", account.AccountName);
                    cmd.Parameters.AddWithValue("@description", account.Description);
                    cmd.Parameters.AddWithValue("@balance", account.Balance);

                    long newId = (long)cmd.ExecuteScalar();

                    // ✅ вот здесь мы заполняем AccountID
                    account.AccountID = (int)newId;
                }
            }
        }


        public static List<Account> GetAccounts()
        {
            List<Account> list = new List<Account>();

            using (SQLiteConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();

                string sql = "SELECT * FROM Accounts";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
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

            return list;
        }

        public static void LoadAccountsToSession()
        {
            Logger.SendMessage(MessageType.traceroute, "SqlService/LoadAccountsToSession");

            Session.AccountsList = GetAccounts();

            Logger.SendMessage(MessageType.Account,
                $"Accounts loaded: {Session.AccountsList.Count}");
        }

        #endregion

        #region Transactions

        public static int CreateTransaction(
            int accountId,
            DateTime date,
            decimal amount,
            int operationType,
            string description)
        {
            using (SQLiteConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();

                string sql =
                    @"INSERT INTO Transactions
                      (AccountId, Date, Amount, OperationType, Description)
                      VALUES
                      (@AccountId, @Date, @Amount, @OperationType, @Description);
                      SELECT last_insert_rowid();";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountId", accountId);
                    cmd.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@OperationType", operationType);
                    cmd.Parameters.AddWithValue("@Description", description ?? "");

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public static List<Transaction> GetTransactions(int accountId)
        {
            List<Transaction> list = new List<Transaction>();

            using (SQLiteConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();

                string sql =
                    @"SELECT * FROM Transactions
                      WHERE AccountId = @AccountId
                      ORDER BY Date DESC";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountId", accountId);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
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

        #endregion

        #region TestData

        public static void SeedTestData()
        {
            Logger.SendMessage(MessageType.traceroute, "SqlService/SeedTestData");

            var testUser = new User("1458569m", "Александр", "Цветаев", "Александрович", "123654");

            Session.CurrentUser = testUser;
            CreateUser(testUser);

            Account[] accounts = new[]
            {
                new Account(0, "School Canteen", 5000, "Катя питание"),
                new Account(0, "ЖКХ", 20000, "Коммунальные услуги"),
                new Account(0, "Honda", 30000, "Авто расходы"),
                new Account(0, "Продукты", 40000, "Расходы на питание"),
                new Account(0, "Одежда", 35000, "Обновка сезонная")
            };

            foreach (Account acc in accounts)
            {
                CreateAccount(acc);
                Logger.SendMessage(MessageType.Account,
                    $"Account Created: {acc.AccountName} | Balance: {acc.Balance}");
            }
        }

        #endregion

        #region Utils

        private static string Normalize_SQL_Request(string sql)
        {
            if (string.IsNullOrEmpty(sql))
                throw new Exception("SQL is null");

            return Regex.Replace(sql, @"\s+", " ").Trim();
        }

        private static void VerifyTableCreation(string tableName)
        {
            using (SQLiteConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();

                string checkSql =
                    $"SELECT name FROM sqlite_master WHERE type='table' AND name='{tableName}';";

                using (SQLiteCommand checkCmd = new SQLiteCommand(checkSql, conn))
                {
                    object result = checkCmd.ExecuteScalar();

                    Logger.SendMessage(
                        result == null ? MessageType.DB_fail : MessageType.DB_success,
                        result == null
                            ? $"{tableName} table NOT found"
                            : $"{tableName} table confirmed");
                }
            }
        }

        #endregion
    }
}