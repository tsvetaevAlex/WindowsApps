using Budgethelper.Models;
using Budgethelper.Services;
using System;

using System.Windows.Forms;

namespace Budgethelper.Forms
{
    public partial class WalletForm : Form
    {
        public WalletForm()
        {
            InitializeComponent();
        }

        //Events
        #region Events

        private void tbNewWalletName_MouseEnter(object sender, EventArgs e)
        {
            tbNewWalletName.Text = string.Empty;
            Logger.SendMessage(MessageType.Info, "Пожалуйста,Ведите имя Вашего первого кошелька.");
        }


        private void tbCard_MouseEnter(object sender, EventArgs e)
        {
            Logger.SendMessage(MessageType.Info, "Пожалуйста,Ведите Имя для Вашей каротчкиr\r'\n" +
                "обычно это префикс(тип платежной системы или имя банка) и 4 последние цифры номера карточки.\r'\n" +
                "пример: visa0054 сбер6633");
        }

        #endregion

        private void gb_MS_balanse_Line1_MouseEnter(object sender, EventArgs e)
        {
            Logger.SendMessage(MessageType.Info, "Пожалуйста,Ведите начальный баланс.");
        }

        private void gb_MS_balanse_Line2_MouseEnter(object sender, EventArgs e)
        {
            Logger.SendMessage(MessageType.Info, "Пожалуйста,Ведите начальный баланс.");
        }
    }
}
