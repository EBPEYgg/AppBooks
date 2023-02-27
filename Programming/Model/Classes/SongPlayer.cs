namespace Programming.Model.Classes
{
    internal class SongPlayer
    {
        private string? nameMusicGroup { get; set; }
        private string? nameSong { get; set; }
        private int songTimeSeconds
        {
            get { return songTimeSeconds; }
            set { if (songTimeSeconds > 0) songTimeSeconds = value; }
        }
    }
}
