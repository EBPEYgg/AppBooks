/// <summary>
/// Класс, описывающий время.
/// </summary>
internal class Time
{
    /// <summary>
    /// Часы.
    /// </summary>
    private int _hours;
    /// <summary>
    /// Минуты.
    /// </summary>
    private int _minutes;
    /// <summary>
    /// Секунды.
    /// </summary>
    private int _seconds;

    /// <summary>
    /// Часы. Должны быть в диапазоне от 0 до 23.
    /// </summary>
    public int Hours
    {
        get
        {
            return _hours;
        }
        set
        {
            if (Validator.AssertValueInRange(value, -1, 24))
            {
                _hours = value;
            }
        }
    }

    /// <summary>
    /// Минуты. Должны быть в диапазоне от 0 до 59.
    /// </summary>
    public int Minutes
    {
        get
        {
            return _minutes;
        }
        set
        {
            if (Validator.AssertValueInRange(value, -1, 60))
            {
                _minutes = value;
            }
        }
    }

    /// <summary>
    /// Секунды. Должны быть в диапазоне от 0 до 59.
    /// </summary>
    public int Seconds
    {
        get
        {
            return _seconds;
        }
        set
        {
            if (Validator.AssertValueInRange(value, -1, 60))
            {
                _seconds = value;
            }
        }
    }

    /// <summary>
    /// Пустой конструктор класса.
    /// </summary>
    public Time()
    {

    }

    /// <summary>
    /// Конструктор класса.
    /// </summary>
    /// <param name="seconds">Секунды.</param>
    public Time(int seconds)
    {
        this.Seconds = seconds;
    }

    /// <summary>
    /// Конструктор класса.
    /// </summary>
    /// <param name="seconds">Секунды.</param>
    /// <param name="minutes">Минуты.</param>
    public Time(int seconds, int minutes)
    {
        this.Seconds = seconds;
        this.Minutes = minutes;
    }

    /// <summary>
    /// Конструктор класса.
    /// </summary>
    /// <param name="seconds">Секунды.</param>
    /// <param name="minutes">Минуты.</param>
    /// <param name="hours">Часы.</param>
    public Time(int seconds, int minutes, int hours)
    {
        this.Seconds = seconds;
        this.Minutes = minutes;
        this.Hours = hours;
    }
}