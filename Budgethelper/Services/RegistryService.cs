using Microsoft.Win32;
using Budgethelper.Models;

namespace Budgethelper.Services
{
    public static class RegistryService
    {
        public static void SaveUid(UserModel user)
        {
            
            using (var key = Registry.CurrentUser.CreateSubKey(Session.RegistryKeyPath))
            {
                key.SetValue("Uid", user.Uid);
                key.SetValue("Name", user.Name);
                key.SetValue("SusreName", user.SureName);
                key.SetValue("LastName", user.LastName);
                Logger.SendMessage(Message_Type.Debug, "Data saved ro Registry:");
                Logger.SendMessage(Message_Type.Debug, $"Uid:${user.Uid};");
                Logger.SendMessage(Message_Type.Debug, $"Name: {user.Name};");
                Logger.SendMessage(Message_Type.Debug, $"SusreName: {user.SureName};");
                Logger.SendMessage(Message_Type.Debug, $"LastName: {user.LastName};");
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
