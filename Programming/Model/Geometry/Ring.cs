/// <summary>
/// Класс, описывающий геометрическое кольцо.
/// </summary>
internal class Ring
{

    private double _internalRadius;
    private double _externalRadius;
    private Point2D? Point2D;

    /// <summary>
    /// Внутренний радиус кольца.
    /// </summary>
    public double InternalRadius
    {
        get { return _internalRadius; }
        set
        {
            if (!Validator.AssertOnPositiveValue(value))
            {
                throw new ArgumentException("Ошибка в задании внутреннего радиуса.");
            }
            if (Validator.AssertOnPositiveValue(value))
            {
                _internalRadius = value;
            }
        }
    }

    /// <summary>
    /// Внешний радиус кольца.
    /// </summary>
    public double ExternalRadius
    {
        get { return _externalRadius; }
        set
        {
            if (!Validator.AssertOnPositiveValue(value))
            {
                throw new ArgumentException("Ошибка в задании внешнего радиуса.");
            }
            if (Validator.AssertOnPositiveValue(value))
            {
                _externalRadius = value;
            }
        }
    }

    /// <summary>
    /// Площадь кольца.
    /// </summary>
    public double Area
    {
        private get
        {
            var internalArea = _internalRadius * _internalRadius * Math.PI;
            var externalArea = _externalRadius * _externalRadius * Math.PI;
            Area = externalArea - internalArea;
            return Area;
        }
        set
        {
            Area = value;
        }
    }

    public Ring()
    {

    }

    public Ring(double internalRadius, double externalRadius, double area)
    {
        this.InternalRadius = internalRadius;
        this.ExternalRadius = externalRadius;
        this.Area = area;
    }
}
