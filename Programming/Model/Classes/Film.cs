namespace Programming.Model.Classes
{
    internal class Film
    {
        private string? nameFilm { get; set; }
        private int timeFilm
        {
            get { return timeFilm; }
            set { if (Validator.AssertOnPositiveValue(timeFilm)) timeFilm = value; }
        }
        private int yearFilm
        {
            get { return yearFilm; }
            set { if (Validator.AssertValueInRange(yearFilm, 1900, 2024)) yearFilm = value; }
        }
        private string? genreFilm { get; set; }
        private double ratingFilm
        {
            get { return ratingFilm; }
            set { if (Validator.AssertOnPositiveValue(ratingFilm) && ratingFilm <= 10) ratingFilm = value; }
        }

        public Film(string? nameFilm, int timeFilm, int yearFilm, string? genreFilm, double ratingFilm)
        {
            this.nameFilm = nameFilm;
            this.timeFilm = timeFilm;
            this.yearFilm = yearFilm;
            this.genreFilm = genreFilm;
            this.ratingFilm = ratingFilm;
        }
    }
}
