namespace Budgethelper.Controls
{
    partial class AccountsGroup
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.AcSelTab_cbACcountsListSelector = new System.Windows.Forms.ComboBox();
            this.AcSelTab_lbTitle = new System.Windows.Forms.Label();
            this.AcSelTab_bSelAccSubmit = new System.Windows.Forms.Button();
            this.AcSelTab_tbHeader = new System.Windows.Forms.TextBox();
            this.AcSelTab_tbAccbalanse = new System.Windows.Forms.TextBox();
            this.tbAccName = new System.Windows.Forms.TextBox();
            this.AcSelTab_tbAccComent = new System.Windows.Forms.TextBox();
            this.lbAccName = new System.Windows.Forms.Label();
            this.lbAccBalance = new System.Windows.Forms.Label();
            this.AcSelTab_lbAccComent = new System.Windows.Forms.Label();
            this.gbaccounGroup = new System.Windows.Forms.GroupBox();
            this.AcSelTab_lbAccBalance = new System.Windows.Forms.Label();
            this.AccountsGroupControlTabs = new System.Windows.Forms.TabControl();
            this.accountPicker = new System.Windows.Forms.TabPage();
            this.accountCeator = new System.Windows.Forms.TabPage();
            this.bAddAccount = new System.Windows.Forms.Button();
            this.lbAccDescription = new System.Windows.Forms.Label();
            this.tbAccDescription = new System.Windows.Forms.TextBox();
            this.tbAccBalance = new System.Windows.Forms.TextBox();
            this.gbaccounGroup.SuspendLayout();
            this.AccountsGroupControlTabs.SuspendLayout();
            this.accountPicker.SuspendLayout();
            this.accountCeator.SuspendLayout();
            this.SuspendLayout();
            // 
            // AcSelTab_cbACcountsListSelector
            // 
            this.AcSelTab_cbACcountsListSelector.FormattingEnabled = true;
            this.AcSelTab_cbACcountsListSelector.Location = new System.Drawing.Point(20, 71);
            this.AcSelTab_cbACcountsListSelector.Name = "AcSelTab_cbACcountsListSelector";
            this.AcSelTab_cbACcountsListSelector.Size = new System.Drawing.Size(550, 21);
            this.AcSelTab_cbACcountsListSelector.TabIndex = 0;
            this.AcSelTab_cbACcountsListSelector.TabStop = false;
            this.AcSelTab_cbACcountsListSelector.Text = "choose account to work with";
            // 
            // AcSelTab_lbTitle
            // 
            this.AcSelTab_lbTitle.AutoSize = true;
            this.AcSelTab_lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcSelTab_lbTitle.Location = new System.Drawing.Point(20, 50);
            this.AcSelTab_lbTitle.Name = "AcSelTab_lbTitle";
            this.AcSelTab_lbTitle.Size = new System.Drawing.Size(233, 16);
            this.AcSelTab_lbTitle.TabIndex = 1;
            this.AcSelTab_lbTitle.Text = "select account to add transactions into";
            // 
            // AcSelTab_bSelAccSubmit
            // 
            this.AcSelTab_bSelAccSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcSelTab_bSelAccSubmit.Location = new System.Drawing.Point(580, 71);
            this.AcSelTab_bSelAccSubmit.Name = "AcSelTab_bSelAccSubmit";
            this.AcSelTab_bSelAccSubmit.Size = new System.Drawing.Size(80, 23);
            this.AcSelTab_bSelAccSubmit.TabIndex = 2;
            this.AcSelTab_bSelAccSubmit.Text = "Выбрать";
            this.AcSelTab_bSelAccSubmit.UseVisualStyleBackColor = true;
            // 
            // AcSelTab_tbHeader
            // 
            this.AcSelTab_tbHeader.Location = new System.Drawing.Point(20, 20);
            this.AcSelTab_tbHeader.Name = "AcSelTab_tbHeader";
            this.AcSelTab_tbHeader.ReadOnly = true;
            this.AcSelTab_tbHeader.Size = new System.Drawing.Size(630, 20);
            this.AcSelTab_tbHeader.TabIndex = 3;
            this.AcSelTab_tbHeader.Text = "Цветаева Ольга Александровна UID: ";
            // 
            // AcSelTab_tbAccbalanse
            // 
            this.AcSelTab_tbAccbalanse.Location = new System.Drawing.Point(180, 126);
            this.AcSelTab_tbAccbalanse.Name = "AcSelTab_tbAccbalanse";
            this.AcSelTab_tbAccbalanse.ReadOnly = true;
            this.AcSelTab_tbAccbalanse.Size = new System.Drawing.Size(100, 20);
            this.AcSelTab_tbAccbalanse.TabIndex = 4;
            this.AcSelTab_tbAccbalanse.Text = "999 000 000 000";
            // 
            // tbAccName
            // 
            this.tbAccName.Location = new System.Drawing.Point(16, 39);
            this.tbAccName.Name = "tbAccName";
            this.tbAccName.ReadOnly = true;
            this.tbAccName.Size = new System.Drawing.Size(100, 20);
            this.tbAccName.TabIndex = 0;
            this.tbAccName.Text = "Name";
            // 
            // AcSelTab_tbAccComent
            // 
            this.AcSelTab_tbAccComent.Location = new System.Drawing.Point(290, 126);
            this.AcSelTab_tbAccComent.Name = "AcSelTab_tbAccComent";
            this.AcSelTab_tbAccComent.ReadOnly = true;
            this.AcSelTab_tbAccComent.Size = new System.Drawing.Size(180, 20);
            this.AcSelTab_tbAccComent.TabIndex = 7;
            this.AcSelTab_tbAccComent.Text = "AccDescrition";
            // 
            // lbAccName
            // 
            this.lbAccName.AutoSize = true;
            this.lbAccName.Location = new System.Drawing.Point(16, 21);
            this.lbAccName.Name = "lbAccName";
            this.lbAccName.Size = new System.Drawing.Size(81, 13);
            this.lbAccName.TabIndex = 3;
            this.lbAccName.Text = "Account Name:";
            // 
            // lbAccBalance
            // 
            this.lbAccBalance.AutoSize = true;
            this.lbAccBalance.Location = new System.Drawing.Point(126, 21);
            this.lbAccBalance.Name = "lbAccBalance";
            this.lbAccBalance.Size = new System.Drawing.Size(89, 13);
            this.lbAccBalance.TabIndex = 13;
            this.lbAccBalance.Text = "Account Balance";
            // 
            // AcSelTab_lbAccComent
            // 
            this.AcSelTab_lbAccComent.AutoSize = true;
            this.AcSelTab_lbAccComent.Location = new System.Drawing.Point(290, 108);
            this.AcSelTab_lbAccComent.Name = "AcSelTab_lbAccComent";
            this.AcSelTab_lbAccComent.Size = new System.Drawing.Size(133, 13);
            this.AcSelTab_lbAccComent.TabIndex = 12;
            this.AcSelTab_lbAccComent.Text = "комментарий к аккаунту";
            // 
            // gbaccounGroup
            // 
            this.gbaccounGroup.Controls.Add(this.AcSelTab_lbAccBalance);
            this.gbaccounGroup.Controls.Add(this.AcSelTab_tbHeader);
            this.gbaccounGroup.Controls.Add(this.AcSelTab_lbAccComent);
            this.gbaccounGroup.Controls.Add(this.AcSelTab_cbACcountsListSelector);
            this.gbaccounGroup.Controls.Add(this.AcSelTab_lbTitle);
            this.gbaccounGroup.Controls.Add(this.AcSelTab_bSelAccSubmit);
            this.gbaccounGroup.Controls.Add(this.AcSelTab_tbAccbalanse);
            this.gbaccounGroup.Controls.Add(this.AcSelTab_tbAccComent);
            this.gbaccounGroup.Location = new System.Drawing.Point(10, 10);
            this.gbaccounGroup.Name = "gbaccounGroup";
            this.gbaccounGroup.Size = new System.Drawing.Size(680, 156);
            this.gbaccounGroup.TabIndex = 13;
            this.gbaccounGroup.TabStop = false;
            this.gbaccounGroup.Text = "выбор Аккаунта для работы с транзакциями";
            // 
            // AcSelTab_lbAccBalance
            // 
            this.AcSelTab_lbAccBalance.AutoSize = true;
            this.AcSelTab_lbAccBalance.Location = new System.Drawing.Point(180, 108);
            this.AcSelTab_lbAccBalance.Name = "AcSelTab_lbAccBalance";
            this.AcSelTab_lbAccBalance.Size = new System.Drawing.Size(92, 13);
            this.AcSelTab_lbAccBalance.TabIndex = 13;
            this.AcSelTab_lbAccBalance.Text = "текущий баланс:";
            // 
            // AccountsGroupControlTabs
            // 
            this.AccountsGroupControlTabs.Controls.Add(this.accountPicker);
            this.AccountsGroupControlTabs.Controls.Add(this.accountCeator);
            this.AccountsGroupControlTabs.Location = new System.Drawing.Point(10, 10);
            this.AccountsGroupControlTabs.Name = "AccountsGroupControlTabs";
            this.AccountsGroupControlTabs.SelectedIndex = 0;
            this.AccountsGroupControlTabs.Size = new System.Drawing.Size(720, 190);
            this.AccountsGroupControlTabs.TabIndex = 14;
            // 
            // accountPicker
            // 
            this.accountPicker.BackColor = System.Drawing.SystemColors.Control;
            this.accountPicker.Controls.Add(this.gbaccounGroup);
            this.accountPicker.Location = new System.Drawing.Point(4, 22);
            this.accountPicker.Name = "accountPicker";
            this.accountPicker.Padding = new System.Windows.Forms.Padding(3);
            this.accountPicker.Size = new System.Drawing.Size(712, 164);
            this.accountPicker.TabIndex = 0;
            this.accountPicker.Text = "Выбор Аккаунта";
            // 
            // accountCeator
            // 
            this.accountCeator.Controls.Add(this.bAddAccount);
            this.accountCeator.Controls.Add(this.lbAccDescription);
            this.accountCeator.Controls.Add(this.lbAccBalance);
            this.accountCeator.Controls.Add(this.lbAccName);
            this.accountCeator.Controls.Add(this.tbAccDescription);
            this.accountCeator.Controls.Add(this.tbAccBalance);
            this.accountCeator.Controls.Add(this.tbAccName);
            this.accountCeator.Location = new System.Drawing.Point(4, 22);
            this.accountCeator.Name = "accountCeator";
            this.accountCeator.Padding = new System.Windows.Forms.Padding(3);
            this.accountCeator.Size = new System.Drawing.Size(712, 164);
            this.accountCeator.TabIndex = 1;
            this.accountCeator.Text = "Создать Аккаунт";
            this.accountCeator.UseVisualStyleBackColor = true;
            // 
            // bAddAccount
            // 
            this.bAddAccount.Location = new System.Drawing.Point(537, 19);
            this.bAddAccount.Name = "bAddAccount";
            this.bAddAccount.Size = new System.Drawing.Size(106, 40);
            this.bAddAccount.TabIndex = 6;
            this.bAddAccount.Text = "Добавить аккаунт";
            this.bAddAccount.UseVisualStyleBackColor = true;
            // 
            // lbAccDescription
            // 
            this.lbAccDescription.AutoSize = true;
            this.lbAccDescription.Location = new System.Drawing.Point(259, 21);
            this.lbAccDescription.Name = "lbAccDescription";
            this.lbAccDescription.Size = new System.Drawing.Size(103, 13);
            this.lbAccDescription.TabIndex = 5;
            this.lbAccDescription.Text = "Account Description";
            // 
            // tbAccDescription
            // 
            this.tbAccDescription.Location = new System.Drawing.Point(262, 39);
            this.tbAccDescription.Name = "tbAccDescription";
            this.tbAccDescription.Size = new System.Drawing.Size(255, 20);
            this.tbAccDescription.TabIndex = 2;
            this.tbAccDescription.Text = "Description";
            // 
            // tbAccBalance
            // 
            this.tbAccBalance.Location = new System.Drawing.Point(126, 39);
            this.tbAccBalance.Name = "tbAccBalance";
            this.tbAccBalance.Size = new System.Drawing.Size(100, 20);
            this.tbAccBalance.TabIndex = 1;
            this.tbAccBalance.Text = "Balance";
            // 
            // AccountsGroup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.AccountsGroupControlTabs);
            this.Name = "AccountsGroup";
            this.Size = new System.Drawing.Size(740, 200);
            this.gbaccounGroup.ResumeLayout(false);
            this.gbaccounGroup.PerformLayout();
            this.AccountsGroupControlTabs.ResumeLayout(false);
            this.accountPicker.ResumeLayout(false);
            this.accountCeator.ResumeLayout(false);
            this.accountCeator.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox AcSelTab_cbACcountsListSelector;
        private System.Windows.Forms.Label AcSelTab_lbTitle;
        private System.Windows.Forms.Label lbAccName;
        private System.Windows.Forms.Label lbAccBalance;
        private System.Windows.Forms.Label AcSelTab_lbAccComent;
        private System.Windows.Forms.Label lbAccDescription;
        private System.Windows.Forms.Button AcSelTab_bSelAccSubmit;
        private System.Windows.Forms.TextBox AcSelTab_tbHeader;
        private System.Windows.Forms.TextBox AcSelTab_tbAccbalanse;
        private System.Windows.Forms.TextBox tbAccName;
        private System.Windows.Forms.TextBox tbAccDescription;
        private System.Windows.Forms.TextBox tbAccBalance;
        private System.Windows.Forms.TextBox AcSelTab_tbAccComent;
        private System.Windows.Forms.GroupBox gbaccounGroup;
        private System.Windows.Forms.TabControl AccountsGroupControlTabs;
        private System.Windows.Forms.TabPage accountPicker;
        private System.Windows.Forms.TabPage accountCeator;
        private System.Windows.Forms.Button bAddAccount;
        private System.Windows.Forms.Label AcSelTab_lbAccBalance;
        //private System.Windows.Forms.Label lbAccBalance;
        //private System.Windows.Forms.Label lbAccBalance;
        //private System.Windows.Forms.Label lbAccName;
        //private System.Windows.Forms.TextBox tbAccName;
    }
}
