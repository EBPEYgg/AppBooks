/// <summary>
/// Класс фильма.
/// </summary>

internal class Film
{
    private int _time;
    private int _year;
    private double _rating;

    public string? Name { get; set; }

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

    public int Year
    {
        get 
        { 
            return _year; 
        }
        set
        {
            if (!Validator.AssertValueInRange(value, 1900, 2024))
            {
                throw new ArgumentException("Неверный год.");
            }
            if (Validator.AssertValueInRange(value, 1900, 2024))
            {
                _year = value;
            }
        }
    }

    public string? Genre { get; set; }

    public double Rating
    {
        get 
        { 
            return _rating; 
        }
        set
        {
            if (value > 10)
            {
                throw new ArgumentException("Некорректный рейтинг.");
            }

            if (Validator.AssertOnPositiveValue(value))
            {
                _rating = value;
            }
        }
    }

    public Film()
    {

    }

    public Film(string? name, int time, int year, string? genre, double rating)
    {
        this.Name = name;
        this.Time = time;
        this.Year = year;
        this.Genre = genre;
        this.Rating = rating;
    }
}
