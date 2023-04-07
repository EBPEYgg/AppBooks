using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming
{
    public partial class MainForm : Form
    {
        const int N = 5;
        private Rectangle[] _rectangles = new Rectangle[N];
        private Rectangle _currentRectangle = new Rectangle();
        private Film[] _films = new Film[8];
        private Film _currentFilm = new Film();
        private Point2D point2D = new Point2D();
        private List<Rectangle> _rectanglesList = new List<Rectangle>();
        private Rectangle _currentRectangleInList = new Rectangle();
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Поиск прямоугольника с максимальной шириной в списке прямоугольников.
        /// </summary>
        /// <returns>Индекс прямоугольника с максимальной шириной.</returns>
        private int FindRectangleWithMaxWidth()
        {
            double maxWidthRectangle = -1;
            int IndexRectangleWithMaxWidth = 0;
            for (int i = 0; i < RectanglesListBox.Items.Count; i++)
            {
                var currentWidthRectangle = _rectangles[i].Width;
                if (currentWidthRectangle > maxWidthRectangle)
                {
                    maxWidthRectangle = currentWidthRectangle;
                    IndexRectangleWithMaxWidth = i;
                }
            }
            return IndexRectangleWithMaxWidth;
        }

        /// <summary>
        /// Поиск фильма с максимальным рейтингом в списке фильмов.
        /// </summary>
        /// <returns>Индекс фильма с максимальным рейтингом.</returns>
        private int FindFilmWithMaxRating()
        {
            double maxRatingFilm = -1;
            int IndexFilmWithMaxRating = 0;
            for (int i = 0; i < FilmsListBox.Items.Count; i++)
            {
                var currentRatingFilm = _films[i].Rating;
                if (currentRatingFilm > maxRatingFilm)
                {
                    maxRatingFilm = currentRatingFilm;
                    IndexFilmWithMaxRating = i;
                }
            }
            return IndexFilmWithMaxRating;
        }

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

        public MainForm()
        {
            InitializeComponent();

            Random random = new Random();

            string[] colors = { "Black", "White", "Yellow", "Green", "Blue" };
            string[] nameFilms = { "Episode I – The Phantom Menace", "Episode II – Attack of the Clones", "Episode III – Revenge of the Sith", "Episode IV – A New Hope", "Episode V – The Empire Strikes Back", "Episode VI – Return of the Jedi" };
            string[] genreFilms = { "Science fiction", "Fantasy", "Action Movie", "Adventures" };
            string[] enums = { "Color", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" };
            double[] PointX = new double[5];
            double[] PointY = new double[5];

            EnumsListBox.DataSource = enums;    // заполнение первого листбокса
            EnumsListBox.SelectedIndex = 0;

            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));     // заполнение SeasonComboBox
            SeasonComboBox.SelectedIndex = 0;

            for (int i = 0; i < N; i++)
            {
                var Length = random.Next(1, 10);
                var Width = random.Next(1, 10);
                var CurrentColors = PickRandomAmongStringArray(colors);
                point2D = new Point2D(Convert.ToDouble(Length) / 2, Convert.ToDouble(Width) / 2);
                _rectangles[i] = new Rectangle(Length, Width, CurrentColors, point2D);
                PointX[i] = _rectangles[i].Center.X;
                PointY[i] = _rectangles[i].Center.Y;
                RectanglesListBox.Items.Add($"Rectangle {i}");
            }

            for (int j = 0; j < 6; j++)
            {
                var CurrentNameFilm = PickRandomAmongStringArray(colors);
                var CurrentGenreFilm = PickRandomAmongStringArray(genreFilms);
                var Time = random.Next(121, 152);
                var Year = random.Next(1977, 2006);
                var Rating = random.Next(1, 11);
                _films[j] = new Film(CurrentNameFilm, Time, Year, CurrentGenreFilm, Rating);
                FilmsListBox.Items.Add($"{nameFilms[j]}");
            }
        }

        // Enums page
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();

            string enumeration = EnumsListBox.Text;
            Type? type = Type.GetType($"Programming.Model.Enums.{enumeration}");
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            var values = Enum.GetValues(type).Cast<object>().ToArray();
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            ValuesListBox.Items.AddRange(values);

            ValueIntTextBox.Clear();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday text;
            if (Enum.TryParse(ParseTextBox.Text, out text) && text >= 0)
            {
                ResultParsingLabel.Text = $"Это день недели ({text} = {(int)text})";
            }
            else
            {
                ResultParsingLabel.Text = $"Это не день недели!";
            }
            ResultParsingLabel.Visible = true;
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            EnumsPage.BackColor = System.Drawing.Color.White;
            switch (Enum.Parse(typeof(Season), SeasonComboBox.Text))
            {
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Spring:
                    this.BackColor = System.Drawing.Color.LightGreen;
                    EnumsPage.BackColor = System.Drawing.Color.LightGreen;
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    EnumsPage.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueIntTextBox.Clear();
            var value = (int)ValuesListBox.SelectedItem;
            ValueIntTextBox.Text = value.ToString();
        }

        // Classes page
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[indexRectangle];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color!.ToString();
            PointXTextBox.Text = _currentRectangle.Center.X.ToString();
            PointYTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (LengthTextBox.Text == "")
                {
                    LengthTextBox.BackColor = System.Drawing.Color.LightPink;
                    return;
                }
                var lengthRectangle = Convert.ToDouble(LengthTextBox.Text);
                _currentRectangle.Length = lengthRectangle;
                LengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (FormatException)
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Введите число.");
            }
            catch (OverflowException)
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Некорректное значение.");
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (WidthTextBox.Text == "")
                {
                    WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                    return;
                }
                var widthRectangle = Convert.ToDouble(WidthTextBox.Text);
                _currentRectangle.Width = widthRectangle;
                WidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (FormatException)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Введите корректное число.", "Ошибка ввода");
            }
            catch (OverflowException)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Некорректное значение.", "Ошибка ввода");
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var flag = false;
                foreach (var item in ColorTextBox.Text)
                {
                    if (!char.IsNumber(item))
                    {
                        flag = true;
                    }
                }

                if (flag == true)
                {
                    _currentRectangle.Color = ColorTextBox.Text;
                    ColorTextBox.BackColor = System.Drawing.Color.White;
                }

                if (ColorTextBox.Text == "")
                {
                    ColorTextBox.BackColor = System.Drawing.Color.LightPink;
                    return;
                }

                if (flag == false)
                {
                    ColorTextBox.BackColor = System.Drawing.Color.LightPink;
                    throw new ArgumentException("Некорректный цвет.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
        }

        private void FindWidthButton_Click(object sender, EventArgs e)
        {
            RectangleWithMaxWidthLabel.Text = $"Прямоугольник с наиб. шириной: Rectangle {FindRectangleWithMaxWidth()}";
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
            RectangleWithMaxWidthLabel.Visible = true;
        }

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexFilm = FilmsListBox.SelectedIndex;
            _currentFilm = _films[indexFilm];
            TimeTextBox.Text = _currentFilm.Time.ToString();
            YearTextBox.Text = _currentFilm.Year.ToString();
            GenreTextBox.Text = _currentFilm.Genre!.ToString();
            RatingTextBox.Text = _currentFilm.Rating.ToString();
        }

        private void TimeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var timeFilm = int.Parse(TimeTextBox.Text);
                if (timeFilm == 0 || timeFilm > 300)
                {
                    throw new ArgumentException("Продолжительность фильма введена некорректно.");
                }

                if (timeFilm <= 300)
                {

                    _currentFilm.Time = timeFilm;
                    TimeTextBox.BackColor = System.Drawing.Color.White;
                }
            }
            catch (ArgumentException ex)
            {
                TimeTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
            catch (FormatException)
            {
                TimeTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var yearFilm = int.Parse(YearTextBox.Text);
                _currentFilm.Year = yearFilm;
                YearTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                YearTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
            catch (FormatException)
            {
                YearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var flag = false;
                foreach (var item in GenreTextBox.Text)
                {
                    if (!char.IsNumber(item))
                    {
                        flag = true;
                    }
                }

                if (flag == true)
                {
                    _currentFilm.Genre = GenreTextBox.Text;
                    GenreTextBox.BackColor = System.Drawing.Color.White;
                }

                if (GenreTextBox.Text == "")
                {
                    GenreTextBox.BackColor = System.Drawing.Color.LightPink;
                    return;
                }

                if (flag == false)
                {
                    GenreTextBox.BackColor = System.Drawing.Color.LightPink;
                    throw new ArgumentException("Некорректный жанр.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var ratingFilm = int.Parse(RatingTextBox.Text);
                if (ratingFilm == 0)
                {
                    RatingTextBox.BackColor = System.Drawing.Color.LightPink;
                    return;
                }
                _currentFilm.Rating = ratingFilm;
                RatingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
            catch (FormatException)
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FindRatingButton_Click(object sender, EventArgs e)
        {
            FilmWithMaxRatingLabel.Text = $"Индекс фильма с наиб. рейтингом: {FindFilmWithMaxRating()}";
            FilmsListBox.SelectedIndex = FindFilmWithMaxRating();
            FilmWithMaxRatingLabel.Visible = true;
        }

        // Rectangle panel page

        private void PanelAddRectangleButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int Length = random.Next(20, 100);
            int Width = random.Next(20, 100);
            int PointX = random.Next(20, CanvasPanel.Width - 100);
            int PointY = random.Next(20, CanvasPanel.Height - 100);

            point2D = new Point2D(PointX, PointY);
            _currentRectangleInList = new Rectangle(Length, Width, point2D);
            _rectanglesList.Add(_currentRectangleInList);
            PanelRectanglesListBox.Items.Add(
                $"{_currentRectangleInList.Id}: " +
                $"(X= {_currentRectangleInList.Center.X}; " +
                $"Y = {_currentRectangleInList.Center.Y}; " +
                $"W= {_currentRectangleInList.Width}; " +
                $"H= {_currentRectangleInList.Length})"
                );

            Panel currentPanelRectangle = new Panel();
            currentPanelRectangle.Location = new Point(PointX, PointY);
            currentPanelRectangle.Size = new Size(Width, Length);
            currentPanelRectangle.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            currentPanelRectangle.BorderStyle = BorderStyle.FixedSingle;
            CanvasPanel.Controls.Add(currentPanelRectangle);
            _rectanglePanels.Add(currentPanelRectangle);
            FindCollision();
        }

        private void PanelDeleteRectangleButton_Click(object sender, EventArgs e)
        {
            int indexPanelRectangle = PanelRectanglesListBox.SelectedIndex;
            _currentRectangleInList = _rectanglesList[indexPanelRectangle];
            PanelRectanglesListBox.Items.RemoveAt(indexPanelRectangle);
            _rectanglesList.Remove(_currentRectangleInList);
            CanvasPanel.Controls.RemoveAt(indexPanelRectangle);
            _rectanglePanels.RemoveAt(indexPanelRectangle);
            // TODO: обнуление ID-шника при удалении прямоугольника
            FindCollision();
        }

        private void PanelRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearRectangleInfo();
            if (PanelRectanglesListBox.SelectedIndex != -1)
            {
                int indexPanelRectangle = PanelRectanglesListBox.SelectedIndex;
                _currentRectangleInList = _rectanglesList[indexPanelRectangle];
                PanelIdTextBox.Text = _currentRectangleInList.Id.ToString();
                PanelXTextBox.Text = _currentRectangleInList.Center.X.ToString();
                PanelYTextBox.Text = _currentRectangleInList.Center.Y.ToString();
                PanelWidthTextBox.Text = _currentRectangleInList.Width.ToString();
                PanelLengthTextBox.Text = _currentRectangleInList.Length.ToString();
            }
            else
            {
                return;
            }
        }

        private void ClearRectangleInfo()
        {
            PanelIdTextBox.Clear();
            PanelXTextBox.Clear();
            PanelYTextBox.Clear();
            PanelWidthTextBox.Clear();
            PanelLengthTextBox.Clear();
        }

        private void PanelWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (PanelRectanglesListBox.SelectedIndex != -1)
                {
                    if (!int.TryParse(PanelWidthTextBox.Text, out var temp))
                    {
                        PanelWidthTextBox.BackColor = System.Drawing.Color.LightPink;
                        return;
                    }

                    var indexPanel = PanelRectanglesListBox.SelectedIndex;
                    var widthRectangle = Convert.ToInt32(PanelWidthTextBox.Text);
                    _currentRectangleInList.Width = widthRectangle;
                    _rectanglePanels[indexPanel].Width = widthRectangle; // изменение ширины прямоугольника
                    PanelWidthTextBox.BackColor = System.Drawing.Color.White;
                    FindCollision();
                }
            }
            catch (FormatException)
            {
                PanelWidthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Введите число.");
            }
            catch (OverflowException)
            {
                PanelWidthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Некорректное значение.");
            }
        }

        private void PanelLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (PanelRectanglesListBox.SelectedIndex != -1)
                {
                    if (!int.TryParse(PanelLengthTextBox.Text, out var temp))
                    {
                        PanelLengthTextBox.BackColor = System.Drawing.Color.LightPink;
                        return;
                    }

                    var indexPanel = PanelRectanglesListBox.SelectedIndex;
                    var lengthRectangle = Convert.ToInt32(PanelLengthTextBox.Text);
                    _currentRectangleInList.Length = lengthRectangle;
                    _rectanglePanels[indexPanel].Height = lengthRectangle; // изменение высоты прямоугольника
                    PanelLengthTextBox.BackColor = System.Drawing.Color.White;
                    FindCollision();
                }
            }
            catch (FormatException)
            {
                PanelLengthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Введите число.");
            }
            catch (OverflowException)
            {
                PanelLengthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Некорректное значение.");
            }
        }

        private void PanelXTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (PanelRectanglesListBox.SelectedIndex != -1)
                {
                    if (!int.TryParse(PanelXTextBox.Text, out var temp))
                    {
                        PanelXTextBox.BackColor = System.Drawing.Color.LightPink;
                        return;
                    }

                    var indexPanel = PanelRectanglesListBox.SelectedIndex;
                    var PointXRectangle = Convert.ToInt32(PanelXTextBox.Text);
                    _currentRectangleInList.Center.X = PointXRectangle;
                    var temporary = _rectanglePanels[indexPanel].Location.Y;
                    _rectanglePanels[indexPanel].Location = new Point(PointXRectangle, _rectanglePanels[indexPanel].Location.Y);
                    PanelXTextBox.BackColor = System.Drawing.Color.White;
                    FindCollision();
                }
            }
            catch (FormatException)
            {
                PanelXTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Введите число.");
            }
            catch (OverflowException)
            {
                PanelXTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Некорректное значение.");
            }
        }

        private void PanelYTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (PanelRectanglesListBox.SelectedIndex != -1)
                {
                    if (!int.TryParse(PanelYTextBox.Text, out var temp))
                    {
                        PanelYTextBox.BackColor = System.Drawing.Color.LightPink;
                        return;
                    }

                    var indexPanel = PanelRectanglesListBox.SelectedIndex;
                    var PointYRectangle = Convert.ToInt32(PanelYTextBox.Text);
                    _currentRectangleInList.Center.Y = PointYRectangle;
                    _rectanglePanels[indexPanel].Location = new Point(_rectanglePanels[indexPanel].Location.X, PointYRectangle);
                    PanelYTextBox.BackColor = System.Drawing.Color.White;
                    FindCollision();
                }
            }
            catch (FormatException)
            {
                PanelYTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Введите число.");
            }
            catch (OverflowException)
            {
                PanelYTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Некорректное значение.");
            }
        }

        private void FindCollision()
        {
            if (_rectanglesList.Count > 0)
            {
                for (int i = 0; i < _rectanglesList.Count; i++)
                {
                    _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
                }

                for (int i = 0; i < _rectanglesList.Count; i++)
                {
                    for (int j = 0; j < _rectanglesList.Count; j++)
                    {
                        if (_rectanglePanels[i] != _rectanglePanels[j])
                        {
                            if (CollisionManager.IsCollision(_rectanglesList[i], _rectanglesList[j]))
                            {
                                _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                                _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                            }
                        }
                    }
                }
            }
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            try
            {
                var intIndex = PanelRectanglesListBox.SelectedIndex;
                _currentRectangleInList = _rectanglesList[intIndex];
                PanelRectanglesListBox.Items.RemoveAt(intIndex);

                var tempString =
                    $"{_currentRectangleInList.Id}: " +
                    $"(X= {_currentRectangleInList.Center.X}; " +
                    $"Y = {_currentRectangleInList.Center.Y}; " +
                    $"W= {_currentRectangleInList.Width}; " +
                    $"H= {_currentRectangleInList.Length})";

                PanelRectanglesListBox.Items.Insert(intIndex, tempString);
            }
            catch
            {

            }
        }
    }
}