namespace Programming.Model.Classes
{
    internal class Rectangle
    {
        private double length
        {
            get { return length; }
            set { if (Validator.AssertOnPositiveValue(length)) length = value; }
        }
        private double width
        {
            get { return width; }
            set { if (Validator.AssertOnPositiveValue(width)) width = value; }
        }
        private string? color { get; set; }

        public Rectangle(double length, double width, string? color)
        {
            this.length = length;
            this.width = width;
            this.color = color;
        }
    }
}
