namespace Programming.Model.Classes
{
    internal class SongPlayer
    {
        private string? nameMusicGroup { get; set; }
        private string? nameSong { get; set; }
        private int songTimeSeconds
        {
            get { return songTimeSeconds; }
            set { if (Validator.AssertOnPositiveValue(songTimeSeconds)) songTimeSeconds = value; }
        }

        public SongPlayer(string? nameMusicGroup, string? nameSong, int songTimeSeconds)
        {
            nameMusicGroup = "";
            nameSong = "";
            songTimeSeconds = 0;
        }
    }
}
