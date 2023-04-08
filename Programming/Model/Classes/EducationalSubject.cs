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
    /// Возвращает и задает название учебной дисциплины.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Возвращает и задает количествово часов, отведенных на изучение дисциплины. Должно быть больше нуля.
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
    /// Возвращает и задает оценку за дисциплину. Должна находиться в диапазоне от 1 до 5.
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
    /// Создает пустой экземпляр класса <see cref="EducationalSubject"/>.
    /// </summary>
    public EducationalSubject()
    {

    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="EducationalSubject"/>.
    /// </summary>
    /// <param name="name">Название учебной дисциплины.</param>
    /// <param name="learnHoursTime">Количество часов, отведенных на изучение дисциплины. Должно быть больше нуля.</param>
    /// <param name="mark">Оценка за дисциплину. Должна находиться в диапазоне от 1 до 5.</param>
    public EducationalSubject(string? name, int learnHoursTime, int mark)
    {
        this.Name = name;
        this.LearnHoursTime = learnHoursTime;
        this.Mark = mark;
    }
}