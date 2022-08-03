namespace Music_API.Data.Model
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }

        public string AlbumDescription { get; set; }
        public List<Song> AlbumSongs { get; set; } = new List<Song>();
        public Artist? Artist { get; set; }
        public Genre? Genre { get; set; }
    }
}