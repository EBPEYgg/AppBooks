using System;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using System.Text;
using Newtonsoft.Json;

namespace AppBooks.View.Panels
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, содержащий BooksGroupBox.
    /// </summary>
    public partial class BooksControl : UserControl
    {
        // TODO: RSDN
        // TODO: некоторые поля и константы не используются
        // TODO: Все элементы класса должны разделяться одной строкой
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
        /// Количество элементов в перечислении <see cref="Genre"/>.
        /// </summary>
        int amountGenre = Enum.GetNames(typeof(Genre)).Length;
        /// <summary>
        /// Индекс выбранной книги перед сортировкой.
        /// </summary>
        int indexBeforeSort;
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
        /// Копия текущей выбранной книги.
        /// </summary>
        private Book _cloneCurrentBook = new();
        /// <summary>
        /// Флаг нажатия кнопки <see cref="AddBookButton"/>.
        /// </summary>
        private bool flagAddBookButton = false;
        /// <summary>
        /// Название файла для сохранения или загрузки данных.
        /// </summary>
        private string fileName = "Books.json";
        /// <summary>
        /// JSON строка с данными элемента.
        /// </summary>
        private string jsonString;
        
        public BooksControl()
        {
            InitializeComponent();
            LoadBooksInfo();
            ClearBooksInfo();
            BooksListBox.SelectedIndex = -1;

            // заполнение GenreComboBox
            GenreComboBox.DataSource = Enum.GetValues(typeof(Genre));
            GenreComboBox.SelectedIndex = -1;
        }

        // TODO: не используется
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
                        if (Validator.CheckStringContainsOnlyEnglishLetters(NameTextBox.Text))
                        {
                            flag = true;
                        }
                    }

                    if (flag)
                    {
                        _cloneCurrentBook.Name = NameTextBox.Text;
                        NameTextBox.BackColor = Color.White;
                        return;
                    }

                    throw new ArgumentException("Некорректное название книги.");
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
                if (YearTextBox.Text != "")
                {
                    if (!int.TryParse(YearTextBox.Text, out var number))
                    {
                        YearTextBox.BackColor = Color.LightPink;
                        return;
                    }

                    _cloneCurrentBook.Year = Convert.ToInt32(YearTextBox.Text);
                    YearTextBox.BackColor = Color.White;
                }
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
                        if (Validator.CheckStringContainsOnlyEnglishLetters(AuthorTextBox.Text))
                        {
                            flag = true;
                        }
                    }

                    if (flag)
                    {
                        _cloneCurrentBook.Author = AuthorTextBox.Text;
                        AuthorTextBox.BackColor = Color.White;
                        return;
                    }

                    // TODO: вместо выброса исключения изменять тут цвет, используя if/else
                    // TODO: убрать постоянный открытие MessageBox при некорректном воде.
                    // TODO: Если нужно показать сообщение об ошибке, то лучше использовать ToolTip
                    throw new ArgumentException("Некорректное имя автора.");
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
                if (PageTextBox.Text != "")
                {
                    if (!int.TryParse(PageTextBox.Text, out var number))
                    {
                        PageTextBox.BackColor = Color.LightPink;
                        return;
                    }

                    _cloneCurrentBook.Page = Convert.ToInt32(PageTextBox.Text);
                    PageTextBox.BackColor = Color.White;
                }
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
            if (GenreComboBox.SelectedIndex != -1 && _cloneCurrentBook.Genre != null)
            {
                Enum.Parse(typeof(Genre), _cloneCurrentBook.Genre);
                _cloneCurrentBook.Genre = GenreComboBox.SelectedItem.ToString();
            }
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            ClearBooksInfo();
            BooksListBox.SelectedIndex = -1;
            EnablesOrDisablesInputBox(true);
            flagAddBookButton = true;
        }

        private void DeleteBookButton_Click(object sender, EventArgs e)
        {
            _currentBook = _booksList[BooksListBox.SelectedIndex];
            _booksList.Remove(_currentBook);
            BooksListBox.SelectedIndex = -1;
            Sort();
            ClearBooksInfo();
            // TODO: вызывать не обработчик события, а сделать отдельно метод сохранения
            SaveBookButton_Click(sender, e);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (BooksListBox.Items.Count == 0)
            {
                if (flagAddBookButton)
                {
                    EnablesOrDisablesInputBox(true);
                }

                return;
            }

            _cloneCurrentBook = (Book)_currentBook.Clone();
            EnablesOrDisablesInputBox(true);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            // TODO: string.IsEmpty(NameTextBox.Text) Так со всеми
            if (flagAddBookButton && 
                NameTextBox.Text != "" && 
                YearTextBox.Text != "" && 
                AuthorTextBox.Text != "" && 
                PageTextBox.Text != "" && 
                GenreComboBox.Text != "")
            {
                _currentBook = new Book(
                    NameTextBox.Text.ToString(), 
                    Convert.ToInt32(YearTextBox.Text), 
                    AuthorTextBox.Text.ToString(), 
                    Convert.ToInt32(PageTextBox.Text), 
                    GenreComboBox.Text.ToString()
                    );
                _booksList.Add(_currentBook);
                Sort();
                SaveBookButton_Click(sender, e);
                EnablesOrDisablesInputBox(false);
                flagAddBookButton = false;
                return;
            }

            // TODO: не происходит применение, тк клонированный элемент не заменяется в самой коллекции.
            // TODO: сначала нужно заменить значение по индексу на склонированное, затем провести сортировку (_currentBook установить между заменой в коллекции и сортировкой)
            _currentBook = _cloneCurrentBook;
            Sort();
            SaveBookButton_Click(sender, e);
            EnablesOrDisablesInputBox(false);
        }

        private void BooksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedIndex != -1)
            {
                EnablesOrDisablesInputBox(false);
                _currentBook = _booksList[BooksListBox.SelectedIndex];
                _cloneCurrentBook = (Book)_currentBook.Clone();
                NameTextBox.Text = _cloneCurrentBook.Name.ToString();
                YearTextBox.Text = _cloneCurrentBook.Year.ToString();
                AuthorTextBox.Text = _cloneCurrentBook.Author.ToString();
                PageTextBox.Text = _cloneCurrentBook.Page.ToString();
                GenreComboBox.Text = _cloneCurrentBook.Genre;
            }
        }

        private void SaveBookButton_Click(object sender, EventArgs e)
        {
            var filePath = Environment.CurrentDirectory + @"\Books.json";
            if (BooksListBox.Items.Count != 0)
            {
                string jsonString = JsonSerializer.Serialize(_booksList);
                File.WriteAllText(filePath, jsonString);
            }
        }
        
        /// <summary>
        /// Метод, который построчно считывает текстовый файл 
        /// для заполнения <see cref="BooksListBox"/> и <see cref="_booksList"/>.
        /// </summary>
        private void LoadBooksInfo()
        {
            //var filePath = Environment.CurrentDirectory + @"\Books.json";
            // TODO: не используется
            var filePath = Directory.GetCurrentDirectory + @"\Books.json";
            if (File.Exists(fileName))
            {
                _booksList = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(fileName));
                Sort();
            }
        }
        
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
        
        /// <summary>
        /// Метод, который сортирует <see cref="_booksList"/> и <see cref="BooksListBox"/>
        /// в алфавитном порядке.
        /// </summary>
        private void Sort()
        {
            indexBeforeSort = BooksListBox.SelectedIndex;
            BooksListBox.SelectedIndexChanged -= BooksListBox_SelectedIndexChanged;
            _booksList = _booksList.OrderBy(book => book.ToString()).ToList();
            BooksListBox.DataSource = _booksList;
            BooksListBox.SelectedIndex = indexBeforeSort;
            BooksListBox.SelectedIndexChanged += BooksListBox_SelectedIndexChanged;
        }

        // TODO: переименовать в ToggleInputTextBoxes
        /// <summary>
        /// Метод, который включает или отключает все TextBox, ComboBox и ApplyButton.
        /// </summary>
        /// <param name="value">True or false.</param>
        private void EnablesOrDisablesInputBox(bool value)
        {
            NameTextBox.Enabled = value;
            YearTextBox.Enabled = value;
            AuthorTextBox.Enabled = value;
            PageTextBox.Enabled = value;
            GenreComboBox.Enabled = value;
            ApplyButton.Visible = value;
        }
    }
}