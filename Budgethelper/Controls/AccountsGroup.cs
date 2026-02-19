using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Windows.Forms;

namespace Budgethelper.Controls
{
    public partial class AccountsGroup : UserControl
    {
        public event Action<int> AccountSelected;
        private static Account SlectedAccount = null;

        public AccountsGroup()
        {
            InitializeComponent();

            AcSelTab_tbHeader.Text = Session.User_ToString();
            //Session.IsAuthorized = true;

            // подписка на выбор аккаунта
            AcSelTab_cbACcountsListSelector.SelectedIndexChanged
                += listAccounts_SelectedIndexChanged;

            AcSelTab_tbHeader.Text = Session.User_ToString();

            AcSelTab_cbACcountsListSelector.SelectedIndexChanged
                += listAccounts_SelectedIndexChanged;


            LoadAccounts();
        }

        private void LoadAccounts()
        {
            AcSelTab_cbACcountsListSelector.DataSource = null;

            if (!Session.IsAuthorized)
                return;

            if (Session.AccountsList == null || Session.AccountsList.Count == 0)
                return;

            AcSelTab_cbACcountsListSelector.DataSource = Session.AccountsList;
            AcSelTab_cbACcountsListSelector.DisplayMember = "AccountName";
            AcSelTab_cbACcountsListSelector.ValueMember = "AccountID";

            AcSelTab_cbACcountsListSelector.SelectedIndex = 0;
        }

        // выбор аккаунта
        private void listAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AcSelTab_cbACcountsListSelector.SelectedItem == null)
                return;

            var selected = AcSelTab_cbACcountsListSelector.SelectedItem as Account;
            if (selected == null)
                return;

            // сохраняем в Session
            Session.CurrentAccount = selected;
                    SlectedAccount = selected;
                    MessageBox.Show($"выбранный акканут: id: {selected.AccountID}| name:{selected.AccountName} " +
                        $"{Environment.NewLine}комментарий: {selected.Description}","Selected Account"
                        ,MessageBoxButtons.OK,MessageBoxIcon.Information );

            // обновляем UI
            AcSelTab_tbAccbalanse.ReadOnly = true;
            AcSelTab_tbAccbalanse.Text = selected.Balance.ToString("0.00");
            AcSelTab_tbAccComent.Text = selected.Description ?? string.Empty;
            AcSelTab_tbAccComent.ReadOnly = true;

            AccountSelected?.Invoke(selected.AccountID);
        }

        private void bAddAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAccName.Text) ||
                string.IsNullOrWhiteSpace(tbAccDescription.Text) ||
                string.IsNullOrWhiteSpace(tbAccBalance.Text))   // ← ВАЖНО
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            decimal balance;
            if (!decimal.TryParse(tbAccBalance.Text, out balance))  // ← ВАЖНО
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
            tbAccBalance.Clear();   // ← правильное поле

            LoadAccounts();

            // если есть аккаунты — выбираем последний
            if (Session.AccountsList != null &&
                Session.AccountsList.Count > 0)
            {
                AcSelTab_cbACcountsListSelector.SelectedIndex =
                    Session.AccountsList.Count - 1;
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTab = AccountsGroupControlTabs.SelectedTab;

            if (selectedTab == null)
                return;

            if (selectedTab.TabIndex == 0)
            {
                Logger.SendMessage(MessageType.UI,
                    "Вы на вкладке выбора аккаунта.");
            }
            else if (selectedTab.TabIndex == 1)
            {
                Logger.SendMessage(MessageType.UI,
                    "Вы на вкладке создания нового аккаунта.");
            }
        }

        private void AcSelTab_bSelAccSubmit_Click(object sender, EventArgs e)
        {
            if (Session.CurrentAccount == null)
                return;

            AccountSelected?.Invoke(Session.CurrentAccount.AccountID);
        }


        //Utils
        private void SetBalancePlaceholder()
        {
            tbAccBalance.ForeColor = System.Drawing.Color.Gray;
            tbAccBalance.Text = "Введите баланс";

        }

        private void RemoveBalancePlaceholder(object sender, EventArgs e)
        {
            if (tbAccBalance.Text == "Введите баланс")
            {
                tbAccBalance.ForeColor = System.Drawing.Color.Black;
            }
        }

    }
}
