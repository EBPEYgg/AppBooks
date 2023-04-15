using System;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AppBooks.View.Panels
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, содержащий BooksGroupBox.
    /// </summary>
    public partial class BooksControl : UserControl
    {
        /// <summary>
        /// TODO: XML.
        /// </summary>
        private List<Book> _booksList = new List<Book>();
        /// <summary>
        /// TODO: XML.
        /// </summary>
        private Book _currentBook = new Book();
        /// <summary>
        /// Массив с названиями книг.
        /// </summary>
        private string[] name = {
                "Eugene Onegin",
                "War and Peace",
                "The Gambler",
                "A Hero of Our Time",
                "Anna Karenina" };
        /// <summary>
        /// Массив с именами авторов (Имя Фамилия).
        /// </summary>
        private string[] authors = {
                "Alexander Pushkin",
                "Mikhail Lermontov",
                "Leo Tolstoy",
                "Fyodor Dostoevsky",
                "Ivan Turgenev" };
        /// <summary>
        /// TODO: XML.
        /// </summary>
        private int _selectedIndex = -1;

        /// <summary>
        /// Выбор случайного элемента из массива строк.
        /// </summary>
        /// <param name="array">Массив строк.</param>
        /// <returns>Один элемент типа string.</returns>
        public string PickRandomAmongStringArray(string[] array)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, array.Length);
            var randomArrayElement = array[randomIndex];
            return randomArrayElement;
        }

        public BooksControl()
        {
            InitializeComponent();
            //LoadBooksInfo();

            // заполнение GenreComboBox
            GenreComboBox.DataSource = Enum.GetValues(typeof(Genre));
            GenreComboBox.SelectedIndex = -1;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var flag = false;
                foreach (var item in NameTextBox.Text)
                {
                    if (!char.IsNumber(item))
                    {
                        flag = true;
                    }
                }

                if (flag == true)
                {
                    _currentBook.Name = NameTextBox.Text;
                    NameTextBox.BackColor = Color.White;
                    UpdateBooksInfo(_currentBook);
                }

                if (NameTextBox.Text == "")
                {
                    NameTextBox.BackColor = Color.LightPink;
                    return;
                }

                if (flag == false)
                {
                    NameTextBox.BackColor = Color.LightPink;
                    throw new ArgumentException("Некорректный цвет.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(YearTextBox.Text, out var number))
                {
                    YearTextBox.BackColor = Color.LightPink;
                    return;
                }
                _currentBook.Year = Convert.ToInt32(YearTextBox.Text);
                YearTextBox.BackColor = Color.White;
                UpdateBooksInfo(_currentBook);
            }
            catch (FormatException)
            {
                YearTextBox.BackColor = Color.LightPink;
                MessageBox.Show("Введите корректное число.", "Ошибка ввода");
            }
            catch (OverflowException)
            {
                YearTextBox.BackColor = Color.LightPink;
                MessageBox.Show("Некорректное значение.", "Ошибка ввода");
            }
        }

        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var flag = false;
                foreach (var item in AuthorTextBox.Text)
                {
                    if (!char.IsNumber(item))
                    {
                        flag = true;
                    }
                }

                if (flag == true)
                {
                    _currentBook.Author = AuthorTextBox.Text;
                    AuthorTextBox.BackColor = Color.White;
                    UpdateBooksInfo(_currentBook);
                }

                if (AuthorTextBox.Text == "")
                {
                    AuthorTextBox.BackColor = Color.LightPink;
                    return;
                }

                if (flag == false)
                {
                    AuthorTextBox.BackColor = Color.LightPink;
                    throw new ArgumentException("Некорректный цвет.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
        }

        private void PageTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(PageTextBox.Text, out var temp))
                {
                    PageTextBox.BackColor = Color.LightPink;
                    return;
                }
                _currentBook.Page = Convert.ToInt32(PageTextBox.Text);
                PageTextBox.BackColor = Color.White;
                UpdateBooksInfo(_currentBook);
            }
            catch (FormatException)
            {
                PageTextBox.BackColor = Color.LightPink;
                MessageBox.Show("Введите корректное число.", "Ошибка ввода");
            }
            catch (OverflowException)
            {
                PageTextBox.BackColor = Color.LightPink;
                MessageBox.Show("Некорректное значение.", "Ошибка ввода");
            }
        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GenreComboBox.SelectedIndex != -1)
            {
                switch (Enum.Parse(typeof(Genre), GenreComboBox.Text))
                {
                    case Genre.Drama:
                        _currentBook.Genre = GenreComboBox.SelectedItem.ToString();
                        break;
                    case Genre.Thriller:
                        _currentBook.Genre = GenreComboBox.SelectedItem.ToString();
                        break;
                    case Genre.Horror:
                        _currentBook.Genre = GenreComboBox.SelectedItem.ToString();
                        break;
                    case Genre.Adventures:
                        _currentBook.Genre = GenreComboBox.SelectedItem.ToString();
                        break;
                    case Genre.Fiction:
                        _currentBook.Genre = GenreComboBox.SelectedItem.ToString();
                        break;
                    case Genre.Fantasy:
                        _currentBook.Genre = GenreComboBox.SelectedItem.ToString();
                        break;
                }
                UpdateBooksInfo(_currentBook);
            }
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string currentName = PickRandomAmongStringArray(name);
            int currentYear = random.Next(0, 2024);
            string currentAuthors = PickRandomAmongStringArray(authors);
            int currentPage = random.Next(50, 501);
            string? currentGenre = Enum.ToObject(typeof(Genre), random.Next(0, 5)).ToString();

            _currentBook = new Book(currentName, currentYear, currentAuthors, currentPage, currentGenre);
            _booksList.Add(_currentBook);
            BooksListBox.Items.Add(
                $"{_currentBook.Name} / " +
                $"{_currentBook.Author} /" +
                $" {_currentBook.Genre} ");
            BooksListBox.DataSource = _booksList;
        }

        private void DeleteBookButton_Click(object sender, EventArgs e)
        {
            _currentBook = _booksList[BooksListBox.SelectedIndex];
            BooksListBox.Items.RemoveAt(BooksListBox.SelectedIndex);
            _booksList.Remove(_currentBook);
        }

        private void BooksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedIndex != -1 &&
                _selectedIndex != BooksListBox.SelectedIndex)
            {
                ClearBooksInfo();
                _selectedIndex = BooksListBox.SelectedIndex;
                _currentBook = _booksList[_selectedIndex];
                NameTextBox.Text = _currentBook.Name.ToString();
                YearTextBox.Text = _currentBook.Year.ToString();
                AuthorTextBox.Text = _currentBook.Author.ToString();
                PageTextBox.Text = _currentBook.Page.ToString();
                GenreComboBox.Text = _currentBook.Genre;
            }
        }

        private void SaveBookButton_Click(object sender, EventArgs e)
        {
            var filePath = @"D:\Учеба\1 курс\2 семестр\Programming\AppBooks\Resources\Books.txt";
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                for (int i = 0; i < BooksListBox.Items.Count; i++)
                {
                    var book = BooksListBox.Items[i];
                    writer.WriteLine(book);
                }
            }
        }

        // TODO: доделать LoadBooksInfo.
        private void LoadBooksInfo()
        {
            // при запуске программы считывает *.txt построчно
            // и вставляет данные в BooksListBox и список _booksList
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;
                StreamReader reader = new StreamReader(filePath);
                string? line = reader.ReadLine();
                while (line != null)
                {
                    string[] words = line.Split('/');
                    foreach (var item in words)
                    {
                        item.TrimEnd();
                    }
                    _currentBook.Name = words[0];
                    _currentBook.Author = words[1];
                    _currentBook.Genre = words[2];
                    BooksListBox.Items.Add(
                        $"{_currentBook.Name} / " +
                        $"{_currentBook.Author} /" +
                        $" {_currentBook.Genre}");
                    _booksList.Add(_currentBook);
                    line = reader.ReadLine();
                }
                reader.Close();
            }
        }

        private void ClearBooksInfo()
        {
            NameTextBox.Clear();
            YearTextBox.Clear();
            AuthorTextBox.Clear();
            PageTextBox.Clear();
            GenreComboBox.SelectedIndex = -1;
        }

        // TODO: не работает корректно с сортировкой BooksListBox.
        private void UpdateBooksInfo(Book book)
        {
            if (_selectedIndex != -1)
            {
                BooksListBox.Items[_selectedIndex] =
                    $"{_currentBook.Name} " +
                    $"/ {_currentBook.Author} " +
                    $"/ {_currentBook.Genre} ";
                BooksListBox.SelectedIndex = _selectedIndex;
            }
        }
    }
}