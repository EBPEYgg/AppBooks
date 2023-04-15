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
    /// Возвращает и задает имя контакта. Должно состоять только из латиницы.
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
    /// Возвращает и задает фамилию контакта. Должно состоять только из латиницы.
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
    /// Возвращает и задает номер телефона контакта. Должен состоять из 11 символов.
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
    /// Создает пустой экземпляр класса <see cref="ContactPhone"/>.
    /// </summary>
    public ContactPhone()
    {

    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="ContactPhone"/>.
    /// </summary>
    /// <param name="id">Уникальный идентификатор контакта.</param>
    /// <param name="name">Имя контакта. Должно состоять только из латиницы.</param>
    /// <param name="surname">Фамилия контакта. Должно состоять только из латиницы.</param>
    /// <param name="number">Номер контакта. Должен состоять из 11 символов.</param>
    public ContactPhone(int id, string? name, string? surname, int number)
    {
        this.Id = id;
        this.Name = name;
        this.Surname = surname;
        this.Number = number;
    }
}