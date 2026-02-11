using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Budgethelper.Controls
{
    public partial class AccountsGroup : UserControl
    {
        //public event Action<int> AccountSelected;

        private List<Account> _accounts = new List<Account>();
        public AccountsGroup()
        {
            InitializeComponent();
            Logger.SendMessage(MessageType.UI, "AccountsGroup initialized.", Color.LightBlue);
            //            LoadAccounts();
        }

        private void bAddAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAccName.Text) ||
                string.IsNullOrWhiteSpace(tbAccDescription.Text) ||
                string.IsNullOrWhiteSpace(AcSelTab_tbAccbalanse.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
        }
        /*
private void LoadAccounts()
{
   if (!Session.IsAuthorized)
       return;

   _accounts = SqlService.GetAccounts(Session.Uid);

   listAccounts.Items.Clear();

   foreach (var acc in _accounts)
   {
       listAccounts.Items.Add($"{acc.AccountName} ({acc.Balance})");
   }
}

private void btnAdd_Click(object sender, EventArgs e)
{
   if (string.IsNullOrWhiteSpace(txtAccountName.Text))
       return;

   SqlService.CreateAccount(Session.Uid, txtAccountName.Text.Trim(), 0);

   txtAccountName.Clear();
   LoadAccounts();
}

private void listAccounts_SelectedIndexChanged(object sender, EventArgs e)
{
   if (listAccounts.SelectedIndex < 0)
   {
       AccountSelected?.Invoke(0);
       return;
   }

   var selected = _accounts[listAccounts.SelectedIndex];
   AccountSelected?.Invoke(selected.Id);
}
*/

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTab = AccountsGroupControlTabs.SelectedTab;

            Logger.SendMessage(MessageType.UI,
                $"Switched to tab{selectedTab.TabIndex}: {selectedTab.Text}\r\n");
            if (selectedTab.TabIndex == 0)
            {
                Logger.SendMessage(MessageType.UI,
                    $"сейас ыв находитесь на закладке{selectedTab.Text}, тут Вы можете выбрать аккаунт в котороый Вы будете добавлять транзакции. ");
            }
            else if (selectedTab.TabIndex == 1)
            {
                Logger.SendMessage(MessageType.UI, $"сейас ыв находитесь на закладке{selectedTab.Text}, тут Вы можете сделать новый аккаунт для себя (для классификации расходов) +например: \'ЖКХ\', \'расходы на авто\', \'Продукты\', \'кафе\'.");
            }
        }// end of TabControl1_SelectedIndexChanged
    } // end of class AccountsGroup : UserControl
} // end of namespace Budgethelper.Controls
