using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace mdTestCreator
{
    partial class AppForm : Form
    {
        private System.ComponentModel.IContainer components = null;
        private static TestRowRecord FirstTestRow = new TestRowRecord();
        public static TestRowRecord CurrentTestRow;

        //private static SqlWrapper sql_wrapper = new SqlWrapper();
        //private static MySqlConnection SqlConnection = null;
        public static int stepsQTY = 1;
        private const int indent = 10;
        public static readonly string testFolder = "TestCaseFolder";
        public static readonly string FileEextension = ".md";
        public static bool isFirst = true;
        public static string testFileName = string.Empty;
        private const string mainFormCaption = "message from main Form";
        private const string mainFormExceptiton = "Exception message from main Form";
        private static MdWriter mdWriter;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void AddFirstSTepRow()
        {
            //LogsBox.Text += $"AddFirstSTepRow{Environment.NewLine}";
            //MessageBox.Show("we are inside InitFirstSTepRow", "mainform", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SuspendLayout();
            FirstTestRow.SetRowNumber(number: stepsQTY);
            FirstTestRow.Location = new Point(10, 76);
            FirstTestRow.Size = new Size(700, 32);
            FirstTestRow.TabIndex = 4;
            Controls.Add(FirstTestRow);
            TestPage.Controls.Add(FirstTestRow);
            ResumeLayout();
            PerformLayout();
            if (isFirst)
            {
                isFirst = false;
                stepsQTY ++;
            }
            CurrentTestRow = FirstTestRow;
            CurrentTestRow.Custom_AddStepButton_ButtonClicked += Custom_AddStepButton_ButtonClicked;
            CurrentTestRow.Custom_CompleteButton_ButttonClicked += Custom_CompleteButton_ButttonClicked;

        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TestPage = new TabPage();
            boxTestNumber = new TextBox();
            BoxTestname = new TextBox();
            BoxDescription = new TextBox();
            mdExtendion = new Label();
            bStart = new Button();
            tabs = new TabControl();
            contextMenuStrip1 = new ContextMenuStrip(components);
            TestPage.SuspendLayout();
            tabs.SuspendLayout();
            SuspendLayout();
            // 
            // TestPage
            // 
            TestPage.AutoScroll = true;
            TestPage.BackColor = Color.Transparent;
            TestPage.Controls.Add(BoxTestname);
            TestPage.Controls.Add(BoxDescription);
            TestPage.Controls.Add(mdExtendion);
            TestPage.Controls.Add(bStart);
            TestPage.Location = new Point(4, 24);
            TestPage.Name = "TestPage";
            TestPage.Padding = new Padding(3);
            TestPage.Size = new Size(652, 730);
            TestPage.TabIndex = 0;
            TestPage.Text = "TestPage";
            // 
            // boxTestNumber
            // 
            boxTestNumber.BorderStyle = BorderStyle.FixedSingle;
            boxTestNumber.Enabled = false;
            boxTestNumber.Location = new Point(10, 10);
            boxTestNumber.Name = "boxTestNumber";
            boxTestNumber.Size = new Size(40, 23);
            boxTestNumber.TabIndex = 4;
            // 
            // BoxTestname
            // 
            BoxTestname.Location = new Point(60, 10);
            BoxTestname.Name = "BoxTestname";
            BoxTestname.PlaceholderText = "Type here short test case name title(filename)";
            BoxTestname.Size = new Size(460, 23);
            BoxTestname.TabIndex = 0;
            BoxTestname.TextChanged += BoxTestname_TextChanged;
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
            // mdExtendion
            // 
            mdExtendion.AutoSize = true;
            mdExtendion.Location = new Point(530, 15);
            mdExtendion.Name = "mdExtendion";
            mdExtendion.Size = new Size(28, 15);
            mdExtendion.TabIndex = 3;
            mdExtendion.Text = ".md";
            // 
            // bStart
            // 
            bStart.Location = new Point(570, 10);
            bStart.Name = "bStart";
            bStart.Size = new Size(80, 23);
            bStart.TabIndex = 2;
            bStart.Text = "Let`s Start";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // tabs
            // 
            tabs.Controls.Add(TestPage);
            tabs.Location = new Point(10, 10);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(660, 758);
            tabs.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 768);
            Controls.Add(tabs);
            Name = "AppForm";
            Text = "mdTestCreator ver 1.0";
            TestPage.ResumeLayout(false);
            TestPage.PerformLayout();
            tabs.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void Custom_AddStepButton_ButtonClicked(object sender, EventArgs e)
        {
            try
            {
                mdWriter.Appendline(CurrentTestRow);
            }
            catch (Exception ex)
            { 
                MessageBox.Show($"sorry data record to file failed. Exception: {ex.Message}; at AppForm.Designer.line 172", mainFormCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TestPage.SuspendLayout();
            stepsQTY++;
            TestRowRecord newStepRow = new TestRowRecord();
            Controls.Add(newStepRow);
            int xPosition = CurrentTestRow.Location.X;
            int NewRowYposition = CurrentTestRow.Location.Y + CurrentTestRow.Height + indent;
            TestPage.Controls.Add(newStepRow);
            newStepRow.Location = new Point(CurrentTestRow.Location.X, NewRowYposition);
            CurrentTestRow = newStepRow;
            ResumeLayout(true);
            TestPage.PerformLayout();
            newStepRow.SetRowNumber(stepsQTY);
            newStepRow.Size = new Size(700, 32);
            newStepRow.Custom_AddStepButton_ButtonClicked += Custom_AddStepButton_ButtonClicked;
            newStepRow.Custom_CompleteButton_ButttonClicked += Custom_CompleteButton_ButttonClicked;

            // Scroll to bottom
            TestPage.VerticalScroll.Value = TestPage.VerticalScroll.Maximum;
            TestPage.PerformLayout();  // Ensure the layout is updated

        }
        private void Custom_CompleteButton_ButttonClicked(object sender, EventArgs e)
        {
            mdWriter.Appendline(CurrentTestRow);
            System.Windows.Forms.Application.Exit();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            Header header = new Header(BoxTestname.Text, BoxDescription.Text);
            mdWriter = new MdWriter();
            mdWriter.AddHeader();
            AddFirstSTepRow();
        }// end of bStart_Click

        private TabPage TestPage;
        private TextBox boxTestNumber;
        private TextBox BoxTestname;
        private TextBox BoxDescription;
        private Label mdExtendion;
        private Button bStart;
        private TabControl tabs;
        private ContextMenuStrip contextMenuStrip1;
    }
}
