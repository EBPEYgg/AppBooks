namespace Programming.Model.Classes
{
    internal class Rectangle
    {
        private double lengthRectangle
        {
            get { return lengthRectangle; }
            set { if (Validator.AssertOnPositiveValue(lengthRectangle)) lengthRectangle = value; }
        }
        private double widthRectangle
        {
            get { return widthRectangle; }
            set { if (Validator.AssertOnPositiveValue(widthRectangle)) widthRectangle = value; }
        }
        private string? colorRectangle { get; set; }

        public Rectangle()
        {
            lengthRectangle = 0;
            widthRectangle = 0;
            colorRectangle = "";
        }
    }
}
