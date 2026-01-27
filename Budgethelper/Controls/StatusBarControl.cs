using System.Windows.Forms;

namespace Budgethelper.Controls
{
    public partial class StatusBarControl : UserControl
    {
        public StatusBarControl()
        {
            InitializeComponent();
        }

        public void SetBalance(decimal balance)
        {
            lblBalance.Text = $"Balance: {balance:0.00}";
        }
    }
}
