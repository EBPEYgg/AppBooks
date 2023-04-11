namespace AppBooks.View.Panels
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, содержащий BooksGroupBox.
    /// </summary>
    public partial class BooksControl : UserControl
    {
        private List<Book> _booksList = new List<Book>();
        private Book _currentBook = new Book();

        /// <summary>
        /// Выбор случайного элемента из массива строк.
        /// </summary>
        /// <param name="array">Массив строк.</param>
        /// <returns>Один элемент типа string.</returns>
        public string PickRandomAmongStringArray(string[] array)
        {
            Random random = new Random();
            int randomIndex = random.Next(array.Length);
            var randomArrayElement = array[randomIndex];
            return randomArrayElement;
        }

        public BooksControl()
        {
            InitializeComponent();

            string[] authors = { 
                "Alexander Pushkin", 
                "Mikhail Lermontov", 
                "Leo Tolstoy", 
                "Fyodor Dostoevsky",
                "Ivan Turgenev" };
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            var currentYear = random.Next(0, 2024);
            var currentGenre = Enum.ToObject(typeof(Genre), random.Next(0, 5)).ToString();
            var currentPage = random.Next(50, 501);

            _currentBook = new Book("raz", currentYear, "dva", currentPage, currentGenre);
            _booksList.Add(_currentBook);
            BooksListBox.Items.Add(
                $"{_currentBook.Name} / " +
                $"{_currentBook.Author} /" +
                $"{_currentBook.Genre}"
                );
        }

        private void EditBookButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBookButton_Click(object sender, EventArgs e)
        {
            _currentBook = _booksList[BooksListBox.SelectedIndex];
            BooksListBox.Items.RemoveAt(BooksListBox.SelectedIndex);
            _booksList.Remove(_currentBook);
        }

        private void BooksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ClearBooksInfo();
            //_currentBook = _booksList[BooksListBox.SelectedIndex];
            //NameTextBox.Text = _currentBook.Name.ToString();
            //YearTextBox.Text = _currentBook.Year.ToString();
            //AuthorTextBox.Text = _currentBook.Author.ToString();
            //PageTextBox.Text = _currentBook.Page.ToString();
        }

        private void ClearBooksInfo()
        {
            //NameTextBox.Text = _currentBook.Name.ToString();
            //YearTextBox.Text = _currentBook.Year.ToString();
            //AuthorTextBox.Text = _currentBook.Author.ToString();
            //PageTextBox.Text = _currentBook.Page.ToString();
        }
    }
}