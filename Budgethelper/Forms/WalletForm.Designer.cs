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
            this.Wallet_tb_NewWalletName = new System.Windows.Forms.TextBox();
            this.tt_CardName = new System.Windows.Forms.ToolTip(this.components);
            this.tt_ms_type_selector = new System.Windows.Forms.ToolTip(this.components);
            this.gb_MStype_Line1 = new System.Windows.Forms.ComboBox();
            this.gb_MStype_Line2 = new System.Windows.Forms.ComboBox();
            this.tt_ms_ballanse = new System.Windows.Forms.ToolTip(this.components);
            this.gb_MS_balanse_Line1 = new System.Windows.Forms.TextBox();
            this.gb_MS_balanse_Line2 = new System.Windows.Forms.TextBox();
            this.Wallet_gbNewWallet = new System.Windows.Forms.GroupBox();
            this.Wallet_b_SaveNewWalletName = new System.Windows.Forms.Button();
            this.gbMoneySource = new System.Windows.Forms.GroupBox();
            this.Wallet_label_currentBallanse = new System.Windows.Forms.Label();
            this.label_cb_MS_type = new System.Windows.Forms.Label();
            this.label_cb_MS_balamse = new System.Windows.Forms.Label();
            this.Wallet_ListView_WallesList = new System.Windows.Forms.ListView();
            this.Wallet_ListView_Accounts = new System.Windows.Forms.ListView();
            this.bAddAAccount_to_Wallet = new System.Windows.Forms.Button();
            this.gbWallet = new System.Windows.Forms.GroupBox();
            this.gbExistingAccounts = new System.Windows.Forms.GroupBox();
            this.Wallet_GroupBox_newAccount = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Wallet_label_NewAccDescription = new System.Windows.Forms.Label();
            this.Wallet_button_AddNewAcc = new System.Windows.Forms.Button();
            this.Wallet_tb_NewAccBallanse = new System.Windows.Forms.TextBox();
            this.Wallet_label_NewAccBallanse = new System.Windows.Forms.Label();
            this.Wallet_tb_NewAccName = new System.Windows.Forms.TextBox();
            this.Wallet_label_NewAccName = new System.Windows.Forms.Label();
            this.Wallet_cb_AccountType = new System.Windows.Forms.Label();
            this.Wallet_cb_NewAccType = new System.Windows.Forms.ComboBox();
            this.Wallet_gbNewWallet.SuspendLayout();
            this.gbMoneySource.SuspendLayout();
            this.gbWallet.SuspendLayout();
            this.gbExistingAccounts.SuspendLayout();
            this.Wallet_GroupBox_newAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wallet_tb_NewWalletName
            // 
            this.Wallet_tb_NewWalletName.Location = new System.Drawing.Point(20, 20);
            this.Wallet_tb_NewWalletName.Name = "Wallet_tb_NewWalletName";
            this.Wallet_tb_NewWalletName.Size = new System.Drawing.Size(250, 20);
            this.Wallet_tb_NewWalletName.TabIndex = 0;
            this.Wallet_tb_NewWalletName.Text = "укажите имя для Вашего первого кощелька.";
            this.tt_newWalletName.SetToolTip(this.Wallet_tb_NewWalletName, "укажите имя своего первого кошелька");
            this.Wallet_tb_NewWalletName.Enter += new System.EventHandler(this.tbNewWalletName_MouseEnter);
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
            // Wallet_gbNewWallet
            // 
            this.Wallet_gbNewWallet.Controls.Add(this.Wallet_tb_NewWalletName);
            this.Wallet_gbNewWallet.Controls.Add(this.Wallet_b_SaveNewWalletName);
            this.Wallet_gbNewWallet.Location = new System.Drawing.Point(20, 24);
            this.Wallet_gbNewWallet.Name = "Wallet_gbNewWallet";
            this.Wallet_gbNewWallet.Size = new System.Drawing.Size(355, 50);
            this.Wallet_gbNewWallet.TabIndex = 4;
            this.Wallet_gbNewWallet.TabStop = false;
            this.Wallet_gbNewWallet.Text = "Имя нового кошелька";
            // 
            // Wallet_b_SaveNewWalletName
            // 
            this.Wallet_b_SaveNewWalletName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wallet_b_SaveNewWalletName.Location = new System.Drawing.Point(270, 19);
            this.Wallet_b_SaveNewWalletName.Name = "Wallet_b_SaveNewWalletName";
            this.Wallet_b_SaveNewWalletName.Size = new System.Drawing.Size(75, 22);
            this.Wallet_b_SaveNewWalletName.TabIndex = 1;
            this.Wallet_b_SaveNewWalletName.Text = "Ок";
            // 
            // gbMoneySource
            // 
            this.gbMoneySource.Controls.Add(this.Wallet_label_currentBallanse);
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
            // label_tb_currentBallanse
            // 
            this.Wallet_label_currentBallanse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Wallet_label_currentBallanse.Location = new System.Drawing.Point(140, 24);
            this.Wallet_label_currentBallanse.Name = "label_tb_currentBallanse";
            this.Wallet_label_currentBallanse.Size = new System.Drawing.Size(105, 20);
            this.Wallet_label_currentBallanse.TabIndex = 5;
            this.Wallet_label_currentBallanse.Text = "начальный баланс";
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
            // Wallet_ListView_WallesList
            // 
            this.Wallet_ListView_WallesList.HideSelection = false;
            this.Wallet_ListView_WallesList.Location = new System.Drawing.Point(3, 20);
            this.Wallet_ListView_WallesList.Name = "Wallet_ListView_WallesList";
            this.Wallet_ListView_WallesList.Size = new System.Drawing.Size(120, 100);
            this.Wallet_ListView_WallesList.TabIndex = 0;
            this.Wallet_ListView_WallesList.UseCompatibleStateImageBehavior = false;
            // 
            // Wallet_ListView_Accounts
            // 
            this.Wallet_ListView_Accounts.HideSelection = false;
            this.Wallet_ListView_Accounts.Location = new System.Drawing.Point(3, 20);
            this.Wallet_ListView_Accounts.Name = "Wallet_ListView_Accounts";
            this.Wallet_ListView_Accounts.Size = new System.Drawing.Size(120, 100);
            this.Wallet_ListView_Accounts.TabIndex = 0;
            this.Wallet_ListView_Accounts.UseCompatibleStateImageBehavior = false;
            this.Wallet_ListView_Accounts.GridLines = true;
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
            this.gbWallet.Controls.Add(this.Wallet_ListView_WallesList);
            this.gbWallet.Location = new System.Drawing.Point(20, 240);
            this.gbWallet.Name = "gbWallet";
            this.gbWallet.Size = new System.Drawing.Size(123, 123);
            this.gbWallet.TabIndex = 1;
            this.gbWallet.TabStop = false;
            this.gbWallet.Text = "Ваш кошелёк";
            // 
            // gbExistingAccounts
            // 
            this.gbExistingAccounts.Controls.Add(this.Wallet_ListView_Accounts);
            this.gbExistingAccounts.Location = new System.Drawing.Point(253, 240);
            this.gbExistingAccounts.Name = "gbExistingAccounts";
            this.gbExistingAccounts.Size = new System.Drawing.Size(123, 123);
            this.gbExistingAccounts.TabIndex = 0;
            this.gbExistingAccounts.TabStop = false;
            this.gbExistingAccounts.Text = "Доступные счета";
            // 
            // gb_newAccount
            // 
            this.Wallet_GroupBox_newAccount.Controls.Add(this.textBox1);
            this.Wallet_GroupBox_newAccount.Controls.Add(this.Wallet_label_NewAccDescription);
            this.Wallet_GroupBox_newAccount.Controls.Add(this.Wallet_button_AddNewAcc);
            this.Wallet_GroupBox_newAccount.Controls.Add(this.Wallet_tb_NewAccBallanse);
            this.Wallet_GroupBox_newAccount.Controls.Add(this.Wallet_label_NewAccBallanse);
            this.Wallet_GroupBox_newAccount.Controls.Add(this.Wallet_tb_NewAccName);
            this.Wallet_GroupBox_newAccount.Controls.Add(this.Wallet_label_NewAccName);
            this.Wallet_GroupBox_newAccount.Controls.Add(this.Wallet_cb_AccountType);
            this.Wallet_GroupBox_newAccount.Controls.Add(this.Wallet_cb_NewAccType);
            this.Wallet_GroupBox_newAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wallet_GroupBox_newAccount.Location = new System.Drawing.Point(385, 24);
            this.Wallet_GroupBox_newAccount.Name = "gb_newAccount";
            this.Wallet_GroupBox_newAccount.Size = new System.Drawing.Size(330, 176);
            this.Wallet_GroupBox_newAccount.TabIndex = 5;
            this.Wallet_GroupBox_newAccount.TabStop = false;
            this.Wallet_GroupBox_newAccount.Text = "Новый Аккаунт";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Wallet_label_NewAccDescription
            // 
            this.Wallet_label_NewAccDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Wallet_label_NewAccDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wallet_label_NewAccDescription.Location = new System.Drawing.Point(150, 65);
            this.Wallet_label_NewAccDescription.Name = "Wallet_label_NewAccDescription";
            this.Wallet_label_NewAccDescription.Size = new System.Drawing.Size(120, 15);
            this.Wallet_label_NewAccDescription.TabIndex = 7;
            this.Wallet_label_NewAccDescription.Text = "Имя Аккаунта";
            // 
            // Wallet_button_AddNewAcc
            // 
            this.Wallet_button_AddNewAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wallet_button_AddNewAcc.Location = new System.Drawing.Point(20, 147);
            this.Wallet_button_AddNewAcc.Name = "Wallet_button_AddNewAcc";
            this.Wallet_button_AddNewAcc.Size = new System.Drawing.Size(120, 23);
            this.Wallet_button_AddNewAcc.TabIndex = 6;
            this.Wallet_button_AddNewAcc.Text = "Добавить.";
            this.Wallet_button_AddNewAcc.UseVisualStyleBackColor = true;
            this.Wallet_button_AddNewAcc.Click += new System.EventHandler(this.Wallet_button_AddNewAcc_Click);
            // 
            // Wallet_tb_NewAccBallanse
            // 
            this.Wallet_tb_NewAccBallanse.Location = new System.Drawing.Point(150, 41);
            this.Wallet_tb_NewAccBallanse.Name = "Wallet_tb_NewAccBallanse";
            this.Wallet_tb_NewAccBallanse.Size = new System.Drawing.Size(120, 20);
            this.Wallet_tb_NewAccBallanse.TabIndex = 5;
            // 
            // Wallet_label_NewAccBallanse
            // 
            this.Wallet_label_NewAccBallanse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Wallet_label_NewAccBallanse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wallet_label_NewAccBallanse.Location = new System.Drawing.Point(150, 23);
            this.Wallet_label_NewAccBallanse.Name = "Wallet_label_NewAccBallanse";
            this.Wallet_label_NewAccBallanse.Size = new System.Drawing.Size(120, 15);
            this.Wallet_label_NewAccBallanse.TabIndex = 4;
            this.Wallet_label_NewAccBallanse.Text = "Теукущий Баланс ";
            // 
            // Wallet_tb_NewAccName
            // 
            this.Wallet_tb_NewAccName.Location = new System.Drawing.Point(20, 80);
            this.Wallet_tb_NewAccName.Name = "Wallet_tb_NewAccName";
            this.Wallet_tb_NewAccName.Size = new System.Drawing.Size(120, 20);
            this.Wallet_tb_NewAccName.TabIndex = 3;
            // 
            // Wallet_label_NewAccName
            // 
            this.Wallet_label_NewAccName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Wallet_label_NewAccName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wallet_label_NewAccName.Location = new System.Drawing.Point(20, 65);
            this.Wallet_label_NewAccName.Name = "Wallet_label_NewAccName";
            this.Wallet_label_NewAccName.Size = new System.Drawing.Size(120, 15);
            this.Wallet_label_NewAccName.TabIndex = 2;
            this.Wallet_label_NewAccName.Text = "Имя Аккаунта";
            // 
            // Wallet_cb_AccountType
            // 
            this.Wallet_cb_AccountType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Wallet_cb_AccountType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wallet_cb_AccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wallet_cb_AccountType.Location = new System.Drawing.Point(20, 20);
            this.Wallet_cb_AccountType.Name = "Wallet_cb_AccountType";
            this.Wallet_cb_AccountType.Size = new System.Drawing.Size(120, 20);
            this.Wallet_cb_AccountType.TabIndex = 1;
            this.Wallet_cb_AccountType.Text = "наличные / карточка";
            // 
            // Wallet_cb_NewAccType
            // 
            this.Wallet_cb_NewAccType.FormattingEnabled = true;
            this.Wallet_cb_NewAccType.Location = new System.Drawing.Point(20, 40);
            this.Wallet_cb_NewAccType.Name = "Wallet_cb_NewAccType";
            this.Wallet_cb_NewAccType.Size = new System.Drawing.Size(120, 21);
            this.Wallet_cb_NewAccType.TabIndex = 0;
            // 
            // WalletForm
            // 
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.Wallet_GroupBox_newAccount);
            this.Controls.Add(this.gbExistingAccounts);
            this.Controls.Add(this.gbWallet);
            this.Controls.Add(this.bAddAAccount_to_Wallet);
            this.Controls.Add(this.gbMoneySource);
            this.Controls.Add(this.Wallet_gbNewWallet);
            this.Name = "WalletForm";
            this.Text = "Инициализация нового кошелька пользователя";
            this.Wallet_gbNewWallet.ResumeLayout(false);
            this.Wallet_gbNewWallet.PerformLayout();
            this.gbMoneySource.ResumeLayout(false);
            this.gbMoneySource.PerformLayout();
            this.gbWallet.ResumeLayout(false);
            this.gbExistingAccounts.ResumeLayout(false);
            this.Wallet_GroupBox_newAccount.ResumeLayout(false);
            this.Wallet_GroupBox_newAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        private GroupBox Wallet_gbNewWallet;
        private GroupBox gbMoneySource;
        private GroupBox gbWallet;
        private GroupBox gbExistingAccounts;

        private TextBox Wallet_tb_NewWalletName;
        private TextBox gb_MS_balanse_Line2;
        private TextBox gb_MS_balanse_Line1;

        private Label label_cb_MS_balamse;
        private Label label_cb_MS_type;

        private Button Wallet_b_SaveNewWalletName;
        private Button bAddAAccount_to_Wallet;

        private ComboBox gb_MStype_Line1;
        private ComboBox gb_MStype_Line2;

        private ListView Wallet_ListView_WallesList;
        private ListView Wallet_ListView_Accounts;
        private Label Wallet_label_currentBallanse;
        private GroupBox Wallet_GroupBox_newAccount;
        private Label Wallet_label_NewAccName;
        private Label Wallet_cb_AccountType;
        private ComboBox Wallet_cb_NewAccType;
        private TextBox Wallet_tb_NewAccName;
        private Label Wallet_label_NewAccBallanse;
        private Button Wallet_button_AddNewAcc;
        private TextBox Wallet_tb_NewAccBallanse;
        private TextBox textBox1;
        private Label Wallet_label_NewAccDescription;
    }
}