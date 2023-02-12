namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Color tests = new Color();
            EnumsListBox.DataSource = tests;
        }
    }
}