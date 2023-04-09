/// <summary>
/// Класс, описывающий прямоугольник.
/// </summary>
internal class Rectangle
{
    /// <summary>
    /// Высота прямоугольника.
    /// </summary>
    private double _height;
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
    /// Возвращает и задает высоту прямоугольника. Должна быть больше нуля.
    /// </summary>
    public double Height
    {
        get 
        { 
            return _height; 
        }
        set
        {
            if (Validator.AssertOnPositiveValue(value))
            {
                _height = value;
            }
        }
    }

    /// <summary>
    /// Возвращает и задает ширина прямоугольника. Должна быть больше нуля.
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
    /// Возвращает и задает цвет прямоугольника.
    /// </summary>
    public string? Color { get; set; }

    /// <summary>
    /// Возвращает и задает центр прямоугольника.
    /// </summary>
    public Point2D? Center { get; set; }

    /// <summary>
    /// Возвращает счетчик прямоугольников.
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
    /// Возвращает уникальный идентификатор прямоугольника.
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
    /// Создает пустой экземпляр класса <see cref="Rectangle"/>.
    /// </summary>
    public Rectangle()
    {

    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Rectangle"/>.
    /// </summary>
    /// <param name="height">Высота. Должна быть больше нуля.</param>
    /// <param name="width">Ширина. Должна быть больше нуля.</param>
    /// <param name="center">Координаты центра прямоугольника.</param>
    public Rectangle(double height, double width, Point2D center)
    {
        this.Height = height;
        this.Width = width;
        this.Center = center;
        _allRectanglesCount++;
        Id = _allRectanglesCount;
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Rectangle"/>.
    /// </summary>
    /// <param name="height">Высота. Должна быть больше нуля.</param>
    /// <param name="width">Ширина. Должна быть больше нуля.</param>
    /// <param name="color">Цвет прямоугольника.</param>
    /// <param name="center">Координаты центра прямоугольника.</param>
    public Rectangle(double height, double width, string? color, Point2D center)
    {
        this.Height = height;
        this.Width = width;
        this.Color = color;
        this.Center = center;
        _allRectanglesCount++;
        Id = _allRectanglesCount;
    }
}