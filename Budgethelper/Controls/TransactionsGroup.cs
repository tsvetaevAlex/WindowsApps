using System;
using System.Windows.Forms;

namespace Budgethelper.Controls
{
    public partial class TransactionsGroup : UserControl
    {
        public TransactionsGroup()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // временно заглушка
            MessageBox.Show("Добавление транзакции (временно)");
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Today;
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Today.AddDays(-1);
        }
    }
}
