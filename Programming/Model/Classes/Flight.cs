/// <summary>
/// Класс, описывающий рейс на самолет.
/// </summary>
internal class Flight
{
    /// <summary>
    /// Время полета в минутах.
    /// </summary>
    private int _flightTimeMinute;

    /// <summary>
    /// Пункт вылета.
    /// </summary>
    public string? DeparturePoint { get; set; }

    /// <summary>
    /// Пункт назначения.
    /// </summary>
    public string? Destination { get; set; }

    /// <summary>
    /// Время полета в минутах.
    /// </summary>
    public int FlightTimeMinute
    {
        get 
        { 
            return _flightTimeMinute; 
        }
        set 
        {
            if (Validator.AssertOnPositiveValue(value))
            {
                _flightTimeMinute = value;
            }
        }
    }

    /// <summary>
    /// Пустой конструктор класса.
    /// </summary>
    public Flight()
    {

    }

    /// <summary>
    /// Конструктор класса.
    /// </summary>
    /// <param name="departurePoint">Пункт вылета.</param>
    /// <param name="destination">Пункт назначения.</param>
    /// <param name="flightTimeMinute">Время полета в минутах.</param>
    public Flight(string? departurePoint, string? destination, int flightTimeMinute)
    {
        this.DeparturePoint = departurePoint;
        this.Destination = destination;
        this.FlightTimeMinute = flightTimeMinute;
    }
}