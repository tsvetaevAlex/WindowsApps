using System;
using System.IO;

namespace Budgethelper.Models
{
    public static class Session
    {
        public static string Uid { get; set; }
        public static Account CurrentUser { get; set; }

        public static string RegistryKeyPath => @"Software\Budgethelper";

        public static string DbFolder =>
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Budgethelper",
                "SqlService");

        public static string DbPath =>
            string.IsNullOrWhiteSpace(Uid)
                ? null
                : Path.Combine(DbFolder, $"{Uid}.sqlite");
    }
}
