namespace Programming.View
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, содержащий FilmsGroupBox.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Фиксированное количество создаваемых фильмов на вкладке Classes.
        /// </summary>
        const int M = 8;
        /// <summary>
        /// Инициализация массива с фильмами размерерностью M.
        /// </summary>
        private Film[] _films = new Film[M];
        /// <summary>
        /// Массив с данными текущего выбранного фильма.
        /// </summary>
        private Film _currentFilm = new Film();

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

        public MoviesControl()
        {
            InitializeComponent();

            Random random = new Random();

            string[] nameFilms = { 
                "Episode I – The Phantom Menace", 
                "Episode II – Attack of the Clones", 
                "Episode III – Revenge of the Sith", 
                "Episode IV – A New Hope", 
                "Episode V – The Empire Strikes Back", 
                "Episode VI – Return of the Jedi" };
            string[] genreFilms = { "Science fiction", "Fantasy", "Action Movie", "Adventures" };

            for (int j = 0; j < 6; j++)
            {
                var CurrentNameFilm = PickRandomAmongStringArray(nameFilms);
                var CurrentGenreFilm = PickRandomAmongStringArray(genreFilms);
                var Time = random.Next(121, 152);
                var Year = random.Next(1977, 2006);
                var Rating = random.Next(1, 11);
                _films[j] = new Film(CurrentNameFilm, Time, Year, CurrentGenreFilm, Rating);
                FilmsListBox.Items.Add($"{nameFilms[j]}");
            }
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
    }
}