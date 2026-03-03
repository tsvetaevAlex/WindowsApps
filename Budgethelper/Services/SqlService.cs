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
                    @"CREATE TABLE IF NOT EXISTS TUser (
                        Uid TEXT PRIMARY KEY,
                        Name TEXT NOT NULL,
                        SureName TEXT NOT NULL,
                        LastName TEXT,
                        PasswordHash TEXT NOT NULL
                    );";

                string sqlWallet =
                    @"CREATE TABLE IF NOT EXISTS Wallet (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Owner TEXT NOT NULL,
                        Name TEXT NOT NULL,
                        FOREIGN KEY(Owner) REFERENCES TUser(Uid)
                    );";

                string sqlAccounts =
                    @"CREATE TABLE IF NOT EXISTS Accounts (
                        AccountID INTEGER PRIMARY KEY AUTOINCREMENT,
                        WalletId INTEGER NOT NULL,
                        AccountName TEXT NOT NULL,
                        Description TEXT,
                        Balance REAL NOT NULL DEFAULT 0,
                        CreatedAt TEXT NOT NULL,
                        IsArchived INTEGER NOT NULL DEFAULT 0,
                        UNIQUE (WalletId, AccountName),
                        FOREIGN KEY(WalletId) REFERENCES Wallet(Id)
                    );";

                string sqlTransactions =
                    @"CREATE TABLE IF NOT EXISTS Transactions (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        AccountId INTEGER NOT NULL,
                        Date TEXT NOT NULL,
                        Amount REAL NOT NULL,
                        OperationType INTEGER NOT NULL,
                        Description TEXT,
                        FOREIGN KEY(AccountId) REFERENCES Accounts(AccountID)
                    );";

                ExecuteNonQuery(conn, sqlTUser);
                ExecuteNonQuery(conn, sqlWallet);
                ExecuteNonQuery(conn, sqlAccounts);
                ExecuteNonQuery(conn, sqlTransactions);
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
                      (@Uid, @Name, @SureName, @LastName, @PasswordHash);";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Uid", user.Uid);
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@SureName", user.SureName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        int walletId = CreateWallet(user.Uid, "Default");
                        Session.CurrentWalletId = walletId;

                        Logger.SendMessage(MessageType.DB_success,
                            $"User inserted + Default wallet created (Id={walletId})");
                    }
                    else
                    {
                        Logger.SendMessage(MessageType.DB_fail, "User not inserted");
                    }
                }
            }
        }

        #endregion

        #region Wallet

        public static int CreateWallet(string ownerUid, string name)
        {
            using (SQLiteConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Open();

                string sql =
                    @"INSERT INTO Wallet (Owner, Name)
                      VALUES (@Owner, @Name);
                      SELECT last_insert_rowid();";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Owner", ownerUid);
                    cmd.Parameters.AddWithValue("@Name", name);

                    return Convert.ToInt32(cmd.ExecuteScalar());
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
                    @"INSERT INTO Accounts
                      (WalletId, AccountName, Description, Balance, CreatedAt)
                      VALUES
                      (@walletId, @name, @description, @balance, @createdAt);
                      SELECT last_insert_rowid();";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@walletId", Session.CurrentWalletId);
                    cmd.Parameters.AddWithValue("@name", account.AccountName);
                    cmd.Parameters.AddWithValue("@description", account.Description ?? "");
                    cmd.Parameters.AddWithValue("@balance", account.Balance);
                    cmd.Parameters.AddWithValue("@createdAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                    long newId = (long)cmd.ExecuteScalar();
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

                string sql =
                    @"SELECT * FROM Accounts
                      WHERE WalletId = @walletId
                      AND IsArchived = 0;";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@walletId", Session.CurrentWalletId);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Account(
                                Convert.ToInt32(reader["AccountID"]),
                                reader["AccountName"].ToString(),
                                Convert.ToDecimal(reader["Balance"]),
                                reader["Description"]?.ToString()
                            ));
                        }
                    }
                }
            }

            return list;
        }

        public static void LoadAccountsToSession()
        {
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

                using (var dbTransaction = conn.BeginTransaction())
                {
                    try
                    {
                        // INSERT Transaction
                        string insertSql =
                            @"INSERT INTO Transactions
                              (AccountId, Date, Amount, OperationType, Description)
                              VALUES
                              (@AccountId, @Date, @Amount, @OperationType, @Description);
                              SELECT last_insert_rowid();";

                        int transactionId;

                        using (SQLiteCommand cmd = new SQLiteCommand(insertSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@AccountId", accountId);
                            cmd.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd HH:mm:ss"));
                            cmd.Parameters.AddWithValue("@Amount", amount);
                            cmd.Parameters.AddWithValue("@OperationType", operationType);
                            cmd.Parameters.AddWithValue("@Description", description ?? "");

                            transactionId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // UPDATE Balance
                        decimal signedAmount =
                            operationType == (int)TransactionType.Income
                            ? amount
                            : -amount;

                        string updateSql =
                            @"UPDATE Accounts
                              SET Balance = Balance + @Amount
                              WHERE AccountID = @AccountId;";

                        using (SQLiteCommand updateCmd = new SQLiteCommand(updateSql, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@Amount", signedAmount);
                            updateCmd.Parameters.AddWithValue("@AccountId", accountId);
                            updateCmd.ExecuteNonQuery();
                        }

                        dbTransaction.Commit();

                        return transactionId;
                    }
                    catch
                    {
                        dbTransaction.Rollback();
                        throw;
                    }
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
                      ORDER BY Date DESC;";

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
                                Description = reader["Description"]?.ToString()
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
            var testUser = new User("1458569m", "Александр", "Цветаев", "Александрович", "123654");

            Session.CurrentUser = testUser;
            CreateUser(testUser);

            Account[] accounts =
            {
                new Account(0, "Cash", 5000, "Наличные"),
                new Account(0, "Card 1", 20000, "Основная карта"),
                new Account(0, "Savings", 30000, "Накопления")
            };

            foreach (Account acc in accounts)
            {
                CreateAccount(acc);
            }
        }

        #endregion

        #region Utils

        private static string Normalize_SQL_Request(string sql)
        {
            return Regex.Replace(sql, @"\s+", " ").Trim();
        }

        #endregion
    }
}