using Budgethelper.Models;
using Microsoft.Win32;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Budgethelper.Services
{
    public static class HashService
    {
        public static string GenerateUid()
        {
            return Guid.NewGuid().ToString();
        }

        public static void SaveUid(string uid)
        {
            using (var key = Registry.CurrentUser.CreateSubKey(Session.RegistryKeyPath))
            {
                key.SetValue("Uid", uid);
            }
        }

        public static string GetHash(string password)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(password);
                var hash = sha.ComputeHash(bytes);

                var sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                    sb.Append(hash[i].ToString("x2"));

                return sb.ToString();
            }
        }

        public static bool Verify(string password, string storedHash)
        {
            bool result = GetHash(password) == storedHash;
            Session.IsAuthorized = result;
            return result;
        }
    }
}
