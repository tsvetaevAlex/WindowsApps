using System.Collections.Generic;

namespace Budgethelper.Models
{
    public static class Session
    {
        public static string Uid { get; set; }
        public static User CurrentUser { get; set; }
        public static AccountModel currentAccount { get; set; }

        public static string DbPath { get; set; } = "budgethelper.db";
        public static string RegistryKeyPath { get; set; } = @"Software\BudgetHelper";

        public static int TransactionQTY { get; set; } = 0;
        public static decimal TotalIncomeAmount { get; set; } = 0;
        public static decimal TotalExpenseAmount { get; set; } = 0;
        public static bool IsAuthorized { get; set; } = false;

        public static string UserName => CurrentUser?.Name;

        //Session Stats
        public static int TransactQTY = 0;
        public static int Income_TransactQTY = 0;
        public static int Expense_TransactQTY = 0;
        public static User currentUser { get; set; }
        public static decimal Income_Totalbalance { get; set; } = 0;
        public static decimal Expense_Totalbalance { get; set; } = 0;
        public static decimal overallbalance { get; set; } //= Income_TOtalbalance - Expense_Totalbalance



        public static string User_ToString()
        {
            return $"{CurrentUser.SureName} {CurrentUser.Name} {CurrentUser.LastName}: uid: {CurrentUser.Uid}";
        }

        public static void dropAccounts()
        {
            AccountsList.Clear();
        }

        public static string UserGreeting()
        {
            if (string.IsNullOrEmpty(CurrentUser.LastName))
                return $" {CurrentUser.Name} {CurrentUser.LastName}";
            else
                return $" {CurrentUser.Name}";
        }

        // Кэш
        public static List<WalletModel> WalletsList { get; set; } = new List<WalletModel>();
        public static List<AccountModel> AccountsList { get; set; } = new List<AccountModel>();
    }
}


