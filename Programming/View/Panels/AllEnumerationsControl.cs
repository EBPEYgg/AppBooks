namespace Programming.View
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, содержащий листбоксы с перечислением.
    /// </summary>
    public partial class AllEnumerationsControl : UserControl
    {
        public AllEnumerationsControl()
        {
            InitializeComponent();

            string[] enums = { nameof(Color), nameof(EducationForm), nameof(Genre), nameof(Manufactures), nameof(Season), nameof(Weekday) };

            // заполнение первого листбокса
            EnumsListBox.DataSource = enums;
            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();

            string enumeration = EnumsListBox.Text;
            Type? type = Type.GetType($"{enumeration}");
            var values = Enum.GetValues(type).Cast<object>().ToArray();
            ValuesListBox.Items.AddRange(values);

            ValueIntTextBox.Clear();
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueIntTextBox.Clear();
            var value = (int)ValuesListBox.SelectedItem;
            ValueIntTextBox.Text = value.ToString();
        }
    }
}
