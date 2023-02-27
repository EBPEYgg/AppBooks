namespace Programming.Model.Classes
{
    internal class Flight
    {
        private string? departurePoint { get; set; }
        private string? destination { get; set; }
        private int flightTimeMinute
        {
            get { return flightTimeMinute; }
            set { if (flightTimeMinute > 0) flightTimeMinute = value; }
        }
    }
}
