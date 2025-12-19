
using Microsoft.Win32;
using System;
using System.Threading.Tasks;

namespace BudgethelperGUI.Services
{
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



        public async Task<string> GetRegistryValueAsync(string name)
        {
            return await Task.Run(() =>
            {
                var key = Registry.CurrentUser.OpenSubKey(registryPath);
                return key?.GetValue(name)?.ToString();
            });
        }
    }// end of class RegistryHelper
}// end of namespace BudgethelperGUI.Services
