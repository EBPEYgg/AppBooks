/// <summary>
/// Класс прямоугольника.
/// </summary>
internal class Rectangle
{
    /// <summary>
    /// Длина прямоугольника.
    /// </summary>
    private double _length;
    /// <summary>
    /// Ширина прямоугольника.
    /// </summary>
    private double _width;
    /// <summary>
    /// Счетчик прямоугольников.
    /// </summary>
    private static int _allRectanglesCount = 0;
    /// <summary>
    /// Уникальный идентификатор прямоугольника.
    /// </summary>
    private int _id;

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

    /// <summary>
    /// Центр прямоугольника.
    /// </summary>
    public Point2D? Center { get; set; }

    /// <summary>
    /// Счетчик прямоугольников.
    /// </summary>
    public static int AllRectanglesCount
    { 
        get 
        { 
            return _allRectanglesCount;
        }
        private set
        {
            _allRectanglesCount = value; 
        }
    }

    /// <summary>
    /// ID прямоугольника.
    /// </summary>
    public int Id 
    { 
        get 
        { 
            return _id;
        }
        private set
        {
            _id = value;
        }
    }

    /// <summary>
    /// Пустой конструктор класса прямоугольников.
    /// </summary>
    public Rectangle()
    {

    }

    /// <summary>
    /// Конструктор класса прямоугольников.
    /// </summary>
    /// <param name="length">Длина прямоугольника.</param>
    /// <param name="width">Ширина прямоугольника.</param>
    /// <param name="center">Координаты центра прямоугольника.</param>
    public Rectangle(double length, double width, Point2D center)
    {
        this.Length = length;
        this.Width = width;
        this.Center = center;
        _allRectanglesCount++;
        Id = _allRectanglesCount;
    }

    /// <summary>
    /// Конструктор класса прямоугольников.
    /// </summary>
    /// <param name="length">Длина прямоугольника.</param>
    /// <param name="width">Ширина прямоугольника.</param>
    /// <param name="color">Цвет прямоугольника.</param>
    /// <param name="center">Координаты центра прямоугольника.</param>
    public Rectangle(double length, double width, string? color, Point2D center)
    {
        this.Length = length;
        this.Width = width;
        this.Color = color;
        this.Center = center;
        _allRectanglesCount++;
        Id = _allRectanglesCount;
    }
}