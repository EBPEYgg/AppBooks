/// <summary>
/// Класс, описывающий центр геометрической фигуры.
/// </summary>
internal class Point2D
{
    private double _x;
    private double _y;

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

    public Point2D()
    {

    }

    public Point2D(double _x, double _y)
    {
        X = _x;
        Y = _y;
    }
}
