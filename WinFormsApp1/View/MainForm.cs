using System;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        //public List<Enums> selectedType { get; set; }
        public MainForm()
        {
            InitializeComponent();

            EnumsListBox.Items.AddRange(Enum.GetNames(typeof(Enums)));
            EnumsListBox.SelectedIndex = 0;

            foreach (var item in Enum.GetValues(typeof(Season)))
            {
                SeasonComboBox.Items.Add(item);
            }
            SeasonComboBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            //switch (EnumsListBox.SelectedIndex)
            //{
            //    case 1:
            //        selectedType = typeof(EducationForm);
            //        break;
            //    case 2:
            //        selectedType = typeof(Genre);
            //        break;
            //    case 3:
            //        selectedType = typeof(Manufactures);
            //        break;
            //    case 4:
            //        selectedType = typeof(Season);
            //        break;
            //    case 5:
            //        selectedType = typeof(Weekday);
            //        break;
            //    default:
            //        //selectedType = typeof(Color);
            //        break;
            //}
            //ValuesListBox.Items.AddRange(Enum.GetNames(selectedType));
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday text;
            if (Enum.TryParse(ParseTextBox.Text, out text))
            {
                ResultParsingLabel.Text = $"Это день недели ({text} = {(int)text})";
            }
            else
            {
                ResultParsingLabel.Text = $"Это не день недели!";
            }
            ResultParsingLabel.Visible = true;
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            switch (Enum.Parse(typeof(Season), SeasonComboBox.Text))
            {
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Spring:
                    EnumsPage.BackColor = System.Drawing.Color.LightGreen;
                    this.BackColor = System.Drawing.Color.LightGreen;
                    FuckButton.Visible = true;
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    EnumsPage.BackColor = ColorTranslator.FromHtml("#e29c45");
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    FuckButton.Visible = true;
                    break;
            }
        }

        private void FuckButton_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            EnumsPage.BackColor = System.Drawing.Color.White;
            FuckButton.Visible = false;
        }
    }
}