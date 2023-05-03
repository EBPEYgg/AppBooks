using System;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using System.Text;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Reflection.Metadata.BlobBuilder;
using AppBooks.Model.Classes;
using AppBooks.Model.Enums;

// TODO: замечание по добавлению и изменению. Можно использовать только _currentBook и _selectedIndex, чтобы добавлять и изменять объекты:
// TODO: 1. При добавлении _selectedIndex приравниваем -1, _currentBook = new Book().
//          Включаем все поля для ввода. При изменении изменяем _currentBook.
//          После нажатия на Apply, идет проверка _selectedIndex == -1. Если _selectedIndex == -1, то значит это добавление.
//          Тогда добавляем элемент _booksList.Add(_currentBook), сортируем, сохраняем и отключаем контролы.
// TODO: 2. При изменении _selectedIndex равен выбранному индексу.
//          _currentBook = (Book)_booksList[_selectedIndex].Clone.
//          Также изменяем _currentBook. После нажатия на Apply, идет проверка _selectedIndex == -1.
//          Если условие не пройдено, то значит это изменение. Тогда заменяем элемент _booksList[_selectedIndex]= _currentBook,
//          сортируем, сохраняем и отключаем контролы.

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
        /// Индекс текущего выбранного элемента перед сортировкой.
        /// </summary>
        private int indexBeforeSort;
        /// <summary>
        /// Индекс текущего выбранного элемента для добавления и редактирования элементов.
        /// </summary>
        private int _selectedIndex;
        /// <summary>
        /// JSON строка с данными элемента.
        /// </summary>
        private string jsonString;
        /// <summary>
        /// Название файла для сохранения или загрузки данных.
        /// </summary>
        private string fileName = "Books.json";

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
        /// Метод, который сохраняет данные всех кииг в json файл "Books.json".
        /// </summary>
        public void SaveBook()
        {
            if (BooksListBox.Items.Count != 0)
            {
                jsonString = System.Text.Json.JsonSerializer.Serialize(_booksList);
                File.WriteAllText("Books.json", jsonString);
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(NameTextBox.Text))
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
            _currentBook = _booksList[BooksListBox.SelectedIndex];
            _booksList.Remove(_currentBook);
            BooksListBox.SelectedIndex = -1;
            Sort();
            ClearBooksInfo();
            // TODO: вызывать не обработчик события, а сделать отдельно метод сохранения
            SaveBook();
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
            // TODO: string.IsEmpty(NameTextBox.Text) Так со всеми
            if (_selectedIndex == -1 &&
                !string.IsNullOrEmpty(NameTextBox.Text) &&
                !string.IsNullOrEmpty(YearTextBox.Text) &&
                !string.IsNullOrEmpty(AuthorTextBox.Text) &&
                !string.IsNullOrEmpty(PageTextBox.Text) &&
                !string.IsNullOrEmpty(GenreComboBox.Text))
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

            // TODO: не происходит применение, тк клонированный элемент не заменяется в самой коллекции.
            // TODO: сначала нужно заменить значение по индексу на склонированное,
            // затем провести сортировку (_currentBook установить между заменой в коллекции и сортировкой)
            _booksList[_selectedIndex] = _cloneCurrentBook;
            _currentBook = _cloneCurrentBook;
            Sort();
            SaveBook();
            ToggleInputBoxes(false);
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
            // TODO: не используется
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

        // TODO: переименовать в ToggleInputBoxes
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
    }
}