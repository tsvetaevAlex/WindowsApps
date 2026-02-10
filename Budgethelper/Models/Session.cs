using Budgethelper.Models;

namespace Budgethelper.Models
{
    public static class Session
    {
        public static string Uid { get; set; }
        public static User CurrentUser { get; set; }

        public static string DbPath { get; set; } = $"{Uid}.db";
        public static string RegistryKeyPath { get; set; } = @"Software\BudgetHelper";

        public static bool IsAuthorized { get; set; }

        public static string UserName
        {
            get { return CurrentUser != null ? CurrentUser.Name : ""; }
        }
    }
}
