
using Microsoft.Win32;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Budgethelper.Services
{

    
    [Obsolete("use RegistryService classs instead of this", true)]
    public class RegistryHelper
    {
        private const string registryPath = @"Software\_BudgetHelper";// Путь к разделу реестра, где хотим создать переменную
        private static object RegistryValue = new object();

        public RegistryHelper()
        {
        }

        public void SetKey(string name, string value)
        {
            // Путь к разделу реестра, где хотим создать переменную
            // Открываем (или создаем) раздел
            //use branch CurrentUser to avoid admin permissions request
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryPath))
            {
                if (key != null)
                {
                    // Создаем или обновляем значение
                    try
                    {
                        key.SetValue(name, value, RegistryValueKind.String);
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"New UId has been successfully registered");
                    }
                    catch (Exception e)
                    {
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"at registry set value exception has ben happend:\r\n{e.Message}");
                        Console.ResetColor();
                    }
                }
            }
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

        public async Task<string> GetRegistryValueAsync(string name)
        {
            return await Task.Run(() =>
            {
                var key = Registry.CurrentUser.OpenSubKey(registryPath);
                return key?.GetValue(name)?.ToString();
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
    }// end of class RegistryHelper
}// end of namespace Budgethelper.Services
