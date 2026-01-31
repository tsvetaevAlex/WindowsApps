using Budgethelper.Models;
using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace Budgethelper.Services
{
    public static class RegistryService
    {
        public static void SaveUid(string uid)
        {
            var key = Registry.CurrentUser.CreateSubKey(Session.RegistryKeyPath);
            key.SetValue("Uid", uid);
        }
        public static void SaveUser(Account user)
        {
            // Сохраняем Uid, имя, пароль в реестр или в БД
            Session.CurrentUser = user;
            // Для теста можно выводить сообщение
            // TODO: перевести Console.WriteLine  В Logger
            Console.WriteLine($"User saved: {user}");
        }
        public static string LoadUid()
        {
            var key = Registry.CurrentUser.OpenSubKey(Session.RegistryKeyPath);
            return key?.GetValue("Uid") as string;
        }
    }
}
