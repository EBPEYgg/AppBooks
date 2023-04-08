/// <summary>
/// Класс, описывающий геометрическое кольцо.
/// </summary>
internal class Ring
{
    /// <summary>
    /// Внутренний радиус
    /// </summary>
    private double _internalRadius;
    /// <summary>
    /// Внешний радиус.
    /// </summary>
    private double _externalRadius;
    /// <summary>
    /// Центр координат.
    /// </summary>
    private Point2D? Point2D;

    /// <summary>
    /// Задает и возвращает внутренний радиус кольца. Должен быть больше нуля.
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
    /// Задает и возвращает внешний радиус кольца. Должен быть больше нуля.
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
    /// Возвращает площадь кольца.
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

    /// <summary>
    /// Создает пустой экземпляр класса <see cref="Ring"/>.
    /// </summary>
    public Ring()
    {

    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Ring"/>.
    /// </summary>
    /// <param name="internalRadius">Внутренний радиус. Должен быть больше нуля.</param>
    /// <param name="externalRadius">Внешний радиус. Должен быть больше нуля.</param>
    public Ring(double internalRadius, double externalRadius)
    {
        this.InternalRadius = internalRadius;
        this.ExternalRadius = externalRadius;
    }
}