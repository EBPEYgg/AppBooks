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
        /// Минимальный год выпуска книги.
        /// </summary>
        const int minYear = 0;
        /// <summary>
        /// Максимальный год выпуска книги.
        /// </summary>
        const int maxYear = 2024;
        /// <summary>
        /// Минимальное кол-во страниц в книге.
        /// </summary>
        const int minPage = 1;
        /// <summary>
        /// Максимальное кол-во страниц в книге.
        /// </summary>
        const int maxPage = 10000;
        /// <summary>
        /// Заголовок для окна возникшей ошибки при вводе неверного значения в TextBox.
        /// </summary>
        const string inputError = "Ошибка ввода";
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

        // TODO: конструктор
        public BooksControl()
        {
            InitializeComponent();
            LoadBooksInfo();

            // заполнение GenreComboBox
            GenreComboBox.DataSource = Enum.GetValues(typeof(Genre));
            GenreComboBox.SelectedIndex = -1;

            if (_booksList.Count == 0)
            {
                BooksListBox.SelectedIndex = -1;
            }
        }

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

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (NameTextBox.Text != "")
                {
                    var flag = false;
                    foreach (var item in NameTextBox.Text)
                    {
                        // TODO: длина строки
                        if (!char.IsNumber(item) &&
                            Validator.CheckStringContainsOnlyEnglishLetters(NameTextBox.Text))
                        {
                            flag = true;
                        }
                    }

                    if (flag == true)
                    {
                        _currentBook.Name = NameTextBox.Text;
                        NameTextBox.BackColor = Color.White;
                        Sort();
                    }

                    if (flag == false)
                    {
                        throw new ArgumentException("Некорректное название книги.");
                    }
                }
            }
            catch (ArgumentException ex)
            {
                NameTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, inputError);
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
                Sort();
            }
            catch (FormatException)
            {
                YearTextBox.BackColor = Color.LightPink;
                MessageBox.Show("Введите корректное число.", inputError);
            }
            catch (OverflowException)
            {
                YearTextBox.BackColor = Color.LightPink;
                MessageBox.Show("Некорректное значение.", inputError);
            }
            catch (ArgumentException ex)
            {
                YearTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, inputError);
            }
        }

        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (AuthorTextBox.Text != "")
                {
                    var flag = false;
                    foreach (var item in AuthorTextBox.Text)
                    {
                        // TODO: длина строки
                        if (!char.IsNumber(item) &&
                            Validator.CheckStringContainsOnlyEnglishLetters(AuthorTextBox.Text))
                        {
                            flag = true;
                        }
                    }

                    if (flag == true)
                    {
                        _currentBook.Author = AuthorTextBox.Text;
                        AuthorTextBox.BackColor = Color.White;
                        Sort();
                    }

                    if (flag == false)
                    {
                        throw new ArgumentException("Некорректное имя автора.");
                    }
                }
            }
            catch (ArgumentException ex)
            {
                AuthorTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, inputError);
            }
        }

        private void PageTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PageTextBox.BackColor = Color.LightPink;
                if (!int.TryParse(PageTextBox.Text, out var temp))
                {
                    PageTextBox.BackColor = Color.LightPink;
                    return;
                }
                _currentBook.Page = Convert.ToInt32(PageTextBox.Text);
                PageTextBox.BackColor = Color.White;
                Sort();
            }
            catch (FormatException)
            {
                PageTextBox.BackColor = Color.LightPink;
                MessageBox.Show("Введите корректное число.", inputError);
            }
            catch (OverflowException)
            {
                PageTextBox.BackColor = Color.LightPink;
                MessageBox.Show("Некорректное значение.", inputError);
            }
            catch (ArgumentException ex)
            {
                PageTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, inputError);
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

            Sort();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string currentName = PickRandomAmongStringArray(name);
            // TODO: в константы
            int currentYear = random.Next(minYear, maxYear);
            string currentAuthors = PickRandomAmongStringArray(authors);
            int currentPage = random.Next(minPage, maxPage);
            string? currentGenre = Enum.ToObject(typeof(Genre), random.Next(0, 5)).ToString();

            _currentBook = new Book(
                currentName, 
                currentYear, 
                currentAuthors, 
                currentPage, 
                currentGenre
                );
            _booksList.Add(_currentBook);
            Sort();
        }

        private void DeleteBookButton_Click(object sender, EventArgs e)
        {
            _currentBook = _booksList[BooksListBox.SelectedIndex];
            _booksList.Remove(_currentBook);
            Sort();
        }

        private void BooksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearBooksInfo();
            if (BooksListBox.SelectedIndex != -1)
            {
                _currentBook = _booksList[BooksListBox.SelectedIndex];
                NameTextBox.Text = _currentBook.Name.ToString();
                YearTextBox.Text = _currentBook.Year.ToString();
                AuthorTextBox.Text = _currentBook.Author.ToString();
                PageTextBox.Text = _currentBook.Page.ToString();
                GenreComboBox.Text = _currentBook.Genre;
            }
        }

        private void SaveBookButton_Click(object sender, EventArgs e)
        {
            // TODO: пути
            var filePath = Environment.CurrentDirectory + @"\Books.txt";
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                for (int i = 0; i < BooksListBox.Items.Count; i++)
                {
                    var book = $"{BooksListBox.Items[i]} / {_booksList[i].Page} / {_booksList[i].Year}";
                    writer.WriteLine(book);
                }
            }
        }

        // TODO: вынести в сам метод комментарии
        /// <summary>
        /// Метод, который построчно считывает текстовый файл 
        /// для заполнения <see cref="BooksListBox"/> и <see cref="_booksList"/>.
        /// </summary>
        private void LoadBooksInfo()
        {
            // TODO: пути Directory.GetCurrentDirectory
            var filePath = Environment.CurrentDirectory + @"\Books.txt";
            StreamReader reader = new StreamReader(filePath);
            string? line = reader.ReadLine();
            while (line != null)
            {
                string[] words = line.Split('/');
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i].Trim();
                }
                var _currentBook = new Book();
                _currentBook.Name = words[0];
                _currentBook.Author = words[1];
                _currentBook.Genre = words[2];
                _currentBook.Page = Convert.ToInt32(words[3]);
                _currentBook.Year = Convert.ToInt32(words[4]);
                _booksList.Add(_currentBook);
                BooksListBox.Items.Add(_currentBook);
                line = reader.ReadLine();
            }
            reader.Close();
            Sort();
        }

        // TODO: xml
        /// <summary>
        /// Метод, который очищает текстовые поля и ComboBox.
        /// </summary>
        private void ClearBooksInfo()
        {
            NameTextBox.Clear();
            YearTextBox.Clear();
            AuthorTextBox.Clear();
            PageTextBox.Clear();
            GenreComboBox.SelectedIndex = -1;
        }

        // TODO: xml
        /// <summary>
        /// Метод, который сортирует <see cref="_booksList"/> и <see cref="BooksListBox"/>
        /// в алфавитном порядке.
        /// </summary>
        private void Sort()
        {
            _booksList = _booksList.OrderBy(book => book.ToString()).ToList();
            BooksListBox.DataSource = _booksList;
        }
    }
}