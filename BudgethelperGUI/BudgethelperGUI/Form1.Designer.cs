using System;
using System.Windows.Forms;

namespace BudgethelperGUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private RichTextBox rtbFooter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.rtbFooter = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbFooter
            // 
            this.rtbFooter.BackColor = this.BackColor;
            this.rtbFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbFooter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFooter.ForeColor = System.Drawing.Color.White;
            this.rtbFooter.Location = new System.Drawing.Point(0, 705);
            this.rtbFooter.Name = "rtbFooter";
            this.rtbFooter.ReadOnly = true;
            this.rtbFooter.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbFooter.Size = new System.Drawing.Size(1008, 24);
            this.rtbFooter.TabIndex = 0;
            this.rtbFooter.Text = "";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.rtbFooter);
            this.Name = "MainForm";
            this.Text = "BudgetHelper v1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }
    }
}
