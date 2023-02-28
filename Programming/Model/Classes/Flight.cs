namespace Programming.Model.Classes
{
    internal class Flight
    {
        private string? departurePoint { get; set; }
        private string? destination { get; set; }
        private int flightTimeMinute
        {
            get { return flightTimeMinute; }
            set { if (Validator.AssertOnPositiveValue(flightTimeMinute)) flightTimeMinute = value; }
        }

        public Flight(string? departurePoint, string? destination, int flightTimeMinute)
        {
            this.departurePoint = departurePoint;
            this.destination = destination;
            this.flightTimeMinute = flightTimeMinute;
        }
    }
}
