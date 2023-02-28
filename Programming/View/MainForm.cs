using System;
using System.Windows.Forms;
using Programming.Model.Classes;
using Programming.Model.Enums;

namespace Programming
{
    public partial class MainForm : Form
    {
        private string[]? _rectangles;
        private string? _currentRectangle;

        private int FindRectangleWithMaxWidth(string[] rectangle)
        {

            return 1;
        }
        public MainForm()
        {
            InitializeComponent();

            string[] enums = { "Color", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" };          
            EnumsListBox.DataSource = enums;
            EnumsListBox.SelectedIndex = 0;

            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonComboBox.SelectedIndex = 0;

            //Programming.Model.Classes.Rectangle rectangle = new Programming.Model.Classes.Rectangle();
            //Film film = new Film("Not comedy", 102, 2011, "Comedy", 7.0);
            string[] _rectangles = new string[RectanglesListBox.Items.Count];
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();

            string enumeration = EnumsListBox.Text;
            Type? type = Type.GetType($"Programming.Model.Enums.{enumeration}");
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            var values = Enum.GetValues(type).Cast<object>().ToArray();
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            ValuesListBox.Items.AddRange(values);

            ValueIntTextBox.Clear();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday text;
            if (Enum.TryParse(ParseTextBox.Text, out text) && text >= 0)
            {
                ResultParsingLabel.Text = $"Это день недели ({text} = {(int) text})";
            }
            else
            {
                ResultParsingLabel.Text = $"Это не день недели!";
            }
            ResultParsingLabel.Visible = true;
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            EnumsPage.BackColor = System.Drawing.Color.White;
            switch (Enum.Parse(typeof(Season), SeasonComboBox.Text))
            {
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Spring:
                    this.BackColor = System.Drawing.Color.LightGreen;
                    EnumsPage.BackColor = System.Drawing.Color.LightGreen;
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    EnumsPage.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueIntTextBox.Clear();
            var value = (int)ValuesListBox.SelectedItem;
            ValueIntTextBox.Text = value.ToString();
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = RectanglesListBox.Items[indexRectangle].ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(LengthTextBox.Text, out int lengthRectangle);
                if (lengthRectangle > 1 && lengthRectangle < 10)
                {
                    lengthRectangle = 2;
                }
            }
            catch
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
                throw new ArgumentException("ашибка length textbox");
            }
            // При изменении текста в текстовом поле, новое значение текста
            // должно присваиваться в соответствующее свойство объекта _currentRectangle
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            // При изменении текста в текстовом поле, новое значение текста
            // должно присваиваться в соответствующее свойство объекта _currentRectangle
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            // При изменении текста в текстовом поле, новое значение текста
            // должно присваиваться в соответствующее свойство объекта _currentRectangle
        }
    }
}