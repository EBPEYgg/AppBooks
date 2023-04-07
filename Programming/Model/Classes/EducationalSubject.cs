/// <summary>
/// Класс, описывающий дисциплину (как запись в зачетной книжке).
/// </summary>
internal class EducationalSubject
{
    /// <summary>
    /// Кол-во часов, отведенных на изучение дисциплины.
    /// </summary>
    private int _learnHoursTime;
    /// <summary>
    /// Оценка за дисциплину.
    /// </summary>
    private int _mark;

    /// <summary>
    /// Название учебной дисциплины.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Кол-во часов, отведенных на изучение дисциплины.
    /// </summary>
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

    /// <summary>
    /// Оценка за дисциплину.
    /// </summary>
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

    /// <summary>
    /// Пустой конструктор класса учебной дисциплины.
    /// </summary>
    public EducationalSubject()
    {

    }

    /// <summary>
    /// Конструктор класса учебной дисциплины.
    /// </summary>
    /// <param name="name">Название учебной дисциплины.</param>
    /// <param name="learnHoursTime">Кол-во часов, отведенных на изучение дисциплины.</param>
    /// <param name="mark">Оценка за дисциплину.</param>
    public EducationalSubject(string? name, int learnHoursTime, int mark)
    {
        this.Name = name;
        this.LearnHoursTime = learnHoursTime;
        this.Mark = mark;
    }
}