internal class Flight
{
    private int _flightTimeMinute;

    public string? DeparturePoint { get; set; }

    public string? Destination { get; set; }

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

    public Flight()
    {

    }

    public Flight(string? departurePoint, string? destination, int flightTimeMinute)
    {
        this.DeparturePoint = departurePoint;
        this.Destination = destination;
        this.FlightTimeMinute = flightTimeMinute;
    }
}