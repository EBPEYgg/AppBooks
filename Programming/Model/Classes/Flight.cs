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
    /// Возвращает и задает пункт вылета.
    /// </summary>
    public string? DeparturePoint { get; set; }

    /// <summary>
    /// Возвращает и задает пункт назначения.
    /// </summary>
    public string? Destination { get; set; }

    /// <summary>
    /// Возвращает и задает время полета в минутах. Должно быть больше нуля.
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
    /// Создает пустой экземпляр класса <see cref="Flight"/>.
    /// </summary>
    public Flight()
    {

    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Flight"/>.
    /// </summary>
    /// <param name="departurePoint">Пункт вылета.</param>
    /// <param name="destination">Пункт назначения.</param>
    /// <param name="flightTimeMinute">Время полета в минутах. Должно быть больше нуля.</param>
    public Flight(string? departurePoint, string? destination, int flightTimeMinute)
    {
        this.DeparturePoint = departurePoint;
        this.Destination = destination;
        this.FlightTimeMinute = flightTimeMinute;
    }
}