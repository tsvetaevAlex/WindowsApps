using System.Security.Cryptography;
using System.Text;

namespace Budgethelper.Services
{
    public static class HashService
    {
        public static string GetMd5(string input)
        {
            using (var md5 = MD5.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = md5.ComputeHash(bytes);

                var sb = new StringBuilder();
                foreach (byte b in hash)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }
    }
}
