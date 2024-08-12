namespace mdTest
{
    partial class TestcaseRow
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
            testStep = new TextBox();
            ExpectedResult = new TextBox();
            AddRow = new Button();
            Numberlabel = new Label();
            SuspendLayout();
            // 
            // testStep
            // 
            testStep.Location = new Point(25, 3);
            testStep.Name = "testStep";
            testStep.PlaceholderText = "Step Action";
            testStep.Size = new Size(100, 23);
            testStep.TabIndex = 0;
            // 
            // ExpectedResult
            // 
            ExpectedResult.Location = new Point(131, 3);
            ExpectedResult.Name = "ExpectedResult";
            ExpectedResult.PlaceholderText = "Enter expected Result";
            ExpectedResult.Size = new Size(100, 23);
            ExpectedResult.TabIndex = 1;
            // 
            // AddRow
            // 
            AddRow.Location = new Point(235, 6);
            AddRow.Name = "buttonAdd";
            AddRow.Size = new Size(92, 23);
            AddRow.TabIndex = 2;
            AddRow.Text = "Submit Record";
            AddRow.UseVisualStyleBackColor = true;
            // 
            // Numberlabel
            // 
            Numberlabel.AutoSize = true;
            Numberlabel.Location = new Point(6, 9);
            Numberlabel.Name = "Numberlabel";
            Numberlabel.Size = new Size(13, 15);
            Numberlabel.TabIndex = 3;
            Numberlabel.Text = "1";
            // 
            // TestcaseRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Numberlabel);
            Controls.Add(AddRow);
            Controls.Add(ExpectedResult);
            Controls.Add(testStep);
            Name = "TestcaseRow";
            Size = new Size(335, 34);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox testStep;
        private TextBox ExpectedResult;
        private Button AddRow;
        private Label Numberlabel;
    }
}
