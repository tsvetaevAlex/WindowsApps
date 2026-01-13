using Microsoft.Win32;
using System;
using Budgethelper.Models;

namespace Budgethelper.Services
{
    public sealed class RegistryService
    {
        private const string RegistryPath = @"Software\_BudgetHelper";

        public bool UserExists()
        {
            using (var key = Registry.CurrentUser.OpenSubKey(RegistryPath))
            {
                return key != null &&
                       key.GetValue("UserId") != null &&
                       key.GetValue("PasswordHash") != null;
            }
        }

        public void SaveUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            using (var key = Registry.CurrentUser.CreateSubKey(RegistryPath))
            {
                key.SetValue("UserId", user.Id);
                key.SetValue("FirstName", user.FirstName);
                key.SetValue("Surename", user.Surename);
                key.SetValue("LastName", user.LastName);
                key.SetValue("PasswordHash", user.PasswordHash);
            }
        }

        public User LoadUser()
        {
            using (var key = Registry.CurrentUser.OpenSubKey(RegistryPath))
            {
                if (key == null)
                    return null;

                return new User(
                    id: key.GetValue("UserId") as string,
                    firstName: key.GetValue("FirstName") as string,
                    surename: key.GetValue("Surename") as string,
                    lastName: key.GetValue("LastName") as string,
                    passwordHash: key.GetValue("PasswordHash") as string
                );
            }
        }

        public string GetPasswordHash()
        {
            using (var key = Registry.CurrentUser.OpenSubKey(RegistryPath))
            {
                return key?.GetValue("PasswordHash") as string;
            }
        }
    }
}
