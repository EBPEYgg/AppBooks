using System.Text.Json;
using AppBooks.View.Panels;

namespace AppBooks
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, который сохраняет данные при закрытии приложения пользователем.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                BooksControl.SaveBook();
            }
        }
    }
}