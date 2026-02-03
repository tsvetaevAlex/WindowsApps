using Microsoft.Win32;
using Budgethelper.Models;

namespace Budgethelper.Services
{
    public static class RegistryService
    {
        public static void SaveUid(string uid)
        {
            using (var key = Registry.CurrentUser.CreateSubKey(Session.RegistryKeyPath))
            {
                key.SetValue("Uid", uid);
            }
        }

        public static string LoadUid()
        {
            using (var key = Registry.CurrentUser.OpenSubKey(Session.RegistryKeyPath))
            {
                return key?.GetValue("Uid")?.ToString();
            }
        }

        public static void Clear()
        {
            Registry.CurrentUser.DeleteSubKeyTree(Session.RegistryKeyPath, false);
        }
    }
}
