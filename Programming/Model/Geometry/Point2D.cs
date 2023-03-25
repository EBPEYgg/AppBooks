/// <summary>
/// Класс, описывающий центр геометрической фигуры.
/// </summary>
internal class Point2D
{
    /// <summary>
    /// Координата X.
    /// </summary>
    private double _x;
    /// <summary>
    /// Координата Y.
    /// </summary>
    private double _y;

    /// <summary>
    /// Координата X.
    /// </summary>
    public double X
    {
        get { return _x; }
        private set
        {
            if (!Validator.AssertOnPositiveValue(value))
            {
                throw new ArgumentException("Ошибка в задании X координаты.");
            }
            if (Validator.AssertOnPositiveValue(value))
            {
                _x = value;
            }
        }
    }

    /// <summary>
    /// Координата Y.
    /// </summary>
    public double Y
    {
        get { return _y; }
        private set
        {
            if (!Validator.AssertOnPositiveValue(value))
            {
                throw new ArgumentException("Ошибка в задании Y координаты.");
            }
            if (Validator.AssertOnPositiveValue(value))
            {
                _y = value;
            }
        }
    }

    /// <summary>
    /// Пустой конструктор класса центра координат.
    /// </summary>
    public Point2D()
    {

    }

    /// <summary>
    /// Конструктор класса центра координат.
    /// </summary>
    /// <param name="x">Координата X.</param>
    /// <param name="y">Координата Y.</param>
    public Point2D(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }
}
