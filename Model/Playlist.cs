namespace Music_API.Data.Model
{
    public class Playlist
    {
        [Key]
        public int PlaylistId { get; set; }

        public string PlaylistDescription { get; set; }
        public List<Song> PlaylistSongs { get; set; } = new List<Song>();
    }
}