using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Windows.Forms;
using WinFormsApp1.Model;
using System.Linq;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            string[] Enums = { "Color", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" };
            EnumsListBox.Items.AddRange(Enums);
            EnumsListBox.SelectedIndex = 0;

            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonComboBox.SelectedIndex = 0;
            //считать листбокс1 -> строку -> тип -> datasource
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();

            switch (EnumsListBox.SelectedItem)
            {
                case "Color":
                    var values = Enum.GetValues(typeof(Model.Color)).Cast<object>().ToArray();
                    ValuesListBox.Items.AddRange(values);
                    break;
                case "EducationForm":
                    foreach (var item in Enum.GetValues(typeof(EducationForm)))
                        ValuesListBox.Items.Add(item);
                    break;
                case "Genre":
                    foreach (var item in Enum.GetValues(typeof(Genre)))
                        ValuesListBox.Items.Add(item);
                    break;
                case "Manufactures":
                    foreach (var item in Enum.GetValues(typeof(Manufactures)))
                        ValuesListBox.Items.Add(item);
                    break;
                case "Season":
                    foreach (var item in Enum.GetValues(typeof(Season)))
                        ValuesListBox.Items.Add(item);
                    break;
                case "Weekday":
                    foreach (var item in Enum.GetValues(typeof(Weekday)))
                        ValuesListBox.Items.Add(item);
                    break;
                default:
                    throw new ArgumentException("ашибка EnumsListBox_SelectedIndexChanged");
            }
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday text;
            if (Enum.TryParse(ParseTextBox.Text, out text))
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

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueTextBox.Clear();
            var value = (int)ValuesListBox.SelectedItem;
            ValueTextBox.Text = value.ToString();
        }
    }
}