/// <summary>
/// Класс прямоугольника.
/// </summary>

internal class Rectangle
{
    private double _length;
    private double _width;
    private static int _allRectanglesCount;
    private int _id = 0;

    /// <summary>
    /// Длина прямоугольника.
    /// </summary>
    public double Length
    {
        get 
        { 
            return _length; 
        }
        set
        {
            if (Validator.AssertOnPositiveValue(value))
            {
                _length = value;
            }
        }
    }

    /// <summary>
    /// Ширина прямоугольника.
    /// </summary>
    public double Width
    {
        get 
        { 
            return _width; 
        }
        set 
        {
            if (Validator.AssertOnPositiveValue(value))
            {
                _width = value;
            }
        }
    }

    /// <summary>
    /// Цвет прямоугольника.
    /// </summary>
    public string? Color { get; set; }

    public Point2D? Center { get; set; }

    public int AllRectanglesCount 
    { 
        get 
        { 
            return _allRectanglesCount; 
        }
        set 
        { 
            _allRectanglesCount = value; 
        }
    }

    public int Id 
    { 
        get 
        { 
            return _id; 
        }
        set
        {
            _id = value + 1;
        }
    }

    public Rectangle()
    {

    }

    public Rectangle(double length, double width, string? color, Point2D center)
    {
        this.Length = length;
        this.Width = width;
        this.Color = color;
        this.Center = center;
    }
}