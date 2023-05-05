using Newtonsoft.Json;
using AppBooks.Model.Classes;
using AppBooks.Model.Enums;

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
        /// Копия текущей выбранной книги.
        /// </summary>
        private Book _cloneCurrentBook = new();

        /// <summary>
        /// Индекс текущего выбранного элемента перед сортировкой 
        /// для сохранения выбранного элемента в BooksListBox.
        /// </summary>
        private int _indexBeforeSort;

        /// <summary>
        /// Индекс текущего выбранного элемента для добавления и редактирования элементов.
        /// </summary>
        private int _selectedIndex;

        /// <summary>
        /// Название файла для сохранения или загрузки данных.
        /// </summary>
        private string _fileName = "Books.json";

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

        /// <summary>
        /// Метод, который сохраняет данные всех книг в json файл (Books.json).
        /// </summary>
        public void SaveBook()
        {
            if (BooksListBox.Items.Count != 0)
            {
                var jsonString = System.Text.Json.JsonSerializer.Serialize(_booksList);
                File.WriteAllText("Books.json", jsonString);
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(NameTextBox.Text))
                {
                    if (Validator.CheckStringContainsOnlyEnglishLetters(NameTextBox.Text))
                    {
                        _cloneCurrentBook.Name = NameTextBox.Text;
                        NameTextBox.BackColor = Color.White;
                        return;
                    }

                    else
                    {
                        NameTextBox.BackColor = Color.LightPink;
                    }
                }
            }
            catch (ArgumentException ex)
            {
                NameTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, ex.Message);
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(YearTextBox.Text))
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
                ErrorToolTip.SetToolTip((Control)sender, "Введите корректное число.");
            }
            catch (OverflowException)
            {
                YearTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, "Некорректное значение.");
            }
            catch (ArgumentException ex)
            {
                YearTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, ex.Message);
            }
        }

        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(AuthorTextBox.Text))
                {
                    // TODO: мне кажется или тут не нужен цикл
                    if (Validator.CheckStringContainsOnlyEnglishLetters(AuthorTextBox.Text))
                    {
                        _cloneCurrentBook.Author = AuthorTextBox.Text;
                        AuthorTextBox.BackColor = Color.White;
                        return;
                    }

                    else
                    {
                        AuthorTextBox.BackColor = Color.LightPink;
                    }
                }
            }
            catch (ArgumentException ex)
            {
                AuthorTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, ex.Message);
            }
        }

        private void PageTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(PageTextBox.Text))
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
                ErrorToolTip.SetToolTip((Control)sender, "Введите корректное число.");
            }
            catch (OverflowException)
            {
                PageTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, "Некорректное значение.");
            }
            catch (ArgumentException ex)
            {
                PageTextBox.BackColor = Color.LightPink;
                ErrorToolTip.SetToolTip((Control)sender, ex.Message);
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
            _selectedIndex = -1;
            ToggleInputBoxes(true);
        }

        private void DeleteBookButton_Click(object sender, EventArgs e)
        {
            if (BooksListBox.Items.Count == 0 || BooksListBox.SelectedIndex == -1)
            {
                return;
            }
            _currentBook = _booksList[BooksListBox.SelectedIndex];
            _booksList.Remove(_currentBook);
            BooksListBox.SelectedIndex = -1;
            SaveBook();
            Sort();
            ClearBooksInfo();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (BooksListBox.Items.Count == 0 || BooksListBox.SelectedIndex == -1)
            {
                return;
            }

            _selectedIndex = BooksListBox.SelectedIndex;
            _cloneCurrentBook = (Book)_booksList[_selectedIndex].Clone();
            ToggleInputBoxes(true);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            // TODO: Проще сделать обратное условие. Сначала проверить:
            // Есть ли такое поле, которое не заполнено.
            // Если да, то вызывается messagebox, а потом return.
            // Если нет, то создаем Book и else отпадает
            if (string.IsNullOrEmpty(NameTextBox.Text) ||
                string.IsNullOrEmpty(YearTextBox.Text) ||
                string.IsNullOrEmpty(AuthorTextBox.Text) ||
                string.IsNullOrEmpty(PageTextBox.Text) ||
                string.IsNullOrEmpty(GenreComboBox.Text))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка ввода");
                return;
            }

            if (_selectedIndex == -1)
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
                SaveBook();
                ToggleInputBoxes(false);
                return;
            }

            _booksList[_selectedIndex] = _cloneCurrentBook;
            _currentBook = _cloneCurrentBook;
            Sort();
            SaveBook();
            ToggleInputBoxes(false);
            UpdateBookInfo();
        }

        private void BooksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedIndex != -1)
            {
                ToggleInputBoxes(false);
                _cloneCurrentBook = (Book)_booksList[BooksListBox.SelectedIndex].Clone();
                NameTextBox.Text = _cloneCurrentBook.Name.ToString();
                YearTextBox.Text = _cloneCurrentBook.Year.ToString();
                AuthorTextBox.Text = _cloneCurrentBook.Author.ToString();
                PageTextBox.Text = _cloneCurrentBook.Page.ToString();
                GenreComboBox.Text = _cloneCurrentBook.Genre;
            }
        }

        private void SaveBookButton_Click(object sender, EventArgs e)
        {
            SaveBook();
        }

        /// <summary>
        /// Метод, который построчно считывает текстовый файл 
        /// для заполнения <see cref="BooksListBox"/> и <see cref="_booksList"/>.
        /// </summary>
        private void LoadBooksInfo()
        {
            if (File.Exists(_fileName))
            {
                _booksList = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(_fileName));
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
            _indexBeforeSort = BooksListBox.SelectedIndex;
            BooksListBox.SelectedIndexChanged -= BooksListBox_SelectedIndexChanged;
            _booksList = _booksList.OrderBy(book => book.ToString()).ToList();
            BooksListBox.DataSource = _booksList;
            BooksListBox.SelectedIndex = _indexBeforeSort;
            BooksListBox.SelectedIndexChanged += BooksListBox_SelectedIndexChanged;
        }

        /// <summary>
        /// Метод, который включает или отключает все TextBox, ComboBox и ApplyButton.
        /// </summary>
        /// <param name="value">True or false.</param>
        private void ToggleInputBoxes(bool value)
        {
            NameTextBox.Enabled = value;
            YearTextBox.Enabled = value;
            AuthorTextBox.Enabled = value;
            PageTextBox.Enabled = value;
            GenreComboBox.Enabled = value;
            ApplyButton.Visible = value;
        }

        private void UpdateBookInfo()
        {
            NameTextBox.Text = _currentBook.Name.ToString();
            YearTextBox.Text = _currentBook.Year.ToString();
            AuthorTextBox.Text = _currentBook.Author.ToString();
            PageTextBox.Text = _currentBook.Page.ToString();
            GenreComboBox.Text = _currentBook.Genre.ToString();
        }
    }
}