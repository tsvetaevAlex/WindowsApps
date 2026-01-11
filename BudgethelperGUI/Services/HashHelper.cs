using System;
using System.Security.Cryptography;
using System.Text;

namespace Budgethelper.Services
{
    public static class HashHelper
    {
        public static string GetMd5(string input)
        {
            // Проверим, чтобы не было null
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            // Преобразуем строку в байты (UTF8)
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            // Создаём объект MD5 и вычисляем хеш
            MD5 md5 = MD5.Create();
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Переводим байты в строку в виде шестнадцатеричного представления
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashBytes)
                sb.Append(b.ToString("x2")); // x2 — нижний регистр, X2 — верхний

            return sb.ToString();
        }
    }

}