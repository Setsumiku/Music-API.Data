namespace Music_API.Data.Model
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }

        public string SongDescription { get; set; }

        public Playlist? Playlist { get; set; }
        public Album? Album { get; set; }
    }
}