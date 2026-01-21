using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace BudgetHelper.Services
{
    public class SqlService
    {
        private readonly string _dbPath;
        private readonly string _connectionString;

        public SqlService(string uid)
        {
            _dbPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "BudgetHelper",
                "SqlService",
                uid + ".sqlite"
            );

            Directory.CreateDirectory(Path.GetDirectoryName(_dbPath));
            _connectionString = $"Data Source={_dbPath};Version=3;";

            EnsureDatabase();
        }

        private SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(_connectionString);
            conn.Open();
            return conn;
        }

        private void EnsureDatabase()
        {
            if (!File.Exists(_dbPath))
                SQLiteConnection.CreateFile(_dbPath);

            using (var conn = GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS Accounts (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Currency TEXT NOT NULL
);

CREATE TABLE IF NOT EXISTS Transactions (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    AccountId INTEGER,
    Amount REAL NOT NULL,
    CreatedAt TEXT NOT NULL
);";
                cmd.ExecuteNonQuery();
            }
        }

        public decimal GetBalance(string currency)
        {
            using (var conn = GetConnection())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
SELECT IFNULL(SUM(t.Amount),0)
FROM Transactions t
JOIN Accounts a ON a.Id = t.AccountId
WHERE a.Currency = @c";

                cmd.Parameters.AddWithValue("@c", currency);
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }
    }
}
