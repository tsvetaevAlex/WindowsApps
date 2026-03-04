using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    partial class WalletForm
    {
        private IContainer components = null;

        private ToolTip tt_newWalletName;
        private ToolTip tt_CardName;
        private ToolTip tt_ms_type_selector;
        private ToolTip tt_ms_ballanse;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tt_newWalletName = new System.Windows.Forms.ToolTip(this.components);
            this.tbNewWalletName = new System.Windows.Forms.TextBox();
            this.tt_CardName = new System.Windows.Forms.ToolTip(this.components);
            this.tt_ms_type_selector = new System.Windows.Forms.ToolTip(this.components);
            this.gb_MStype_Line1 = new System.Windows.Forms.ComboBox();
            this.gb_MStype_Line2 = new System.Windows.Forms.ComboBox();
            this.tt_ms_ballanse = new System.Windows.Forms.ToolTip(this.components);
            this.gb_MS_balanse_Line1 = new System.Windows.Forms.TextBox();
            this.gb_MS_balanse_Line2 = new System.Windows.Forms.TextBox();
            this.gbNewWallet = new System.Windows.Forms.GroupBox();
            this.bSaveNewWalletName = new System.Windows.Forms.Button();
            this.gbMoneySource = new System.Windows.Forms.GroupBox();
            this.label_cb_MS_type = new System.Windows.Forms.Label();
            this.label_cb_MS_balamse = new System.Windows.Forms.Label();
            this.WallesList = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.bAddAAccount_to_Wallet = new System.Windows.Forms.Button();
            this.gbWallet = new System.Windows.Forms.GroupBox();
            this.gbExistingAccounts = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbNewWallet.SuspendLayout();
            this.gbMoneySource.SuspendLayout();
            this.gbWallet.SuspendLayout();
            this.gbExistingAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNewWalletName
            // 
            this.tbNewWalletName.Location = new System.Drawing.Point(20, 20);
            this.tbNewWalletName.Name = "tbNewWalletName";
            this.tbNewWalletName.Size = new System.Drawing.Size(250, 20);
            this.tbNewWalletName.TabIndex = 0;
            this.tbNewWalletName.Text = "укажите имя для Вашего первого кощелька.";
            this.tt_newWalletName.SetToolTip(this.tbNewWalletName, "укажите имя своего первого кошелька");
            this.tbNewWalletName.Enter += new System.EventHandler(this.tbNewWalletName_MouseEnter);
            // 
            // gb_MStype_Line1
            // 
            this.gb_MStype_Line1.Items.AddRange(new object[] {
            "наличные",
            "карточка"});
            this.gb_MStype_Line1.Location = new System.Drawing.Point(10, 50);
            this.gb_MStype_Line1.Name = "gb_MStype_Line1";
            this.gb_MStype_Line1.Size = new System.Drawing.Size(120, 21);
            this.gb_MStype_Line1.TabIndex = 1;
            this.tt_ms_type_selector.SetToolTip(this.gb_MStype_Line1, "выберите тип наличные/карточка");
            // 
            // gb_MStype_Line2
            // 
            this.gb_MStype_Line2.Items.AddRange(new object[] {
            "наличные",
            "карточка"});
            this.gb_MStype_Line2.Location = new System.Drawing.Point(10, 80);
            this.gb_MStype_Line2.Name = "gb_MStype_Line2";
            this.gb_MStype_Line2.Size = new System.Drawing.Size(120, 21);
            this.gb_MStype_Line2.TabIndex = 2;
            this.tt_ms_type_selector.SetToolTip(this.gb_MStype_Line2, "выберите тип наличные/карточка");
            // 
            // gb_MS_balanse_Line1
            // 
            this.gb_MS_balanse_Line1.Location = new System.Drawing.Point(140, 50);
            this.gb_MS_balanse_Line1.Name = "gb_MS_balanse_Line1";
            this.gb_MS_balanse_Line1.Size = new System.Drawing.Size(105, 20);
            this.gb_MS_balanse_Line1.TabIndex = 3;
            this.tt_ms_ballanse.SetToolTip(this.gb_MS_balanse_Line1, "Укажите начальное значение");
            // 
            // gb_MS_balanse_Line2
            // 
            this.gb_MS_balanse_Line2.Location = new System.Drawing.Point(140, 80);
            this.gb_MS_balanse_Line2.Name = "gb_MS_balanse_Line2";
            this.gb_MS_balanse_Line2.Size = new System.Drawing.Size(105, 20);
            this.gb_MS_balanse_Line2.TabIndex = 4;
            this.tt_ms_ballanse.SetToolTip(this.gb_MS_balanse_Line2, "Укажите начальное значение");
            this.gb_MS_balanse_Line2.MouseEnter += new System.EventHandler(this.gb_MS_balanse_Line2_MouseEnter);
            // 
            // gbNewWallet
            // 
            this.gbNewWallet.Controls.Add(this.tbNewWalletName);
            this.gbNewWallet.Controls.Add(this.bSaveNewWalletName);
            this.gbNewWallet.Location = new System.Drawing.Point(20, 24);
            this.gbNewWallet.Name = "gbNewWallet";
            this.gbNewWallet.Size = new System.Drawing.Size(355, 50);
            this.gbNewWallet.TabIndex = 4;
            this.gbNewWallet.TabStop = false;
            this.gbNewWallet.Text = "Имя нового кошелька";
            // 
            // bSaveNewWalletName
            // 
            this.bSaveNewWalletName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSaveNewWalletName.Location = new System.Drawing.Point(270, 19);
            this.bSaveNewWalletName.Name = "bSaveNewWalletName";
            this.bSaveNewWalletName.Size = new System.Drawing.Size(75, 22);
            this.bSaveNewWalletName.TabIndex = 1;
            this.bSaveNewWalletName.Text = "Ок";
            // 
            // gbMoneySource
            // 
            this.gbMoneySource.Controls.Add(this.label1);
            this.gbMoneySource.Controls.Add(this.label_cb_MS_type);
            this.gbMoneySource.Controls.Add(this.gb_MStype_Line1);
            this.gbMoneySource.Controls.Add(this.gb_MStype_Line2);
            this.gbMoneySource.Controls.Add(this.gb_MS_balanse_Line1);
            this.gbMoneySource.Controls.Add(this.gb_MS_balanse_Line2);
            this.gbMoneySource.Location = new System.Drawing.Point(20, 80);
            this.gbMoneySource.Name = "gbMoneySource";
            this.gbMoneySource.Size = new System.Drawing.Size(355, 120);
            this.gbMoneySource.TabIndex = 3;
            this.gbMoneySource.TabStop = false;
            this.gbMoneySource.Text = "Денежные средства";
            // 
            // label_cb_MS_type
            // 
            this.label_cb_MS_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_cb_MS_type.Location = new System.Drawing.Point(7, 24);
            this.label_cb_MS_type.Name = "label_cb_MS_type";
            this.label_cb_MS_type.Size = new System.Drawing.Size(120, 20);
            this.label_cb_MS_type.TabIndex = 0;
            this.label_cb_MS_type.Text = "наличные / карточка";
            // 
            // label_cb_MS_balamse
            // 
            this.label_cb_MS_balamse.Location = new System.Drawing.Point(0, 0);
            this.label_cb_MS_balamse.Name = "label_cb_MS_balamse";
            this.label_cb_MS_balamse.Size = new System.Drawing.Size(100, 23);
            this.label_cb_MS_balamse.TabIndex = 0;
            // 
            // WallesList
            // 
            this.WallesList.HideSelection = false;
            this.WallesList.Location = new System.Drawing.Point(3, 20);
            this.WallesList.Name = "WallesList";
            this.WallesList.Size = new System.Drawing.Size(120, 100);
            this.WallesList.TabIndex = 0;
            this.WallesList.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(120, 100);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // bAddAAccount_to_Wallet
            // 
            this.bAddAAccount_to_Wallet.Location = new System.Drawing.Point(153, 260);
            this.bAddAAccount_to_Wallet.Name = "bAddAAccount_to_Wallet";
            this.bAddAAccount_to_Wallet.Size = new System.Drawing.Size(90, 23);
            this.bAddAAccount_to_Wallet.TabIndex = 2;
            this.bAddAAccount_to_Wallet.Text = "<=Добавить";
            // 
            // gbWallet
            // 
            this.gbWallet.Controls.Add(this.WallesList);
            this.gbWallet.Location = new System.Drawing.Point(20, 240);
            this.gbWallet.Name = "gbWallet";
            this.gbWallet.Size = new System.Drawing.Size(123, 123);
            this.gbWallet.TabIndex = 1;
            this.gbWallet.TabStop = false;
            this.gbWallet.Text = "Ваш кошелёк";
            // 
            // gbExistingAccounts
            // 
            this.gbExistingAccounts.Controls.Add(this.listView1);
            this.gbExistingAccounts.Location = new System.Drawing.Point(253, 240);
            this.gbExistingAccounts.Name = "gbExistingAccounts";
            this.gbExistingAccounts.Size = new System.Drawing.Size(123, 123);
            this.gbExistingAccounts.TabIndex = 0;
            this.gbExistingAccounts.TabStop = false;
            this.gbExistingAccounts.Text = "Доступные счета";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(140, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "начальный баланс";
            // 
            // WalletForm
            // 
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.gbExistingAccounts);
            this.Controls.Add(this.gbWallet);
            this.Controls.Add(this.bAddAAccount_to_Wallet);
            this.Controls.Add(this.gbMoneySource);
            this.Controls.Add(this.gbNewWallet);
            this.Name = "WalletForm";
            this.Text = "Инициализация нового кошелька пользователя";
            this.gbNewWallet.ResumeLayout(false);
            this.gbNewWallet.PerformLayout();
            this.gbMoneySource.ResumeLayout(false);
            this.gbMoneySource.PerformLayout();
            this.gbWallet.ResumeLayout(false);
            this.gbExistingAccounts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private GroupBox gbNewWallet;
        private GroupBox gbMoneySource;
        private GroupBox gbWallet;
        private GroupBox gbExistingAccounts;

        private TextBox tbNewWalletName;
        private TextBox gb_MS_balanse_Line2;
        private TextBox gb_MS_balanse_Line1;

        private Label label_cb_MS_balamse;
        private Label label_cb_MS_type;

        private Button bSaveNewWalletName;
        private Button bAddAAccount_to_Wallet;

        private ComboBox gb_MStype_Line1;
        private ComboBox gb_MStype_Line2;

        private ListView WallesList;
        private ListView listView1;
        private Label label1;
    }
}