namespace Music_API.Data.Model
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        public string GenreDescription { get; set; }
        public List<Album> GenreAlbums { get; set; } = new List<Album>();
    }
}