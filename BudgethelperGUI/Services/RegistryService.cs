using Microsoft.Win32;
using System;

namespace Budgethelper.Services
{
    public static class RegistryService
    {
        private const string Root = @"Software\BudgetHelper";

        public static bool UserExists()
        {
            using (var key = Registry.CurrentUser.OpenSubKey(Root))
            {
                return key != null && key.GetValue("UID") != null;
            }
        }

        public static void SaveUser(
            string uid,
            string firstName,
            string sureName,
            string lastName,
            string passwordHash)
        {
            using (var key = Registry.CurrentUser.CreateSubKey(Root))
            {
                key.SetValue("UID", uid);
                key.SetValue("FirstName", firstName);
                key.SetValue("SureName", sureName);
                key.SetValue("LastName", lastName ?? "");
                key.SetValue("Password", passwordHash);
            }
        }

        public static string GetUid()
        {
            using (var key = Registry.CurrentUser.OpenSubKey(Root))
            {
                return key?.GetValue("UID")?.ToString();
            }
        }

        public static bool ValidatePassword(string password)
        {
            using (var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Root))
            {
                if (key == null)
                    return false;

                var storedHash = key.GetValue("Password") as string;
                if (string.IsNullOrEmpty(storedHash))
                    return false;

                string inputHash = HashService.GetMd5(password);
                return string.Equals(storedHash, inputHash, StringComparison.Ordinal);
            }
        }


        public static string GetPasswordHash()
        {
            using (var key = Registry.CurrentUser.OpenSubKey(Root))
            {
                return key?.GetValue("Password")?.ToString();
            }
        }
    }
}
