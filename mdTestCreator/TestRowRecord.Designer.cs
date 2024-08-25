namespace mdTestCreator
{
    partial class TestRowRecord : UserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public event EventHandler Custom_AddStepButton_ButtonClicked;
        
        public event EventHandler Custom_CompleteButton_ButttonClicked;

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
            //MessageBox.Show("Custom_Control bAdd_Click", "Custom element", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Custom_AddStepButton_ButtonClicked?.Invoke(sender, e);
        }

        private void bComplete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Custom_Control CompleteRecord_ButttonClicked", "Custom element", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Custom_CompleteButton_ButttonClicked?.Invoke(sender, e);
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
            SuspendLayout();
            // 
            // stepNumber
            // 
            stepNumber.AutoSize = true;
            stepNumber.Location = new Point(10, 10);
            stepNumber.Name = "stepNumber";
            stepNumber.Size = new Size(13, 15);
            stepNumber.TabIndex = 0;
            stepNumber.Text = "1";
            // 
            // BoxStep
            // 
            BoxStep.Location = new Point(33, 10);
            BoxStep.Name = "BoxStep";
            BoxStep.PlaceholderText = "Type here short step description";
            BoxStep.Size = new Size(220, 23);
            BoxStep.TabIndex = 1;
            // 
            // BoxExpected
            // 
            BoxExpected.Location = new Point(263, 10);
            BoxExpected.Name = "BoxExpected";
            BoxExpected.PlaceholderText = "Type here short expected result description";
            BoxExpected.Size = new Size(260, 23);
            BoxExpected.TabIndex = 2;
            // 
            // bAdd
            // 
            bAdd.FlatStyle = FlatStyle.Flat;
            bAdd.Location = new Point(533, 10);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(80, 23);
            bAdd.TabIndex = 3;
            bAdd.Text = "добавить";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // bComplete
            // 
            bComplete.FlatStyle = FlatStyle.Flat;
            bComplete.Location = new Point(623, 10);
            bComplete.Name = "bComplete";
            bComplete.Size = new Size(80, 23);
            bComplete.TabIndex = 4;
            bComplete.Text = "Закончить";
            bComplete.UseVisualStyleBackColor = true;
            bComplete.Click += bComplete_Click;
            // 
            // TestRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bComplete);
            Controls.Add(bAdd);
            Controls.Add(BoxExpected);
            Controls.Add(BoxStep);
            Controls.Add(stepNumber);
            Name = "TestRow";
            Size = new Size(710, 42);
            ResumeLayout(false);
            PerformLayout();
        }

        private void InitializeCustomComponent(int rowNumber)
        {
            stepNumber = new Label();
            BoxStep = new TextBox();
            BoxExpected = new TextBox();
            bAdd = new Button();
            bComplete = new Button();
            SuspendLayout();
            // 
            // stepNumber
            // 
            stepNumber.AutoSize = true;
            stepNumber.Location = new Point(10, 10);
            stepNumber.Name = "stepNumber";
            stepNumber.Size = new Size(13, 15);
            stepNumber.TabIndex = 0;
            stepNumber.Text = stepNumber.ToString();
            // 
            // BoxStep
            // 
            BoxStep.Location = new Point(33, 10);
            BoxStep.Name = "BoxStep";
            BoxStep.PlaceholderText = "Type here short step description";
            BoxStep.Size = new Size(220, 23);
            BoxStep.TabIndex = 1;
            // 
            // BoxExpected
            // 
            BoxExpected.Location = new Point(263, 10);
            BoxExpected.Name = "BoxExpected";
            BoxExpected.PlaceholderText = "Type here short expected result description";
            BoxExpected.Size = new Size(260, 23);
            BoxExpected.TabIndex = 2;
            // 
            // bAdd
            // 
            bAdd.FlatStyle = FlatStyle.Flat;
            bAdd.Location = new Point(533, 10);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(80, 23);
            bAdd.TabIndex = 3;
            bAdd.Text = "добавить";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // bComplete
            // 
            bComplete.FlatStyle = FlatStyle.Flat;
            bComplete.Location = new Point(623, 10);
            bComplete.Name = "bComplete";
            bComplete.Size = new Size(80, 23);
            bComplete.TabIndex = 4;
            bComplete.Text = "Закончить";
            bComplete.UseVisualStyleBackColor = true;
            bComplete.Click += bComplete_Click;
            // 
            // TestRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bComplete);
            Controls.Add(bAdd);
            Controls.Add(BoxExpected);
            Controls.Add(BoxStep);
            Controls.Add(stepNumber);
            Name = "TestRow";
            Size = new Size(710, 42);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label stepNumber;
        private TextBox BoxStep;
        private TextBox BoxExpected;
        private Button bAdd;
        private Button bComplete;
    }
}
