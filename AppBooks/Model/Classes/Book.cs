﻿/// <summary>
/// Класс, описывающий книгу.
/// </summary>
internal class Book
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
    /// Возвращает и задает название книги. Должно быть написано на латинице.
    /// </summary>
    public string Name
    {
        get => _name;
        set
        {
            try
            {
                if (!Validator.AssertStringContainsOnlyEnglishLetters(value))
                {
                    throw new ArgumentException($"Допустима только латиница в названии книги.");
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
    /// Возвращает и задает год выпуска книги. Должен быть больше нуля.
    /// </summary>
    public int Year
    {
        get => _year;
        set 
        {
            if (Validator.AssertOnPositiveValue(value))
            {
                _year = value;
            }
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
            try
            {
                if (!Validator.AssertStringContainsOnlyEnglishLetters(value))
                {
                    throw new ArgumentException($"Допустима только латиница в имени автора.");
                }

                _author = value;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
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
            if (Validator.AssertOnPositiveValue(value))
            {
                _page = value;
            }
        }
    }

    /// <summary>
    /// Возвращает и задает жанр. Должен быть написан на латинице.
    /// </summary>
    public string Genre
    {
        get => _genre;
        set
        {
            try
            {
                if (!Validator.AssertStringContainsOnlyEnglishLetters(value))
                {
                    throw new ArgumentException($"Допустима только латиница в жанре книги.");
                }

                _genre = value;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
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
    /// <param name="name">Название.</param>
    /// <param name="year">Год выхода. Должен быть больше нуля.</param>
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
}