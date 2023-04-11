namespace AppBooks.View.Panels
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, содержащий SelectedBookGroupBox.
    /// </summary>
    public partial class SelectedBookControl : UserControl
    {
        private Book _currentBook = new Book();

        public SelectedBookControl()
        {
            InitializeComponent();

            // заполнение GenreComboBox
            GenreComboBox.DataSource = Enum.GetValues(typeof(Genre));
            GenreComboBox.SelectedIndex = 0;
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
            switch (Enum.Parse(typeof(Genre), GenreComboBox.Text))
            {
                case Genre.Drama:
                    break;
                case Genre.Thriller:
                    break;
                case Genre.Horror:
                    break;
                case Genre.Adventures:
                    break;
                case Genre.Fiction:
                    break;
                case Genre.Fantasy:
                    break;
            }
        }
    }
}
