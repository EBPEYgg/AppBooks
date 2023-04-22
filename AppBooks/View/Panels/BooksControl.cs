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
        /// Список с данными о книгах.
        /// </summary>
        private List<Book> _booksList = new List<Book>();
        /// <summary>
        /// Список с данными текущей выбранной книги.
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
        /// Индекс в BooksListBox для <see cref="UpdateBooksInfo(Book)"/>.
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
            LoadBooksInfo();

            // заполнение GenreComboBox
            GenreComboBox.DataSource = Enum.GetValues(typeof(Genre));
            GenreComboBox.SelectedIndex = -1;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = Color.LightPink;
                var flag = false;
                foreach (var item in NameTextBox.Text)
                {
                    if (!char.IsNumber(item) && Validator.AssertStringContainsOnlyEnglishLetters(AuthorTextBox.Text))
                    {
                        flag = true;
                    }
                }

                if (flag == true)
                {
                    _currentBook.Name = NameTextBox.Text;
                    NameTextBox.BackColor = Color.White;
                }

                if (flag == false)
                {
                    throw new ArgumentException("Некорректное название книги.");
                }
            }
            catch (ArgumentException)
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                YearTextBox.BackColor = Color.LightPink;
                if (!int.TryParse(YearTextBox.Text, out var number))
                {
                    YearTextBox.BackColor = Color.LightPink;
                    return;
                }
                _currentBook.Year = Convert.ToInt32(YearTextBox.Text);
                YearTextBox.BackColor = Color.White;
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
            catch (ArgumentException ex)
            {
                YearTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
        }

        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AuthorTextBox.BackColor = Color.LightPink;
                var flag = false;
                foreach (var item in AuthorTextBox.Text)
                {
                    if (!char.IsNumber(item) && Validator.AssertStringContainsOnlyEnglishLetters(AuthorTextBox.Text))
                    {
                        flag = true;
                    }
                }

                if (flag == true)
                {
                    _currentBook.Author = AuthorTextBox.Text;
                    AuthorTextBox.BackColor = Color.White;
                }

                if (flag == false)
                {
                    throw new ArgumentException("Некорректное имя автора.");
                }
            }
            catch (ArgumentException)
            {
                AuthorTextBox.BackColor = Color.LightPink;
            }
        }

        private void PageTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(PageTextBox.Text, out var temp) ||
                    !Validator.AssertOnPositiveValue(int.Parse(PageTextBox.Text)))
                {
                    PageTextBox.BackColor = Color.LightPink;
                    return;
                }
                _currentBook.Page = Convert.ToInt32(PageTextBox.Text);
                PageTextBox.BackColor = Color.White;
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
            catch (ArgumentException ex)
            {
                PageTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GenreComboBox.SelectedIndex != -1)
            {
                if (_currentBook.Genre != null)
                {
                    Enum.Parse(typeof(Genre), _currentBook.Genre);
                    return;
                }

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
            Sort();
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
                    var book = $"{BooksListBox.Items[i]} / {_booksList[i].Page} / {_booksList[i].Year}";
                    writer.WriteLine(book);
                }
            }
        }

        // при запуске программы считывает *.txt построчно
        // и вставляет данные в BooksListBox и список _booksList
        private void LoadBooksInfo()
        {
            {
                var filePath = @"D:\Учеба\1 курс\2 семестр\Programming\AppBooks\Resources\Books.txt";
                StreamReader reader = new StreamReader(filePath);
                string? line = reader.ReadLine();
                while (line != null)
                {
                    string[] words = line.Split('/');
                    for (int i = 0; i < words.Length; i++)
                    {
                        words[i] = words[i].Trim();
                    }
                    _currentBook.Name = words[0];
                    _currentBook.Author = words[1];
                    _currentBook.Genre = words[2];
                    _currentBook.Page = Convert.ToInt32(words[3]);
                    _currentBook.Year = Convert.ToInt32(words[4]);
                    _booksList.Add(_currentBook);
                    BooksListBox.Items.Add(
                        $"{_currentBook.Name} / " +
                        $"{_currentBook.Author} /" +
                        $" {_currentBook.Genre}");
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

        private void Sort()
        {
            _booksList = _booksList.OrderBy(book => book.ToString()).ToList();
            BooksListBox.DataSource = _booksList;
        }
    }
}