
using BudgetHelper.Services;
using System.Windows.Forms;

namespace Budgethelper.Services
{
    public class StatusBarService
    {
        private readonly ToolStripStatusLabel _lblRur;
        private readonly ToolStripStatusLabel _lblUsd;
        private readonly SqlService _sql;

        public StatusBarService(
            ToolStripStatusLabel lblRur,
            ToolStripStatusLabel lblUsd,
            SqlService sql)
        {
            _lblRur = lblRur;
            _lblUsd = lblUsd;
            _sql = sql;
        }

        public void Refresh()
        {
            _lblRur.Text = $"RUR: {_sql.GetBalance("RUR"),6}";
            _lblUsd.Text = $"USD: {_sql.GetBalance("USD"),6}";
        }
    }
}
