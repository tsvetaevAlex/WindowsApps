using static System.Net.Mime.MediaTypeNames;

namespace mdTestCreator
{
    partial class AppForm : Form
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox BoxTestname;
        private TextBox BoxDescription;
        private Button bStart;
        private TabControl tabs;
        private TabPage TestPage;
        private TabPage ReportPage;
        private Label mdExtendion;
        public static TestRowRecord PreviousTestRowRecord;
        private const string mainFormCaption = "main Application Form";
        public static int stepsQTY = 1;
        public static Point firstStepLocation = new Point();

        public AppForm()
        {
            InitializeComponent();
            InitializeCustomComponents();  // Move custom initialization here
        }

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

            // 
            // BoxTestname
            // 
            BoxTestname.Location = new Point(10, 10);
            BoxTestname.Name = "BoxTestname";
            BoxTestname.PlaceholderText = "Type here short test case name title (filename)";
            BoxTestname.Size = new Size(510, 23);
            BoxTestname.TabIndex = 0;

            // 
            // BoxDescription
            // 
            BoxDescription.Location = new Point(10, 43);
            BoxDescription.Multiline = true;
            BoxDescription.Name = "BoxDescription";
            BoxDescription.PlaceholderText = "Type here short description what this test case will do.";
            BoxDescription.Size = new Size(510, 23);
            BoxDescription.TabIndex = 1;

            // 
            // bStart
            // 
            bStart.Location = new Point(570, 10);
            bStart.Name = "bStart";
            bStart.Size = new Size(80, 23);
            bStart.TabIndex = 2;
            bStart.Text = "Let's Start";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;

            // 
            // tabs
            // 
            tabs.Controls.Add(TestPage);
            tabs.Controls.Add(ReportPage);
            tabs.Location = new Point(88, 43);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(1000, 458);
            tabs.TabIndex = 4;

            // 
            // TestPage
            // 
            TestPage.Controls.Add(BoxTestname);
            TestPage.Controls.Add(BoxDescription);
            TestPage.Controls.Add(bStart);
            TestPage.Controls.Add(mdExtendion);
            TestPage.Location = new Point(4, 24);
            TestPage.Name = "TestPage";
            TestPage.Padding = new Padding(3);
            TestPage.Size = new Size(992, 430);
            TestPage.TabIndex = 0;
            TestPage.Text = "TestPage";
            TestPage.UseVisualStyleBackColor = true;

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
            // AppForm
            // 
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

        private void InitializeCustomComponents()
        {
            PreviousTestRowRecord = new TestRowRecord();
            PreviousTestRowRecord.Location = new Point(0, 63);
            PreviousTestRowRecord.Size = new Size(762, 41);
            PreviousTestRowRecord.TabIndex = 4;

            TestPage.Controls.Add(PreviousTestRowRecord); // Add it to the form after initialization
        }

        private void Custom_AddStepButton_ButttonClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Custom_AddStepButton_ButttonClicked", mainFormCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            var steps = this.Controls.Find("step1", true);

            Console.WriteLine($"Steps count = {steps.Length}");

            TestRowRecord step2 = new TestRowRecord();
            step2.Location = new Point(41, 92);
            step2.Name = "label2";
            step2.Size = new Size(35, 13);
            step2.TabIndex = 1;
            Controls.Add(step2);
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxTestname.Text))
            {
                bStart.Enabled = false;
                MessageBox.Show("Please input short test case name.(filename)", mainFormCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bStart.Enabled = true;
                MessageBox.Show($"Path: {Environment.CurrentDirectory}", mainFormCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var steps = this.Controls.Find("testRow", true);
            Console.WriteLine($"TestRow elements QTY on panel: {steps.Length}");
        }
    }
}
