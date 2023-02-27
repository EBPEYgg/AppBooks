namespace Programming.Model.Classes
{
    internal class Rectangle
    {
        private double lengthRectangle
        {
            get { return lengthRectangle; }
            set { if (lengthRectangle > 0) lengthRectangle = value; }
        }
        private double widthRectangle
        {
            get { return widthRectangle; }
            set { if (widthRectangle > 0) widthRectangle = value; }
        }
        private string? colorRectangle { get; set; }
    }
}
