/// <summary>
/// Класс, описывающий фильм.
/// </summary>
internal class Film
{
    /// <summary>
    /// Длительность фильма.
    /// </summary>
    private int _time;
    /// <summary>
    /// Год выпуска фильма.
    /// </summary>
    private int _year;
    /// <summary>
    /// Рейтинг фильма.
    /// </summary>
    private double _rating;

    /// <summary>
    /// Название фильма.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Длительность фильма.
    /// </summary>
    public int Time
    {
        get 
        { 
            return _time; 
        }
        set
        {
            if (Validator.AssertOnPositiveValue(value))
            {
                _time = value;
            }
        }
    }

    /// <summary>
    /// Год выпуска фильма.
    /// </summary>
    public int Year
    {
        get 
        { 
            return _year; 
        }
        set
        {
            if (Validator.AssertValueInRange(value, 1900, 2024))
            {
                _year = value;
            }
        }
    }

    /// <summary>
    /// Жанр фильма.
    /// </summary>
    public string? Genre { get; set; }

    /// <summary>
    /// Рейтинг фильма.
    /// </summary>
    public double Rating
    {
        get 
        { 
            return _rating; 
        }
        set
        {
            if (Validator.AssertValueInRange(value, 0, 10.1))
            {
                _rating = value;
            }
        }
    }

    /// <summary>
    /// Пустой конструктор фильма.
    /// </summary>
    public Film()
    {

    }

    /// <summary>
    /// Конструктор фильма.
    /// </summary>
    /// <param name="name">Название фильма.</param>
    /// <param name="time">Длительность фильма.</param>
    /// <param name="year">Год выпуска фильма.</param>
    /// <param name="genre">Жанр фильма.</param>
    /// <param name="rating">Рейтинг фильма.</param>
    public Film(string? name, int time, int year, string? genre, double rating)
    {
        this.Name = name;
        this.Time = time;
        this.Year = year;
        this.Genre = genre;
        this.Rating = rating;
    }
}