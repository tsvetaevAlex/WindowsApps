namespace mdTestCreator
{
    partial class TestRowRecord : UserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public int stepsQTY =1;

        public event EventHandler Custom_AddStepButton_ButtonClicked;
        public event EventHandler Custom_CompleteButton_ButtonClicked;
        public static TestRowRecord firstRecord = AppForm.PreviousTestRowRecord;
        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code
        private void bAdd_Click(object sender, EventArgs e)
        {
            stepsQTY++;
            TestRowRecord NewStep = new TestRowRecord();
            NewStep.Name = $"step{stepsQTY}";
            int firstWidth = AppForm.PreviousTestRowRecord.Width;
            int firstHeight = AppForm.PreviousTestRowRecord.Height;
            int firstLocationY = AppForm.PreviousTestRowRecord.Location.Y;
            int firstLocationX = AppForm.PreviousTestRowRecord.Location.X;
            int newY = firstLocationY + firstHeight * stepsQTY + 10;
            NewStep.Location = new System.Drawing.Point(firstLocationX, newY);

            Custom_AddStepButton_ButtonClicked?.Invoke(sender, e);

            Controls.Add(NewStep);
        }

        private void bComplete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Custom_Control CompleteRecord_ButttonClicked", "Custom element", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Custom_CompleteButton_ButtonClicked?.Invoke(sender, e);
        }
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            stepNumber = new Label();
            BoxStep = new TextBox();
            BoxExpected = new TextBox();
            bAdd = new Button();
            bComplete = new Button();
            Numberlabel = new Label();
            SuspendLayout();
            // 
            // stepNumber
            // 
            stepNumber.AutoSize = true;
            stepNumber.Location = new Point(11, 10);
            stepNumber.Name = "stepNumber";
            stepNumber.Size = new Size(0, 15);
            stepNumber.TabIndex = 0;
            // 
            // BoxStep
            // 
            BoxStep.Location = new Point(28, 10);
            BoxStep.Name = "BoxStep";
            BoxStep.PlaceholderText = "Type here short step description";
            BoxStep.Size = new Size(220, 23);
            BoxStep.TabIndex = 1;
            // 
            // BoxExpected
            // 
            BoxExpected.Location = new Point(258, 10);
            BoxExpected.Name = "BoxExpected";
            BoxExpected.PlaceholderText = "Type here short expected result description";
            BoxExpected.Size = new Size(260, 23);
            BoxExpected.TabIndex = 2;
            // 
            // bAdd
            // 
            bAdd.FlatStyle = FlatStyle.Flat;
            bAdd.Location = new Point(528, 9);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(80, 23);
            bAdd.TabIndex = 3;
            bAdd.Text = "Add Step.";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // bComplete
            // 
            bComplete.FlatStyle = FlatStyle.Flat;
            bComplete.Location = new Point(618, 10);
            bComplete.Name = "bComplete";
            bComplete.Size = new Size(75, 23);
            bComplete.TabIndex = 4;
            bComplete.Text = "Complete test case";
            bComplete.UseVisualStyleBackColor = true;
            bComplete.Click += bComplete_Click;
            // 
            // Numberlabel
            // 
            Numberlabel.AutoSize = true;
            Numberlabel.Location = new Point(5, 13);
            Numberlabel.Name = "Numberlabel";
            Numberlabel.Size = new Size(13, 15);
            Numberlabel.TabIndex = 5;
            Numberlabel.Text = "1";
            // 
            // TestRowRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Numberlabel);
            Controls.Add(bComplete);
            Controls.Add(bAdd);
            Controls.Add(BoxExpected);
            Controls.Add(BoxStep);
            Controls.Add(stepNumber);
            Name = "TestRowRecord";
            Size = new Size(700, 42);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label stepNumber;
        private TextBox BoxStep;
        private TextBox BoxExpected;
        private Button bAdd;
        private Button bComplete;
        private Label Numberlabel;
    }
}
