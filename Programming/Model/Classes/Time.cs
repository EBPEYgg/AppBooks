internal class Time
{
    private int _hours;
    private int _minutes;
    private int _seconds;

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

    public Time()
    {

    }

    public Time(int seconds)
    {
        this.Seconds = seconds;
    }

    public Time(int seconds, int minutes)
    {
        this.Seconds = seconds;
        this.Minutes = minutes;
    }

    public Time(int seconds, int minutes, int hours)
    {
        this.Seconds = seconds;
        this.Minutes = minutes;
        this.Hours = hours;
    }
}