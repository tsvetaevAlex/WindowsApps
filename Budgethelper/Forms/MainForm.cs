using System;
using System.Windows.Forms;
using Budgethelper.Models;
using Budgethelper.Controls;

namespace Budgethelper.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitSessionInfo();
            WireEvents();
        }

        private void InitSessionInfo()
        {
            if (Session.CurrentUser != null)
            {
                lblUser.Text =
                    $"{Session.CurrentUser.SureName} " +
                    $"{Session.CurrentUser.Name} " +
                    $"{Session.CurrentUser.LastName}";

                lblUid.Text = $"UID: {Session.Uid}";
            }
            else
            {
                lblUser.Text = "Пользователь не загружен";
                lblUid.Text = string.Empty;
            }
        }

        private void WireEvents()
        {
            accountsGroupRur.AccountSelected += account =>
            {
                transactionsGroupRur.LoadAccount(account.Id);
            };

            accountsGroupUsd.AccountSelected += account =>
            {
                transactionsGroupUsd.LoadAccount(account.Id);
            };
        }
    }
}
