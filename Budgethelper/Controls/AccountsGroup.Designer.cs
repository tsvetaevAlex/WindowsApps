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
            this.cbACcountsListSelector = new System.Windows.Forms.ComboBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.bSelAccSubmit = new System.Windows.Forms.Button();
            this.tbHeader = new System.Windows.Forms.TextBox();
            this.tbAccbalanse = new System.Windows.Forms.TextBox();
            this.tbAccName = new System.Windows.Forms.TextBox();
            this.tbAccComent = new System.Windows.Forms.TextBox();
            this.lbAccName = new System.Windows.Forms.Label();
            this.lbAccBalance = new System.Windows.Forms.Label();
            this.lbAccComent = new System.Windows.Forms.Label();
            this.gbaccounGroup = new System.Windows.Forms.GroupBox();
            this.gbaccounGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbACcountsListSelector
            // 
            this.cbACcountsListSelector.FormattingEnabled = true;
            this.cbACcountsListSelector.Location = new System.Drawing.Point(20, 71);
            this.cbACcountsListSelector.Name = "cbACcountsListSelector";
            this.cbACcountsListSelector.Size = new System.Drawing.Size(550, 21);
            this.cbACcountsListSelector.TabIndex = 0;
            this.cbACcountsListSelector.TabStop = false;
            this.cbACcountsListSelector.Text = "choose account to work with";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(20, 50);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(233, 16);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "select account to add transactions into";
            // 
            // bSelAccSubmit
            // 
            this.bSelAccSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSelAccSubmit.Location = new System.Drawing.Point(580, 71);
            this.bSelAccSubmit.Name = "bSelAccSubmit";
            this.bSelAccSubmit.Size = new System.Drawing.Size(80, 23);
            this.bSelAccSubmit.TabIndex = 2;
            this.bSelAccSubmit.Text = "Выбрать";
            this.bSelAccSubmit.UseVisualStyleBackColor = true;
            // 
            // tbHeader
            // 
            this.tbHeader.Location = new System.Drawing.Point(20, 20);
            this.tbHeader.Name = "tbHeader";
            this.tbHeader.ReadOnly = true;
            this.tbHeader.Size = new System.Drawing.Size(630, 20);
            this.tbHeader.TabIndex = 3;
            this.tbHeader.Text = "Цветаева Ольга Александровна UID: ";
            // 
            // tbAccbalanse
            // 
            this.tbAccbalanse.Location = new System.Drawing.Point(180, 126);
            this.tbAccbalanse.Name = "tbAccbalanse";
            this.tbAccbalanse.ReadOnly = true;
            this.tbAccbalanse.Size = new System.Drawing.Size(100, 20);
            this.tbAccbalanse.TabIndex = 4;
            this.tbAccbalanse.Text = "999 000 000 000";
            // 
            // tbAccName
            // 
            this.tbAccName.Location = new System.Drawing.Point(20, 126);
            this.tbAccName.Name = "tbAccName";
            this.tbAccName.ReadOnly = true;
            this.tbAccName.Size = new System.Drawing.Size(150, 20);
            this.tbAccName.TabIndex = 8;
            this.tbAccName.Text = "accName";
            // 
            // tbAccComent
            // 
            this.tbAccComent.Location = new System.Drawing.Point(290, 126);
            this.tbAccComent.Name = "tbAccComent";
            this.tbAccComent.ReadOnly = true;
            this.tbAccComent.Size = new System.Drawing.Size(180, 20);
            this.tbAccComent.TabIndex = 7;
            this.tbAccComent.Text = "AccDrscrition";
            // 
            // lbAccName
            // 
            this.lbAccName.AutoSize = true;
            this.lbAccName.Location = new System.Drawing.Point(20, 108);
            this.lbAccName.Name = "lbAccName";
            this.lbAccName.Size = new System.Drawing.Size(78, 13);
            this.lbAccName.TabIndex = 9;
            this.lbAccName.Text = "Account Name";
            // 
            // lbAccBalance
            // 
            this.lbAccBalance.AutoSize = true;
            this.lbAccBalance.Location = new System.Drawing.Point(180, 108);
            this.lbAccBalance.Name = "lbAccBalance";
            this.lbAccBalance.Size = new System.Drawing.Size(89, 13);
            this.lbAccBalance.TabIndex = 11;
            this.lbAccBalance.Text = "текущий баланс";
            // 
            // lbAccComent
            // 
            this.lbAccComent.AutoSize = true;
            this.lbAccComent.Location = new System.Drawing.Point(290, 108);
            this.lbAccComent.Name = "lbAccComent";
            this.lbAccComent.Size = new System.Drawing.Size(133, 13);
            this.lbAccComent.TabIndex = 12;
            this.lbAccComent.Text = "комментарий к аккаунту";
            // 
            // gbaccounGroup
            // 
            this.gbaccounGroup.Controls.Add(this.tbHeader);
            this.gbaccounGroup.Controls.Add(this.lbAccComent);
            this.gbaccounGroup.Controls.Add(this.cbACcountsListSelector);
            this.gbaccounGroup.Controls.Add(this.lbAccBalance);
            this.gbaccounGroup.Controls.Add(this.lbTitle);
            this.gbaccounGroup.Controls.Add(this.lbAccName);
            this.gbaccounGroup.Controls.Add(this.bSelAccSubmit);
            this.gbaccounGroup.Controls.Add(this.tbAccName);
            this.gbaccounGroup.Controls.Add(this.tbAccbalanse);
            this.gbaccounGroup.Controls.Add(this.tbAccComent);
            this.gbaccounGroup.Location = new System.Drawing.Point(10, 10);
            this.gbaccounGroup.Name = "gbaccounGroup";
            this.gbaccounGroup.Size = new System.Drawing.Size(740, 180);
            this.gbaccounGroup.TabIndex = 13;
            this.gbaccounGroup.TabStop = false;
            this.gbaccounGroup.Text = "выбор Аккаунта для работы с транзакциями";
            // 
            // AccountsGroup
            // 
            this.Controls.Add(this.gbaccounGroup);
            this.Name = "AccountsGroup";
            this.Size = new System.Drawing.Size(760, 200);
            this.gbaccounGroup.ResumeLayout(false);
            this.gbaccounGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox cbACcountsListSelector;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button bSelAccSubmit;
        private System.Windows.Forms.TextBox tbHeader;
        private System.Windows.Forms.TextBox tbAccbalanse;
        private System.Windows.Forms.TextBox tbAccName;
        private System.Windows.Forms.TextBox tbAccComent;
        private System.Windows.Forms.Label lbAccName;
        private System.Windows.Forms.Label lbAccBalance;
        private System.Windows.Forms.Label lbAccComent;
        private System.Windows.Forms.GroupBox gbaccounGroup;
    }
}
