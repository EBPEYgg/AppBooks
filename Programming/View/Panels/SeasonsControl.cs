namespace Programming.View
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, содержащий SeasonHandleGroupBox.
    /// </summary>
    public partial class SeasonsControl : UserControl
    {
        public SeasonsControl()
        {
            InitializeComponent();

            // заполнение SeasonComboBox
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonComboBox.SelectedIndex = 0;
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            switch (Enum.Parse(typeof(Season), SeasonComboBox.Text))
            {
                case Season.Winter:
                    GoButton.BackColor = System.Drawing.Color.LightCyan;
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Spring:
                    GoButton.BackColor = System.Drawing.Color.LightGreen;
                    break;
                case Season.Summer:
                    GoButton.BackColor = System.Drawing.Color.White;
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    GoButton.BackColor = ColorTranslator.FromHtml("#EFC050");
                    break;
            }
        }
    }
}