namespace Programming.Model.Classes
{
    internal class Film
    {
        private string? nameFilm { get; set; }
        private int timeFilm
        {
            get { return timeFilm; }
            set { if (timeFilm > 0) timeFilm = value; }
        }
        private int yearFilm
        {
            get { return yearFilm; }
            set { if (yearFilm > 1900 && yearFilm < 2024) yearFilm = value; }
        }
        private string? genreFilm { get; set; }
        private double ratingFilm
        {
            get { return ratingFilm; }
            set { if (ratingFilm > 0 && ratingFilm <= 10) ratingFilm = value; }
        }
    }
}
