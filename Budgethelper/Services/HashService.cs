using System.Security.Cryptography;
using System.Text;
using Budgethelper.Models;

namespace Budgethelper.Services
{
    public static class HashService
    {
        public static string GetMd5(string input)
        {
            var md5 = MD5.Create();
            var bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sb = new StringBuilder();
            foreach (var b in bytes)
                sb.Append(b.ToString("x2"));
            return sb.ToString();
        }

        public static void InitSessionUid(Account account)
        {
            var uid = GetMd5(account.Name + account.SureName + account.PasswordHash);
            Session.Uid = uid;
            account.Uid = uid;
        }
    }
}
