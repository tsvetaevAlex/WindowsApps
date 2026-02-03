namespace Budgethelper.Controls
{
    partial class AccountsGroup
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListBox listAccounts;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRur;
        private System.Windows.Forms.TabPage tabUsd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listAccounts = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRur = new System.Windows.Forms.TabPage();
            this.tabUsd = new System.Windows.Forms.TabPage();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();

            // listAccounts
            this.listAccounts.FormattingEnabled = true;
            this.listAccounts.ItemHeight = 16;
            this.listAccounts.Location = new System.Drawing.Point(10, 10);
            this.listAccounts.Name = "listAccounts";
            this.listAccounts.Size = new System.Drawing.Size(250, 260);
            this.listAccounts.TabIndex = 0;
            this.listAccounts.SelectedIndexChanged +=
                new System.EventHandler(this.listAccounts_SelectedIndexChanged);

            // tabControl1
            this.tabControl1.Controls.Add(this.tabRur);
            this.tabControl1.Controls.Add(this.tabUsd);
            this.tabControl1.Location = new System.Drawing.Point(270, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(260, 200);
            this.tabControl1.TabIndex = 1;

            // tabRur
            this.tabRur.Location = new System.Drawing.Point(4, 25);
            this.tabRur.Name = "tabRur";
            this.tabRur.Padding = new System.Windows.Forms.Padding(10);
            this.tabRur.Size = new System.Drawing.Size(252, 171);
            this.tabRur.Text = "RUR";
            this.tabRur.UseVisualStyleBackColor = true;

            // tabUsd
            this.tabUsd.Location = new System.Drawing.Point(4, 25);
            this.tabUsd.Name = "tabUsd";
            this.tabUsd.Padding = new System.Windows.Forms.Padding(10);
            this.tabUsd.Size = new System.Drawing.Size(252, 171);
            this.tabUsd.Text = "USD";
            this.tabUsd.UseVisualStyleBackColor = true;

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(270, 220);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(93, 16);
            this.lblName.Text = "Account Name";

            // txtName
            this.txtName.Location = new System.Drawing.Point(270, 240);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 22);
            this.txtName.TabIndex = 2;

            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(270, 270);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.Text = "Description";

            // txtDescription
            this.txtDescription.Location = new System.Drawing.Point(270, 290);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(260, 22);
            this.txtDescription.TabIndex = 3;

            // btnCreate
            this.btnCreate.Location = new System.Drawing.Point(270, 320);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(260, 35);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click +=
                new System.EventHandler(this.btnCreate_Click);

            // AccountsGroup
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listAccounts);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnCreate);
            this.Name = "AccountsGroup";
            this.Size = new System.Drawing.Size(550, 370);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
