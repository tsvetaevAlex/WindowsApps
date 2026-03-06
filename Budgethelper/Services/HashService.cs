using Budgethelper.Models;
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

        public static string ComputePasswordHash(string password)
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
            bool result = ComputePasswordHash(password) == storedHash;
            Session.IsAuthorized = result;
            return result;
        }
    }
}
