using Microsoft.Win32;
using System;
using System.Security.Cryptography;
using System.Text;

namespace BudgetHelper.Services
{
    public sealed class RegistryService
    {
        private const string RootPath = @"Software\BudgetHelper";

        // =========================
        // Public API
        // =========================

        public bool UserExists()
        {
            using (var key = Registry.CurrentUser.OpenSubKey(RootPath))
            {
                return key != null &&
                       key.GetValue("Uid") != null &&
                       key.GetValue("PasswordHash") != null;
            }
        }

        public void SaveUser(
            string name,
            string surename,
            string lastName,
            string password)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name is empty");

            if (string.IsNullOrWhiteSpace(surename))
                throw new ArgumentException("Surename is empty");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password is empty");

            string uid = Guid.NewGuid().ToString();
            string hash = ComputeHash(password);

            using (var key = Registry.CurrentUser.CreateSubKey(RootPath))
            {
                key.SetValue("Uid", uid);
                key.SetValue("Name", name);
                key.SetValue("Surename", surename);
                key.SetValue("LastName", lastName ?? string.Empty);
                key.SetValue("PasswordHash", hash);
            }
        }

        public string GetUid() => Read("Uid");
        public string GetName() => Read("Name");
        public string GetSurename() => Read("Surename");
        public string GetLastName() => Read("LastName");

        public bool ValidatePassword(string password)
        {
            string storedHash = Read("PasswordHash");
            if (storedHash == null)
                return false;

            return storedHash == ComputeHash(password);
        }

        // =========================
        // Helpers
        // =========================

        private string Read(string keyName)
        {
            using (var key = Registry.CurrentUser.OpenSubKey(RootPath))
            {
                return key?.GetValue(keyName)?.ToString();
            }
        }

        private static string ComputeHash(string input)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha.ComputeHash(bytes);

                var sb = new StringBuilder();
                foreach (byte b in hash)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }
    }
}
