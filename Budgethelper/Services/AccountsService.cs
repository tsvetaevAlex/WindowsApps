using Budgethelper.Models;
using Budgethelper.Services;
using System.Collections.Generic;

namespace Budgethelper.Services
{
    public static class AccountsService
    {
        public static List<Account> GetAccounts()
        {
            return SqlService.GetAccounts(Session.CurrentUser.Uid);
        }

        public static void CreateAccount(string accountName, decimal initialBalance = 0)
        {
            SqlService.CreateAccount(Session.CurrentUser.Uid, accountName, initialBalance);
        }
    }
}
