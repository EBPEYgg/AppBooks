namespace Programming.Model.Classes
{
    internal class Time
    {
        private int hours
        {
            get { return hours; }
            set { if (hours >= 0 && hours < 24) hours = value; }
        }
        private int minutes
        {
            get { return minutes; }
            set { if (minutes >= 0 && minutes < 60) minutes = value; }
        }
        private int seconds
        {
            get { return seconds; }
            set { if (Validator.AssertValueInRange(seconds, -1, 61)) seconds = value; }
        }

        public Time(int seconds, int minutes, int hours)
        {
            seconds = minutes = hours = 0;
        }
    }
}
