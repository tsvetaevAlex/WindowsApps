using Microsoft.Win32;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Budgethelper.Services
{
    public class RegistryService
    {
        // Фиксированный путь к разделу реестра
        private const string RegistryPath = @"Software\BudgetHelper";

        /// <summary>
        /// Проверяет, существует ли значение с указанным именем
        /// </summary>
        public Task<bool> ExistsAsync(string name)
        {
            return Task.Factory.StartNew(() =>
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath))
                {
                    return key != null && key.GetValue(name) != null;
                }
            });
        }

        /// <summary>
        /// Получает значение по имени
        /// </summary>
        public Task<string> GetAsync(string name)
        {
            return Task.Factory.StartNew(() =>
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath))
                {
                    if (key != null)
                    {
                        object val = key.GetValue(name);
                        if (val != null) return val.ToString();
                    }
                    return null;
                }
            });
        }

        /// <summary>
        /// Сохраняет данные пользователя (имя, фамилия, хеш пароля)
        /// </summary>
        public Task SaveUserAsync(string firstName, string lastName, string password)
        {
            return Task.Factory.StartNew(() =>
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryPath))
                {
                    key.SetValue("FirstName", firstName);
                    key.SetValue("LastName", lastName);
                    key.SetValue("PasswordHash", HashPassword(password));
                }
            });
        }

        /// <summary>
        /// Хеширует пароль с помощью SHA256
        /// </summary>
        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] hashBytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return System.Convert.ToBase64String(hashBytes);
            }
        }
    }
}
