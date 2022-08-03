namespace Music_API.Data.Model
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }

        public string ArtistDescription { get; set; }

        public List<Album> Albums { get; set; } = new List<Album>();
    }
}