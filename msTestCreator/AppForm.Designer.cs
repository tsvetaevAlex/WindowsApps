using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
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
            UserPanel.Controls.Add(FirstTestRow);
            ResumeLayout();
            PerformLayout();
            if (isFirst)
            {
                isFirst = false;
            }
            CurrentTestRow = FirstTestRow;
            CurrentTestRow.Custom_AddStepButton_ButtonClicked += Custom_AddStepButton_ButtonClicked;
            CurrentTestRow.Custom_CompleteButton_ButttonClicked += Custom_CompleteButton_ButttonClicked;

        }

        private void InitializeComponent()
        {
            BoxTestname = new TextBox();
            BoxDescription = new TextBox();
            mdExtendion = new Label();
            bStart = new Button();
            boxTestNumber = new TextBox();
            UserPanel = new Panel();
            UserPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BoxTestname
            // 
            BoxTestname.Location = new Point(61, 6);
            BoxTestname.Name = "BoxTestname";
            BoxTestname.PlaceholderText = "Type here short test case name title(filename)";
            BoxTestname.Size = new Size(460, 23);
            BoxTestname.TabIndex = 0;
            BoxTestname.TextChanged += BoxTestname_TextChanged;
            // 
            // BoxDescription
            // 
            BoxDescription.Location = new Point(14, 35);
            BoxDescription.Multiline = true;
            BoxDescription.Name = "BoxDescription";
            BoxDescription.PlaceholderText = "Type here short description what this test case will do.";
            BoxDescription.Size = new Size(510, 23);
            BoxDescription.TabIndex = 1;
            // 
            // mdExtendion
            // 
            mdExtendion.AutoSize = true;
            mdExtendion.Location = new Point(531, 11);
            mdExtendion.Name = "mdExtendion";
            mdExtendion.Size = new Size(28, 15);
            mdExtendion.TabIndex = 3;
            mdExtendion.Text = ".md";
            // 
            // bStart
            // 
            bStart.Location = new Point(571, 6);
            bStart.Name = "bStart";
            bStart.Size = new Size(107, 23);
            bStart.TabIndex = 2;
            bStart.Text = "Начать работу";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
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
            // UserPanel
            // 
            UserPanel.Controls.Add(BoxTestname);
            UserPanel.Controls.Add(BoxDescription);
            UserPanel.Controls.Add(bStart);
            UserPanel.Controls.Add(mdExtendion);
            UserPanel.Location = new Point(-6, -2);
            UserPanel.Name = "UserPanel";
            UserPanel.Size = new Size(711, 862);
            UserPanel.TabIndex = 5;
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 861);
            Controls.Add(UserPanel);
            Name = "AppForm";
            Text = "mdTestCreator ver 1.0";
            UserPanel.ResumeLayout(false);
            UserPanel.PerformLayout();
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
            UserPanel.SuspendLayout();
            stepsQTY++;
            TestRowRecord newStepRow = new TestRowRecord();
            Controls.Add(newStepRow);
            int xPosition = CurrentTestRow.Location.X;
            int NewRowYposition = CurrentTestRow.Location.Y + CurrentTestRow.Height + indent;
            UserPanel.Controls.Add(newStepRow);
            newStepRow.Location = new Point(CurrentTestRow.Location.X, NewRowYposition);
            CurrentTestRow = newStepRow;
            ResumeLayout(true);
            UserPanel.PerformLayout();
            newStepRow.SetRowNumber(stepsQTY);
            newStepRow.Size = new Size(700, 32);
            newStepRow.Custom_AddStepButton_ButtonClicked += Custom_AddStepButton_ButtonClicked;
            newStepRow.Custom_CompleteButton_ButttonClicked += Custom_CompleteButton_ButttonClicked;

            // Scroll to bottom
            UserPanel.VerticalScroll.Value = UserPanel.VerticalScroll.Maximum;
            UserPanel.PerformLayout();  // Ensure the layout is updated

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
        private TextBox boxTestNumber;
        private TextBox BoxTestname;
        private TextBox BoxDescription;
        private Label mdExtendion;
        private Button bStart;
        private Panel UserPanel;
    }
}
