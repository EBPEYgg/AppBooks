/// <summary>
/// Класс, описывающий фильм.
/// </summary>
internal class Film
{
    /// <summary>
    /// Длительность в минутах.
    /// </summary>
    private int _time;

    /// <summary>
    /// Год выпуска.
    /// </summary>
    private int _year;

    /// <summary>
    /// Рейтинг.
    /// </summary>
    private double _rating;

    /// <summary>
    /// Возвращает и задает название фильма.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Возвращает и задает длительность фильма. Должна быть больше нуля.
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
    /// Возвращает и заает год выпуска фильма. Должен находиться в диапазоне от 1900 до 2023.
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
    /// Возвращает и задает жанр фильма.
    /// </summary>
    public string? Genre { get; set; }

    /// <summary>
    /// Возвращает и задает рейтинг фильма. Должен находиться в диапазоне от 0 до 10.
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
    /// Создает пустой экземпляр класса <see cref="Film"/>.
    /// </summary>
    public Film()
    {

    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Film"/>.
    /// </summary>
    /// <param name="name">Название.</param>
    /// <param name="time">Длительность. Должна быть больше нуля.</param>
    /// <param name="year">Год выпуска. Должен находиться в диапазоне от 1900 до 2023.</param>
    /// <param name="genre">Жанр.</param>
    /// <param name="rating">Рейтинг. Должен находиться в диапазоне от 0 до 10.</param>
    public Film(string? name, int time, int year, string? genre, double rating)
    {
        this.Name = name;
        this.Time = time;
        this.Year = year;
        this.Genre = genre;
        this.Rating = rating;
    }
}