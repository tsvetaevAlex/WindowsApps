using Budgethelper.Models;
using System;
using System.Data.SQLite;
using System.IO;

namespace BudgetHelper.Services
{
    public sealed class SqlService : IDisposable
    {
        private const string AppName = "BudgetHelper";
        private const string DbFolderName = "SqlService";

        public SQLiteConnection Connection { get; private set; }

        public SqlService(string userId)
        {
            string dbPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                AppName,
                DbFolderName,
                userId + ".sqlite");

            Directory.CreateDirectory(Path.GetDirectoryName(dbPath));

            if (!File.Exists(dbPath))
                SQLiteConnection.CreateFile(dbPath);

            Connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            Connection.Open();

            VerifySchema();
        }

        private void VerifySchema()
        {
            using (var cmd = Connection.CreateCommand())
            {
                cmd.CommandText =
@"
CREATE TABLE IF NOT EXISTS Accounts (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Balance INTEGER NOT NULL,
    Currency TEXT NOT NULL
);

CREATE TABLE IF NOT EXISTS Transactions (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    AccountName TEXT NOT NULL,
    Amount INTEGER NOT NULL,
    Type INTEGER NOT NULL,
    Description TEXT,
    Date TEXT NOT NULL
);
";
                cmd.ExecuteNonQuery();
            }
        }

        public bool HasAccounts(string currency)
        {
            using (var cmd = Connection.CreateCommand())
            {
                cmd.CommandText =
                    "SELECT COUNT(*) FROM Accounts WHERE Currency=@c";
                cmd.Parameters.AddWithValue("@c", currency);
                return (long)cmd.ExecuteScalar() > 0;
            }
        }

        public long CreateAccount(string name, int balance, string currency)
        {
            using (var cmd = Connection.CreateCommand())
            {
                cmd.CommandText =
@"
INSERT INTO Accounts (Name, Balance, Currency)
VALUES (@n,@b,@c);
SELECT last_insert_rowid();
";
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@b", balance);
                cmd.Parameters.AddWithValue("@c", currency);

                return (long)cmd.ExecuteScalar();
            }
        }

        public SQLiteDataReader LoadAccounts(string currency)
        {
            var cmd = Connection.CreateCommand();
            cmd.CommandText =
                "SELECT Name, Balance FROM Accounts WHERE Currency=@c";
            cmd.Parameters.AddWithValue("@c", currency);
            return cmd.ExecuteReader();
        }

        public void AddTransaction(
            string accountName,
            int amount,
            TransactionType type,
            string description)
        {
            int delta = type == TransactionType.Expense
                ? -amount
                : amount;

            using (var tx = Connection.BeginTransaction())
            {
                using (var cmd = Connection.CreateCommand())
                {
                    cmd.CommandText =
@"
INSERT INTO Transactions
(AccountName, Amount, Type, Description, Date)
VALUES
(@a,@am,@t,@d,@dt);
";
                    cmd.Parameters.AddWithValue("@a", accountName);
                    cmd.Parameters.AddWithValue("@am", delta);
                    cmd.Parameters.AddWithValue("@t", (int)type);
                    cmd.Parameters.AddWithValue("@d", description);
                    cmd.Parameters.AddWithValue("@dt",
                        DateTime.Now.ToString("dd-MM-yyyy"));

                    cmd.ExecuteNonQuery();
                }

                using (var cmd = Connection.CreateCommand())
                {
                    cmd.CommandText =
@"
UPDATE Accounts
SET Balance = Balance + @delta
WHERE Name = @name;
";
                    cmd.Parameters.AddWithValue("@delta", delta);
                    cmd.Parameters.AddWithValue("@name", accountName);
                    cmd.ExecuteNonQuery();
                }

                tx.Commit();
            }
        }

        public void Dispose()
        {
            Connection?.Close();
            Connection?.Dispose();
        }
    }
}

