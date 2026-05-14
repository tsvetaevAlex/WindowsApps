using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Windows.Forms;

namespace Budgethelper.Controls
{
    public partial class WalletGroup : UserControl
    {
        public int walletGroup_WIdth { get; set; }
        public int walletGroup_Height { get; set; }

        private static bool isUserText = false;
        public WalletGroup()
        {
            InitializeComponent();
            walletGroup_WIdth = this.Width;
            walletGroup_Height = this.Height;
        }

        private void WF_textBox_NewWalletName_MouseEnter(object sender, EventArgs e)
        {
            if ((this.WF_textBox_NewWalletName.CanFocus) && (!isUserText))
            {
                WF_textBox_NewWalletName.Focus();
                WF_textBox_NewWalletName.Text = string.Empty;
            }
        }

        private void WF_textBox_NewWalletName_TextChanged(object sender, EventArgs e)
        {
            isUserText = true;
        }

        private void WG_Button_NewWalletName_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(WF_textBox_NewWalletName.Text))
            {
                string warnMessage = "для создания нового кошелькаполе имя кошелька должно быть заполнено.";
                Logger.SendMessage(Message_Type.Error, warnMessage);
                MessageBox.Show (
                    warnMessage, 
                    "Warning!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                WalletModel newWallet = new WalletModel
                {
                    Name = WF_textBox_NewWalletName.Text,
                    UserUid = Session.CurrentUser.Uid,
                };
                SqlService.CreateWallet(newWallet);
            }
        }
    }
}
