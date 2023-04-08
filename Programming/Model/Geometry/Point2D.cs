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
    /// Задает и возвращает координату X. Должна быть больше нуля.
    /// </summary>
    public double X
    {
        get { return _x; }
        set
        {
            if (!Validator.AssertOnPositiveValue(value))
            {
                throw new ArgumentException("Ошибка в задании X координаты.");
            }
            _x = value;
        }
    }

    /// <summary>
    /// Задает и возвращает координату Y. Должна быть больше нуля.
    /// </summary>
    public double Y
    {
        get { return _y; }
        set
        {
            if (!Validator.AssertOnPositiveValue(value))
            {
                throw new ArgumentException("Ошибка в задании Y координаты.");
            }
            _y = value;
        }
    }

    /// <summary>
    /// Создаёт пустой экземпляр класса <see cref="Point2D"/>.
    /// </summary>
    public Point2D()
    {

    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Point2D"/>.
    /// </summary>
    /// <param name="x">Координата X. Должна быть больше нуля.</param>
    /// <param name="y">Координата Y. Должна быть больше нуля.</param>
    public Point2D(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }
}