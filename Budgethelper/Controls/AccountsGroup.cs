using System;
using System.Windows.Forms;

namespace Budgethelper.Controls
{
    public partial class AccountsGroup : UserControl
    {
        public event Action<string> AccountSelected;

        public AccountsGroup()
        {
            InitializeComponent();
            grid.SelectionChanged += Grid_SelectionChanged;
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null)
                return;

            var accountName = grid.CurrentRow.Cells["Name"].Value?.ToString();
            if (string.IsNullOrEmpty(accountName))
                return;

            AccountSelected?.Invoke(accountName);
        }
    }
}
