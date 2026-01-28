using Budgethelper.Models;
using System.Collections.Generic;

namespace Budgethelper.Services
{
    public static class AccountsService
    {
        public static List<Account> GetAll()
        {
            return SqlService.LoadAccounts();
        }
    }
}
