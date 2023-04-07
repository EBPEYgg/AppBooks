/// <summary>
/// Класс, описывающий песню в плеере.
/// </summary>
internal class SongPlayer
{
    /// <summary>
    /// Длительность песни в секундах.
    /// </summary>
    private int _songTime;

    /// <summary>
    /// Название музыкальной группы/исполнителя.
    /// </summary>
    public string? NameMusicGroup { get; set; }

    /// <summary>
    /// Название песни.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Длительность песни в секундах. Должна быть положительной.
    /// </summary>
    public int SongTime
    {
        get 
        { 
            return _songTime; 
        }
        set 
        {
            if (Validator.AssertOnPositiveValue(value))
            {
                _songTime = value;
            }
        }
    }

    /// <summary>
    /// Пустой конструктор класса.
    /// </summary>
    public SongPlayer()
    {

    }

    /// <summary>
    /// Конструктор класса.
    /// </summary>
    /// <param name="nameMusicGroup">Название музыкальной группы/исполнителя.</param>
    /// <param name="name">Название песни.</param>
    /// <param name="songTime">Длительность песни в секундах.</param>
    public SongPlayer(string? nameMusicGroup, string? name, int songTime)
    {
        this.NameMusicGroup = nameMusicGroup;
        this.Name = name;
        this.SongTime = songTime;
    }
}