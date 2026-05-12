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
                key.SetValue("Name", Session.currentUser.Name);
                key.SetValue("SusreName", Session.currentUser.SureName);
                key.SetValue("LastName", Session.currentUser.LastName);
                Logger.SendMessage(Message_Type.Debug, "Datasaved ro Registry:");
                Logger.SendMessage(Message_Type.Debug, $"Uid:${uid};");
                Logger.SendMessage(Message_Type.Debug, $"Name: {Session.currentUser.Name};");
                Logger.SendMessage(Message_Type.Debug, $"SusreName: {Session.currentUser.SureName};");
                Logger.SendMessage(Message_Type.Debug, $"LastName: {Session.currentUser.LastName};");
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
