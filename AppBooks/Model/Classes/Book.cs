using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
// TODO: namespace
/// <summary>
/// Класс, описывающий книгу.
/// </summary>
internal class Book : ICloneable
{
    /// <summary>
    /// Название книги.
    /// </summary>
    private string? _name;
    /// <summary>
    /// Год выхода книги.
    /// </summary>
    private int _year;
    /// <summary>
    /// Имя автора книги.
    /// </summary>
    private string? _author;
    /// <summary>
    /// Количество страниц в книге.
    /// </summary>
    private int _page;
    /// <summary>
    /// Жанр книги.
    /// </summary>
    private string? _genre;

    /// <summary>
    /// Возвращает и задает название книги. Должно быть написано на латинице 
    /// и иметь длину в диапазоне от 0 до 50 символов (не включительно).
    /// </summary>
    public string Name
    {
        get => _name;
        set
        {
            if (!Validator.CheckStringContainsOnlyEnglishLetters(value))
            {
                throw new ArgumentException($"Допустима только латиница в названии книги.");
            }

            Validator.AssertValueInRange(value.Length, 0, 50);
            _name = value;
        }
    }

    /// <summary>
    /// Возвращает и задает год выпуска книги. 
    /// Должен находиться в диапазоне от 0 до 2024 (не включительно).
    /// </summary>
    public int Year
    {
        get => _year;
        set 
        {
            Validator.AssertValueInRange(value, 1, 2024);
            _year = value;
        }
    }

    /// <summary>
    /// Возвращает и задает имя автора. Должно быть написано на латинице.
    /// </summary>
    public string Author
    {
        get => _author;
        set
        {
            if (!Validator.CheckStringContainsOnlyEnglishLetters(value))
            {
                throw new ArgumentException($"Допустима только латиница в имени автора.");
            }

            _author = value;
        }
    }

    /// <summary>
    /// Возвращает и задает количество страниц в книге. Должно быть больше нуля.
    /// </summary>
    public int Page
    {
        get => _page;
        set 
        {
            Validator.AssertOnPositiveValue(value);
            _page = value;
        }
    }

    /// <summary>
    /// Возвращает и задает жанр. Должен быть написан на латинице.
    /// </summary>
    // TODO: можно использовать авто свойство
    public string Genre
    {
        get => _genre;
        set
        {
            _genre = value;
        }
    }

    /// <summary>
    /// Создает пустой экземпляр класса <see cref="Book"/>.
    /// </summary>
    public Book()
    {

    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Book"/>.
    /// </summary>
    /// <param name="name">Название. Должно быть написано на латинице 
    /// и иметь длину в диапазоне от 0 до 50 символов (не включительно).</param>
    /// <param name="year">Год выхода. Должен находиться в диапазоне от 0 до 2024 (не включительно).</param>
    /// <param name="author">Автор.</param>
    /// <param name="page">Количество страниц. Должно быть больше нуля.</param>
    /// <param name="genre">Жанр. Должен быть написан на латинице.</param>
    public Book(string name, int year, string author, int page, string genre)
    {
        this.Name = name;
        this.Year = year;
        this.Author = author;
        this.Page = page;
        this.Genre = genre;
    }

    /// <summary>
    /// Переопределение метода ToString() для класса <see cref="Book"/>.
    /// </summary>
    /// <returns>Строка: "Название книги / Имя автора / Жанр ".</returns>
    public override string ToString()
    {
        return $"{Name} / " +
            $"{Author} / " +
            $"{Genre}";
    }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}