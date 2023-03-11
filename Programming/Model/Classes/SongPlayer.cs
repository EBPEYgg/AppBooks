internal class SongPlayer
{
    private int _songTimeSeconds;

    public string? NameMusicGroup { get; set; }

    public string? NameSong { get; set; }

    public int SongTimeSeconds
    {
        get 
        { 
            return _songTimeSeconds; 
        }
        set 
        {
            if (Validator.AssertOnPositiveValue(value))
            {
                _songTimeSeconds = value;
            }
        }
    }

    public SongPlayer()
    {

    }

    public SongPlayer(string? nameMusicGroup, string? nameSong, int songTimeSeconds)
    {
        this.NameMusicGroup = nameMusicGroup;
        this.NameSong = nameSong;
        this.SongTimeSeconds = songTimeSeconds;
    }
}