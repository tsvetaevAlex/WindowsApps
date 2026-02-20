using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Windows.Forms;

namespace Budgethelper.Controls
{
    public partial class AccountsGroup : UserControl
    {
        #region public Events
        public event Action<Account> AccountSelected;        // Возвращает выбранный Account
        public event Action RequestRandomDataFill;           // Событие для генерации тестовых данных
        #endregion

        public AccountsGroup()
        {
            InitializeComponent();
            AcSelTab_tbHeader.Text = Session.User_ToString();

            // Подписываемся на выбор аккаунта
            AcSelTab_cbACcountsListSelector.SelectedIndexChanged
                += AcSelTab_cbACcountsListSelector_SelectedIndexChanged;

            LoadAccounts();
        }

        private void LoadAccounts()
        {
            AcSelTab_cbACcountsListSelector.DataSource = null;

            if (!Session.IsAuthorized || Session.AccountsList == null || Session.AccountsList.Count == 0)
                return;

            AcSelTab_cbACcountsListSelector.DataSource = Session.AccountsList;
            AcSelTab_cbACcountsListSelector.DisplayMember = "AccountName";
            AcSelTab_cbACcountsListSelector.ValueMember = "AccountID";

            AcSelTab_cbACcountsListSelector.SelectedIndex = 0;
        }

        private void AcSelTab_cbACcountsListSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AcSelTab_cbACcountsListSelector.SelectedItem is Account account)
            {
                // 1️⃣ Обновляем баланс и комментарий
                AcSelTab_tbAccbalanse.Text = account.Balance.ToString("0.00");
                AcSelTab_tbAccComent.Text = account.Description;

                // 2️⃣ Поднимаем событие наружу
                AccountSelected?.Invoke(account);

                // 3️⃣ Сразу просим TransactionsGroup заполнить тестовые данные
                RequestRandomDataFill?.Invoke();
            }
        }

        private void bAddAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAccName.Text) ||
                string.IsNullOrWhiteSpace(tbAccDescription.Text) ||
                string.IsNullOrWhiteSpace(tbAccBalance.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            if (!decimal.TryParse(tbAccBalance.Text, out decimal balance))
            {
                MessageBox.Show("Некорректный баланс");
                return;
            }

            SqlService.CreateAccount(
                tbAccName.Text.Trim(),
                balance,
                tbAccDescription.Text.Trim()
            );

            tbAccName.Clear();
            tbAccDescription.Clear();
            tbAccBalance.Clear();

            LoadAccounts();

            if (Session.AccountsList != null && Session.AccountsList.Count > 0)
                AcSelTab_cbACcountsListSelector.SelectedIndex = Session.AccountsList.Count - 1;
        }

        private void btnRandomData_Click(object sender, EventArgs e)
        {
            RequestRandomDataFill?.Invoke();  // генерируем тестовые данные по кнопке
        }
    }
}