namespace mdTestCreator
{
    partial class AppForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox BoxTestname;
        private TextBox BoxDescription;
        private Button bStart;
        private TabControl tabs;
        private TabPage TestPage;
        private TabPage ReportPage;
        private Label mdExtendion;
        private TestRow customElement;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            customElement = new TestRow();

            // Подписка на события
            customElement.Custom_AddStepButton_ButttonClicked += Custom_AddStepButton_ButttonClicked;
            customElement.Custom_CompleteButton_ButttonClicked += Custom_CompleteButton_ButttonClicked;

            BoxTestname = new TextBox();
            BoxDescription = new TextBox();
            bStart = new Button();
            tabs = new TabControl();
            TestPage = new TabPage();
            mdExtendion = new Label();
            ReportPage = new TabPage();
            tabs.SuspendLayout();
            TestPage.SuspendLayout();
            SuspendLayout();

            // Инициализация и настройка элементов управления
            BoxTestname.BorderStyle = BorderStyle.Fixed3D;
            BoxTestname.Location = new Point(10, 10);
            BoxTestname.Name = "BoxTestname";
            BoxTestname.PlaceholderText = "Type here short test case name title(filename)";
            BoxTestname.Size = new Size(510, 23);
            BoxTestname.TabIndex = 0;

            BoxDescription.BorderStyle = BorderStyle.Fixed3D;
            BoxDescription.Location = new Point(10, 43);
            BoxDescription.Multiline = true;
            BoxDescription.Name = "BoxDescription";
            BoxDescription.PlaceholderText = "Type here short description what this test case will do.";
            BoxDescription.Size = new Size(510, 23);
            BoxDescription.TabIndex = 1;

            bStart.Location = new Point(570, 10);
            bStart.Name = "bStart";
            bStart.Size = new Size(80, 23);
            bStart.TabIndex = 2;
            bStart.Text = "Let`s Start";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;

            tabs.Controls.Add(TestPage);
            tabs.Controls.Add(ReportPage);
            tabs.Location = new Point(-9, 12);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(1000, 458);
            tabs.TabIndex = 4;

            TestPage.Controls.Add(customElement); // Добавляем customElement на форму
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

            customElement.Location = new Point(0, 72);
            customElement.Name = "customElement";
            customElement.Size = new Size(762, 85);
            customElement.TabIndex = 4;

            mdExtendion.AutoSize = true;
            mdExtendion.Location = new Point(530, 12);
            mdExtendion.Name = "mdExtendion";
            mdExtendion.Size = new Size(28, 15);
            mdExtendion.TabIndex = 3;
            mdExtendion.Text = ".md";

            ReportPage.Location = new Point(4, 24);
            ReportPage.Name = "ReportPage";
            ReportPage.Padding = new Padding(3);
            ReportPage.Size = new Size(992, 430);
            ReportPage.TabIndex = 1;
            ReportPage.Text = "ReportPage";
            ReportPage.UseVisualStyleBackColor = true;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(tabs);
            Name = "AppForm";
            Text = "msTestCreator";
            tabs.ResumeLayout(false);
            TestPage.ResumeLayout(false);
            TestPage.PerformLayout();
            ResumeLayout(false);
        }

        private void Custom_AddStepButton_ButttonClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Custom_AddStepButton_ButttonClicked", "main Application Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Custom_CompleteButton_ButttonClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Custom_CompleteButton_ButttonClicked", "main Application Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (BoxTestname.Text == string.Empty)
            {
                MessageBox.Show("Please input short test case name.(filename)", caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
