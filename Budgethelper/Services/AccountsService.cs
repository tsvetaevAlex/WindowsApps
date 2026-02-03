using System.Collections.Generic;
using Budgethelper.Models;

namespace Budgethelper.Services
{
    public static class AccountsService
    {
        public static List<Account> LoadAccounts()
        {
            if (!Session.IsAuthorized)
                return new List<Account>();

            return SqlService.GetAccounts(Session.Uid);
        }

        public static void Create(Account account)
        {
            SqlService.CreateAccount(account);
        }

        // TODO:
        // Пока Update/Delete можно не реализовывать
        // Добавим позже при необходимости
    }
}
