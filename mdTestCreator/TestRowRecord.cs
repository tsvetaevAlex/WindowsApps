namespace mdTestCreator
{
    public partial class TestRowRecord : UserControl
    {

        public TestRowRecord()
        {
            InitializeComponent();
            CompleteRecord_ButttonClicked = () => { }; // Assigning a default no-op delegate
        }

        public TestRowRecord(int stepNumber)
        {
            this.stepsQTY = stepNumber;
            InitializeComponent();
            CompleteRecord_ButttonClicked = () => { }; // Assigning a default no-op delegate
        }

        private void AddNewRecord(Control parentContainer)
        {
            stepsQTY++;
            this.Name = $"Step{stepsQTY}";
            this.Location = new Point(10, 200 * stepsQTY);
            Numberlabel.Text =  stepsQTY.ToString();

            parentContainer.Controls.Add(this); // Добавляем текущий экземпляр на форму или в контейнер
        }

        public Action CompleteRecord_ButttonClicked { get; internal set; }
    }
}
