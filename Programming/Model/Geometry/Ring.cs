/// <summary>
/// Класс, описывающий геометрическое кольцо.
/// </summary>
internal class Ring
{
    private double _internalRadius;
    private double _externalRadius;
    //private double _area;

    public double InternalRadius { get; set; }

    public double ExternalRadius { get; set; }

    public double Area
    {
        private get
        {
            if (Validator.AssertOnPositiveValue(_internalRadius))
                if (Validator.AssertOnPositiveValue(_externalRadius))
                {
                    var internalArea = _internalRadius * _internalRadius * Math.PI;
                    var externalArea = _externalRadius * _externalRadius * Math.PI;
                    Area = externalArea - internalArea;
                }
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
