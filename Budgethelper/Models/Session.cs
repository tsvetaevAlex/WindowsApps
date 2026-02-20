using Budgethelper.Models;
using System.Collections.Generic;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Budgethelper.Models
{
    public static class Session
    {
        public static string Uid { get; set; }
        public static User CurrentUser { get; set; }
        public static Account  CurrentAccount { get; set; }

        public static string DbPath { get; set; } = "budgethelper.db";
        public static string RegistryKeyPath { get; set; } = @"Software\BudgetHelper";

        public static bool IsAuthorized { get; set; }

        public static string UserName
        {
            get { return CurrentUser != null ? CurrentUser.Name : ""; }
        }
        // Кэш аккаунтов
        public static List<Account> AccountsList { get; set; } = new List<Account>();


        //Session Stats
        public static int TransactQTY = 0;
        public static int overallbalance = 0; //= Income_TOtalbalance - Expense_Totalbalance
        public static int Income_TransactQTY = 0;
        public static int Income_Totalbalance = 0;
        public static int Expense_Totalbalance = 0;

        public static void dropAccounts()
        {
            AccountsList.Clear();
        }
        public static  string User_ToString()
        { 
            return $"{CurrentUser.SureName} {CurrentUser.Name} {CurrentUser.LastName}: uid: {CurrentUser.Uid}";
        }

    }
}
