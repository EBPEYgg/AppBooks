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
    /// Возвращает и задает название музыкальной группы/исполнителя.
    /// </summary>
    public string? NameMusicGroup { get; set; }

    /// <summary>
    /// Возвращает и задает название песни.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Возвращает и задает длительность песни в секундах. Должна быть больше нуля.
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
    /// Создает пустой экземпляр класса <see cref="SongPlayer"/>.
    /// </summary>
    public SongPlayer()
    {

    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="SongPlayer"/>.
    /// </summary>
    /// <param name="nameMusicGroup">Название музыкальной группы/исполнителя.</param>
    /// <param name="name">Название песни.</param>
    /// <param name="songTime">Длительность песни в секундах. Должна быть больше нуля.</param>
    public SongPlayer(string? nameMusicGroup, string? name, int songTime)
    {
        this.NameMusicGroup = nameMusicGroup;
        this.Name = name;
        this.SongTime = songTime;
    }
}