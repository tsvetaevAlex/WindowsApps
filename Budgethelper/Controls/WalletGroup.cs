using System;
using System.Windows.Forms;

namespace Budgethelper.Controls
{
    public partial class WalletGroup : UserControl
    {
        public int walletGroup_WIdth { get; set; }
        public int walletGroup_Height { get; set; }
        public WalletGroup()
        {
            InitializeComponent();
            walletGroup_WIdth = this.Width;
            walletGroup_Height = this.Height;
        }

        private void WF_textBox_NewWalletName_MouseEnter(object sender, EventArgs e)
        {
            if (this.WF_textBox_NewWalletName.CanFocus)
            {
                WF_textBox_NewWalletName.Focus();
                WF_textBox_NewWalletName.Text = string.Empty;
            }
        }
    }
}
