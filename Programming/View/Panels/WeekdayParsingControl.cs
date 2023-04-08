namespace Programming.View
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, содержащий WeekdayParsingGroupBox
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday text;
            if (Enum.TryParse(ParseTextBox.Text, out text) && text >= 0)
            {
                ResultParsingLabel.Text = $"Это день недели ({text} = {(int)text})";
            }
            else
            {
                ResultParsingLabel.Text = $"Это не день недели!";
            }
            ResultParsingLabel.Visible = true;
        }
    }
}
