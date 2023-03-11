internal class EducationalSubject
{
    private int _learnHoursTime;
    private int _mark;

    public string? Name { get; set; }

    public int LearnHoursTime
    {
        get 
        { 
            return _learnHoursTime; 
        }
        set 
        {
            if (Validator.AssertOnPositiveValue(value))
            {
                _learnHoursTime = value;
            }
        }
    }

    public int Mark
    {
        get 
        { 
            return _mark; 
        }
        set 
        {
            if (Validator.AssertValueInRange(value, 0, 6))
            {
                _mark = value;
            }
        }
    }

    public EducationalSubject()
    {

    }

    public EducationalSubject(string? name, int learnHoursTime, int mark)
    {
        this.Name = name;
        this.LearnHoursTime = learnHoursTime;
        this.Mark = mark;
    }
}