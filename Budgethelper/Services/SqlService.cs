using System;
using System.Collections.Generic;
using System.Data.SQLite;
using BudgetHelper.Models;

namespace BudgetHelper.Services
{
    public class SqlService
    {
        private readonly string _connectionString;

        public SqlService(string dbPath)
        {
            _connectionString = $"Data Source={dbPath};Version=3;";
        }

        public List<Account> LoadAccounts()
        {
            var list = new List<Account>();
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT Id, Name, Balance, Currency FROM Accounts", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Account
                        {
                            Id = (long)reader["Id"],
                            Name = reader["Name"].ToString(),
                            Balance = Convert.ToDecimal(reader["Balance"]),
                            Currency = reader["Currency"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public decimal RecalculateBalance(long accountId)
        {
            decimal balance = 0m;
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(
                    "SELECT Operation, Amount FROM Transactions WHERE AccountId=@accountId", conn);
                cmd.Parameters.AddWithValue("@accountId", accountId);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var op = (TransactionType)Enum.Parse(typeof(TransactionType), reader["Operation"].ToString());
                        decimal amount = Convert.ToDecimal(reader["Amount"]);
                        balance += (op == TransactionType.Income ? amount : -amount);
                    }
                }
            }
            return balance;
        }
    }
}
