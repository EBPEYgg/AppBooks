using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            string[] enums = { "Color", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" };          
            EnumsListBox.DataSource = enums;
            EnumsListBox.SelectedIndex = 0;

            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonComboBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();

            string enumeration = EnumsListBox.Text;
            Type? type = Type.GetType($"Programming.Model.Enums.{enumeration}");
            var values = Enum.GetValues(type).Cast<object>().ToArray();
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
    }
}