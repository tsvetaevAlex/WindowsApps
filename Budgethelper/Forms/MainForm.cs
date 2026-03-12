using System;
using System.Windows.Forms;
using Budgethelper.Models;
using Budgethelper.Services;
using Budgethelper.Controls;

namespace Budgethelper.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Загружаем Wallets и Accounts из Session
            LoadInitialData();
        }

        private void LoadInitialData()
        {
            // Wallets уже в Session после SeedTestData
            if (Session.WalletsList.Count > 0)
            {
                WalletControl firstWallet = Session.WalletsList[0];
                txtCurrentWallet.Text = firstWallet.Name;

                // Загружаем аккаунты выбранного кошелька
                SqlService.LoadAccountsToSession(firstWallet.Id);

            }
        }

        // Пример кнопки переключения Wallet
        private void btnChangeWallet_Click(object sender, EventArgs e)
        {
            if (Session.WalletsList.Count <= 1) return;

            WalletControl nextWallet = Session.WalletsList[1]; // для примера берем второй кошелек
            txtCurrentWallet.Text = nextWallet.Name;

            SqlService.LoadAccountsToSession(nextWallet.Id);
        }
    }
}
