

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
    }
}
