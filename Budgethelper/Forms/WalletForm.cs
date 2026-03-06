using Budgethelper.Models;
using Budgethelper.Services;
using System;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Budgethelper.Forms
{
    public partial class WalletForm : Form
    {
        public WalletForm()
        {
            InitializeComponent();
            Wallet_cb_NewAccType.DataSource = Enum.GetValues(typeof(Money_Source));

        }

        //Events
        #region Events

        private void tbNewWalletName_MouseEnter(object sender, EventArgs e)
        {
            Wallet_tb_NewWalletName.Text = string.Empty;
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

        private void Wallet_button_AddNewAcc_Click(object sender, EventArgs e)
        {
            //Verify ballanse
            if (decimal.TryParse(Wallet_label_NewAccBallanse.Text, out decimal result))
            {
                // Успех: используем переменную result
                MessageBox.Show($"Вы ввели число: {result}");
            }
            else
            {
                // Ошибка: текст в поле не является числом
                MessageBox.Show("Пожалуйста, введите корректное число.");
            }

        Account WalletNewAccount = new Account
        {
            AccountName = Wallet_b_SaveNewWalletName.Text.Trim(),
            Balance = result,
            Description = Wallet_label_NewAccDescription.Text.Trim()
        };


            Wallet_b_SaveNewWalletName.Text = string.Empty;
           Wallet_label_NewAccBallanse.Text = string.Empty;
           Wallet_cb_NewAccType.Text = string.Empty;
           Wallet_tb_NewAccBallanse.Text = string.Empty;
           Wallet_tb_NewAccName.Text = string.Empty;
           Wallet_cb_NewAccType.SelectedText = string.Empty;

        }
    }
}
