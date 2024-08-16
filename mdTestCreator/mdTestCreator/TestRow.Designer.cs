namespace mdTestCreator
{
    partial class TestRow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            stepNumber.Location = new Point(11, 9);
            stepNumber.Name = "stepNumber";
            stepNumber.Size = new Size(13, 15);
            stepNumber.TabIndex = 0;
            stepNumber.Text = "1";
            // 
            // BoxStep
            // 
            BoxStep.Location = new Point(30, 5);
            BoxStep.Name = "BoxStep";
            BoxStep.PlaceholderText = "Type here short step description";
            BoxStep.Size = new Size(220, 23);
            BoxStep.TabIndex = 1;
            // 
            // BoxExpected
            // 
            BoxExpected.Location = new Point(260, 5);
            BoxExpected.Name = "BoxExpected";
            BoxExpected.PlaceholderText = "Type here short expected result description";
            BoxExpected.Size = new Size(260, 23);
            BoxExpected.TabIndex = 2;
            // 
            // bAdd
            // 
            bAdd.FlatStyle = FlatStyle.Flat;
            bAdd.Location = new Point(542, 5);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 23);
            bAdd.TabIndex = 3;
            bAdd.Text = "Add Step";
            bAdd.UseVisualStyleBackColor = true;
            // 
            // bComplete
            // 
            bComplete.FlatStyle = FlatStyle.Flat;
            bComplete.Location = new Point(623, 5);
            bComplete.Name = "bComplete";
            bComplete.Size = new Size(75, 23);
            bComplete.TabIndex = 4;
            bComplete.Text = "button2";
            bComplete.UseVisualStyleBackColor = true;
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
            Size = new Size(707, 36);
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
