

namespace mdTestCreator
{
    public partial class TestRowRecord : UserControl
    {
        public TestRowRecord()
        {
            InitializeComponent();
        }
        public TestRowRecord(int stepNumber)
        {
            InitializeCustomComponent(stepNumber);
        }

        public Action CompleteRecord_ButttonClicked { get; internal set; }

        private void TestPagePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BoxStep_TextChanged(object sender, EventArgs e)
        {
            stepAction = BoxStep.Text;
        }

        private void BoxExpected_TextChanged(object sender, EventArgs e)
        {
            stepExpectedResult = BoxExpected.Text;
        }
    }
}
