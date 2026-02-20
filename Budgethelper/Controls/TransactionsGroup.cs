using System;
using System.Windows.Forms;
using Budgethelper.Models;

namespace Budgethelper.Controls
{
    public partial class TransactionsGroup : UserControl
    {
        private Account _currentAccount;

        public TransactionsGroup()
        {
            InitializeComponent();

            // Настройка UI
            rtbTransact_QTY.Text = "0";
            cbOperationType.DataSource = Enum.GetValues(typeof(TransactionType));
            rtbTransact_QTY.SelectAll();
            rtbTransact_QTY.SelectionAlignment = HorizontalAlignment.Right;
            tbTransactQTY.TextAlign = HorizontalAlignment.Right;
            rtbTransact_QTY.DeselectAll();
        }
        
        #region Utils
        public void SetAccount(Account account)
        {
            if (account == null)
                return;

            _currentAccount = account;
            TranzactGroup_tbAccountName.Text = account.AccountName;
        }



        public Transaction GetTransactionFromInputs()
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
                throw new Exception("Сумма введена неверно.");

            if (_currentAccount == null)
                throw new Exception("Аккаунт не выбран.");

            return new Transaction
            {
                AccountId = _currentAccount.AccountID,     // используем текущий аккаунт
                Date = datePicker.Value,                  // выбранная дата
                Amount = amount,                          // сумма из формы
                OperationType = (TransactionType)cbOperationType.SelectedItem, // операция
                Description = txtDescription.Text        // описание
            };
        }
        #endregion

        #region Event handlers
        private void BtnToday_Click(object sender, EventArgs e) => datePicker.Value = DateTime.Today;
        private void BtnYesterday_Click(object sender, EventArgs e) => datePicker.Value = DateTime.Today.AddDays(-1);
        private void bAddTransact_Click(object sender, EventArgs e)
        {
            // Заполняем тестовые данные перед добавлением
            TransactionsGroup_RandomDataFiller();

            // Создаём транзакцию
            Transaction transaction = GetTransactionFromInputs();

            Session.TransactQTY++;
            rtbTransact_QTY.Text = Session.TransactQTY.ToString();
            rtbTransact_QTY.SelectAll();
            rtbTransact_QTY.SelectionAlignment = HorizontalAlignment.Right;
            rtbTransact_QTY.DeselectAll();
        }

        public void TransactionsGroup_RandomDataFiller()
        {
            if (_currentAccount == null)
                return;

            Random random = new Random();

            // 1️⃣ Дата случайно: сегодня или вчера
            if (random.Next(0, 2) == 0)
                BtnYesterday_Click(this, EventArgs.Empty);
            else
                BtnToday_Click(this, EventArgs.Empty);

            // 2️⃣ Сумма от 55 до 1750
            txtAmount.Text = random.Next(55, 1751).ToString();

            // 3️⃣ Тип операции 0 или 1
            cbOperationType.SelectedIndex = random.Next(0, 2);

            // 4️⃣ Случайное описание 25 символов
            const string chars = " абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            char[] text = new char[25];
            for (int i = 0; i < 25; i++)
                text[i] = chars[random.Next(chars.Length)];
            txtDescription.Text = new string(text);
        }

        #endregion
    }
}