using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Budgethelper.Models;

namespace Budgethelper.Services
{
    public static class SqlService
    {
        private static string ConnectionString
        {
            get { return "Data Source=" + Session.DbPath + ";Version=3;"; }
        }

        #region Users

        public static void CreateUser(User user)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = @"INSERT INTO Users
                                (Uid, Name, SureName, LastName, PasswordHash)
                                VALUES (@Uid, @Name, @SureName, @LastName, @PasswordHash)";

                using (var cmd = new SQLiteCommand(query, connection))
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
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Users WHERE Uid=@Uid LIMIT 1";

                using (var cmd = new SQLiteCommand(query, connection))
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

        #endregion


        #region Accounts

        public static void CreateAccount(Account account)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = @"INSERT INTO Accounts
                                (Uid, Name, Currency, Description, Balance)
                                VALUES (@Uid, @Name, @Currency, @Description, @Balance)";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Uid", account.Uid);
                    cmd.Parameters.AddWithValue("@Name", account.Name);
                    cmd.Parameters.AddWithValue("@Currency", account.Currency);
                    cmd.Parameters.AddWithValue("@Description", account.Description);
                    cmd.Parameters.AddWithValue("@Balance", account.Balance);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Account> GetAccounts(string uid)
        {
            var list = new List<Account>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Accounts WHERE Uid=@Uid";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Uid", uid);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Account
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Uid = reader["Uid"].ToString(),
                                Name = reader["Name"].ToString(),
                                Currency = reader["Currency"].ToString(),
                                Description = reader["Description"].ToString(),
                                Balance = Convert.ToDecimal(reader["Balance"])
                            });
                        }
                    }
                }
            }

            return list;
        }

        #endregion


        #region Transactions

        public static void CreateTransaction(Transaction transaction)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = @"INSERT INTO Transactions
                                (AccountName, Date, Amount, OperationType, Description)
                                VALUES (@AccountName, @Date, @Amount, @OperationType, @Description)";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@AccountName", transaction.AccountName);
                    cmd.Parameters.AddWithValue("@Date", transaction.Date);
                    cmd.Parameters.AddWithValue("@Amount", transaction.Amount);
                    cmd.Parameters.AddWithValue("@OperationType", transaction.OperationType.ToString());
                    cmd.Parameters.AddWithValue("@Description", transaction.Description);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Transaction> GetTransactions(string accountName)
        {
            var list = new List<Transaction>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Transactions WHERE AccountName=@AccountName";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@AccountName", accountName);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Transaction
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                AccountName = reader["AccountName"].ToString(),
                                Date = Convert.ToDateTime(reader["Date"]),
                                Amount = Convert.ToDecimal(reader["Amount"]),
                                OperationType = (TransactionType)Enum.Parse(
                                    typeof(TransactionType),
                                    reader["OperationType"].ToString()),
                                Description = reader["Description"].ToString()
                            });
                        }
                    }
                }
            }

            return list;
        }

        #endregion
    }
}
