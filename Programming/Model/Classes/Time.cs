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
    /// Возвращает и задает часы. Должны быть в диапазоне от 0 до 23.
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
    /// Возвращает и задает минуты. Должны быть в диапазоне от 0 до 59.
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
    /// Возвращает и задает секунды. Должны быть в диапазоне от 0 до 59.
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
    /// Создает пустой экземпляр класса <see cref="Time"/>.
    /// </summary>
    public Time()
    {

    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Time"/>.
    /// </summary>
    /// <param name="seconds">Секунды. Должны быть в диапазоне от 0 до 59.</param>
    public Time(int seconds)
    {
        this.Seconds = seconds;
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Time"/>.
    /// </summary>
    /// <param name="seconds">Секунды. Должны быть в диапазоне от 0 до 59.</param>
    /// <param name="minutes">Минуты. Должны быть в диапазоне от 0 до 59.</param>
    public Time(int seconds, int minutes)
    {
        this.Seconds = seconds;
        this.Minutes = minutes;
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Time"/>.
    /// </summary>
    /// <param name="seconds">Секунды. Должны быть в диапазоне от 0 до 59.</param>
    /// <param name="minutes">Минуты. Должны быть в диапазоне от 0 до 59.</param>
    /// <param name="hours">Часы. Должны быть в диапазоне от 0 до 23.</param>
    public Time(int seconds, int minutes, int hours)
    {
        this.Seconds = seconds;
        this.Minutes = minutes;
        this.Hours = hours;
    }
}