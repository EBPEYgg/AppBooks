/// <summary>
/// Класс, описывающий контакт в телефоне.
/// </summary>

internal class ContactPhone
{
    private string? _name;
    private string? _surname;
    private int _number;
    private string? propertyError;

    /// <summary>
    /// ID контакта.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Имя контакта.
    /// </summary>
    public string? Name
    {
        get 
        { 
            return _name;
        }
        set 
        {
            try
            {
                propertyError = nameof(Name);
                if (!AssertStringContainsOnlyEnglishLetters(value))
                {
                    throw new ArgumentException($"Допустима только латиница в свойстве {propertyError}");
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
                propertyError = nameof(Surname);
                if (!AssertStringContainsOnlyEnglishLetters(value))
                {
                    throw new ArgumentException($"Допустима только латиница в свойстве {propertyError}");
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
        int flag = 0;
        for (int i = 0; i < name?.Length; i++)
        {
            if (!((name[i] >= 'a') && (name[i] <= 'z')) || ((name[i] >= 'A') && (name[i] <= 'Z')))
            {
                flag += 1;
            }
        }
        if (flag > 0)
        {
            return false;
        }
        return true;
    }

    public ContactPhone()
    {

    }

    public ContactPhone(int id, string? name, string? surname, int number)
    {
        this.Id = id;
        this.Name = name;
        this.Surname = surname;
        this.Number = number;
    }
}