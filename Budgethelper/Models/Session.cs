namespace Budgethelper.Models
{
    public static class Session
    {
        // Пользователь
        public static string Uid { get; set; } // текущий UID пользователя

        // Пути
        public static string DbPath { get; set; } = "budgethelper.db";
        public static string RegistryKeyPath { get; set; } = @"Software\BudgetHelper";

        // Счетчики сессии
        public static int TransactionQTY { get; set; } = 0;
        public static decimal TotalIncomeAmount { get; set; } = 0;
        public static decimal TotalExpenseAmount { get; set; } = 0;
    }
}
