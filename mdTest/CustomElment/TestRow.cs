
namespace mdTest.CustomElment
{
    public partial class TestRow : UserControl
    {
        public EventHandler Custom_addStep_buttonClicked;
        public EventHandler Custom_Complete_buttonClicked;



        public TestRow() => InitializeComponent();

        private void StepBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Expectedbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("inside Custom Add button click", "Custom Control Invoke", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FromCustom_AddStep_ButttonClicked?.Invoke(this, e);
        }

        private void bComplete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("inside Custom Complete button click", "Custom Control Invoke", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FromCustom_Complete_ButttonClicked?.Invoke(this, e);
        }

        private void TestRow_Load(object sender, EventArgs e)
        {
        }
    }
}