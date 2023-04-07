/// <summary>
/// Класс, описывающий контакт в телефоне.
/// </summary>
internal class ContactPhone
{
    /// <summary>
    /// Имя контакта.
    /// </summary>
    private string? _name;
    /// <summary>
    /// Фамилия контакта.
    /// </summary>
    private string? _surname;
    /// <summary>
    /// Номер контакта.
    /// </summary>
    private int _number;

    /// <summary>
    /// Уникальный идентификатор контакта.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Имя контакта.
    /// </summary>
    public string? Name
    {
        get => _name;
        set 
        {
            try
            {
                if (!AssertStringContainsOnlyEnglishLetters(value))
                {
                    throw new ArgumentException($"Допустима только латиница в имени");
                }
                _name = value;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
        }
    }

    /// <summary>
    /// Фамилия контакта.
    /// </summary>
    public string? Surname
    {
        get 
        { 
            return _surname; 
        }
        set 
        {
            try
            {
                if (!AssertStringContainsOnlyEnglishLetters(value))
                {
                    throw new ArgumentException($"Допустима только латиница в фамилии");
                }

                _surname = value;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
        }
    }

    /// <summary>
    /// Номер телефона контакта.
    /// </summary>
    public int Number
    {
        get 
        { 
            return _number; 
        }
        set
        {
            if (_number.ToString().Length == 11)
            {
                _number = value;
            }
        }
    }

    /// <summary>
    /// Метод, который проверяет, содержит ли строка только латиницу.
    /// </summary>
    /// <param name="name">Строка, которую надо проверить.</param>
    /// <returns>True or false.</returns>
    private bool AssertStringContainsOnlyEnglishLetters(string? name)
    {
        bool flag = true;
        foreach (char c in name)
        {
            if (!((c >= 'a') && (c <= 'z')) || ((c >= 'A') && (c <= 'Z')))
            {
                flag = false;
                break;
            }
        }

        return flag;
    }

    /// <summary>
    /// Пустой конструктор класса.
    /// </summary>
    public ContactPhone()
    {

    }

    /// <summary>
    /// Конструктор класса.
    /// </summary>
    /// <param name="id">ID контакта</param>
    /// <param name="name">Имя контакта</param>
    /// <param name="surname">Фамилия контакта</param>
    /// <param name="number">Номер контакта</param>
    public ContactPhone(int id, string? name, string? surname, int number)
    {
        this.Id = id;
        this.Name = name;
        this.Surname = surname;
        this.Number = number;
    }
}