namespace mdTestCreator
{
    partial class AppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BoxTestname = new TextBox();
            BoxDescription = new TextBox();
            bStart = new Button();
            tabControl1 = new TabControl();
            TestPage = new TabPage();
            ReportPage = new TabPage();
            mdExtendion = new Label();
            tabControl1.SuspendLayout();
            TestPage.SuspendLayout();
            SuspendLayout();
            // 
            // BoxTestname
            // 
            BoxTestname.BorderStyle = BorderStyle.FixedSingle;
            BoxTestname.Location = new Point(10, 10);
            BoxTestname.Name = "BoxTestname";
            BoxTestname.Size = new Size(510, 23);
            BoxTestname.TabIndex = 0;
            // 
            // BoxDescription
            // 
            BoxDescription.BorderStyle = BorderStyle.FixedSingle;
            BoxDescription.Location = new Point(10, 43);
            BoxDescription.Multiline = true;
            BoxDescription.Name = "BoxDescription";
            BoxDescription.Size = new Size(510, 23);
            BoxDescription.TabIndex = 1;
            // 
            // bStart
            // 
            bStart.Location = new Point(564, 10);
            bStart.Name = "bStart";
            bStart.Size = new Size(80, 23);
            bStart.TabIndex = 2;
            bStart.Text = "Ley`s Start";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TestPage);
            tabControl1.Controls.Add(ReportPage);
            tabControl1.Location = new Point(-9, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1000, 458);
            tabControl1.TabIndex = 4;
            // 
            // TestPage
            // 
            TestPage.Controls.Add(mdExtendion);
            TestPage.Controls.Add(BoxTestname);
            TestPage.Controls.Add(BoxDescription);
            TestPage.Controls.Add(bStart);
            TestPage.Location = new Point(4, 24);
            TestPage.Name = "TestPage";
            TestPage.Padding = new Padding(3);
            TestPage.Size = new Size(992, 430);
            TestPage.TabIndex = 0;
            TestPage.Text = "TestPage";
            TestPage.UseVisualStyleBackColor = true;
            // 
            // ReportPage
            // 
            ReportPage.Location = new Point(4, 24);
            ReportPage.Name = "ReportPage";
            ReportPage.Padding = new Padding(3);
            ReportPage.Size = new Size(992, 430);
            ReportPage.TabIndex = 1;
            ReportPage.Text = "ReportPage";
            ReportPage.UseVisualStyleBackColor = true;
            // 
            // mdExtendion
            // 
            mdExtendion.AutoSize = true;
            mdExtendion.Location = new Point(530, 12);
            mdExtendion.Name = "mdExtendion";
            mdExtendion.Size = new Size(28, 15);
            mdExtendion.TabIndex = 3;
            mdExtendion.Text = ".md";
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(tabControl1);
            Name = "AppForm";
            Text = "msTestCreator";
            tabControl1.ResumeLayout(false);
            TestPage.ResumeLayout(false);
            TestPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox BoxTestname;
        private TextBox BoxDescription;
        private Button bStart;
        private TabControl tabControl1;
        private TabPage TestPage;
        private TabPage ReportPage;
        private Label mdExtendion;
    }
}
