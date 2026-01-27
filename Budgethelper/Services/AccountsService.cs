using System.Collections.Generic;
using BudgetHelper.Models;

namespace BudgetHelper.Services
{
    public class AccountsService
    {
        private readonly SqlService _sql;

        public AccountsService(SqlService sql)
        {
            _sql = sql;
        }

        public List<Account> GetAccounts()
        {
            return _sql.LoadAccounts();
        }
    }
}
