using System;
using System.Drawing;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    partial class MainForm
    {
        public event Action<int> AccountSelected;

        private System.ComponentModel.IContainer components = null;

        private Budgethelper.Controls.AccountsGroup accountsGroup;
        private Budgethelper.Controls.TransactionsGroup transactionsGroup;
        private RichTextBox rtbStatusBar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.accountsGroup = new Budgethelper.Controls.AccountsGroup();
            this.transactionsGroup = new Budgethelper.Controls.TransactionsGroup();
            this.rtbStatusBar = new System.Windows.Forms.RichTextBox();

            this.SuspendLayout();

            // =====================================================
            // MAIN FORM
            // =====================================================

            this.ClientSize = new Size(960, Screen.PrimaryScreen.WorkingArea.Height);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.Manual;
            this.Text = "BudgetHelper";
            this.Load += new EventHandler(this.MainForm_Load);

            // Центр по горизонтали, прижат к верху
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                0
            );

            // =====================================================
            // ACCOUNTS GROUP (верх)
            // =====================================================

            this.accountsGroup.Location = new Point(10, 10);
            this.accountsGroup.Name = "accountsGroup";
            this.accountsGroup.Size = new Size(940, 200);
            this.accountsGroup.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            // =====================================================
            // STATUS BAR (низ)
            // =====================================================

            this.rtbStatusBar.BackColor = Color.FromArgb(25, 25, 25);
            this.rtbStatusBar.BorderStyle = BorderStyle.FixedSingle;
            this.rtbStatusBar.Dock = DockStyle.Bottom;
            this.rtbStatusBar.Font = new Font("Consolas", 12F);
            this.rtbStatusBar.ForeColor = Color.WhiteSmoke;
            this.rtbStatusBar.Height = 40;
            this.rtbStatusBar.ReadOnly = true;
            this.rtbStatusBar.ScrollBars = RichTextBoxScrollBars.None;
            this.rtbStatusBar.TabStop = false;

            // =====================================================
            // TRANSACTIONS GROUP (между верхом и статусбаром)
            // =====================================================

            int topOffset = 220;     // 10 + 200 + 10
            int bottomOffset = 40;   // высота статус бара
            int calculatedHeight = this.ClientSize.Height - topOffset - bottomOffset;

            this.transactionsGroup.Location = new Point(10, topOffset);
            this.transactionsGroup.Name = "transactionsGroup";
            this.transactionsGroup.Size = new Size(940, calculatedHeight);
            this.transactionsGroup.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            // =====================================================
            // ADD CONTROLS
            // =====================================================

            this.Controls.Add(this.accountsGroup);
            this.Controls.Add(this.transactionsGroup);
            this.Controls.Add(this.rtbStatusBar);

            this.ResumeLayout(false);
        }
    }
}