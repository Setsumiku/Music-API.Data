using Music_API.Data.Model;

namespace Music_API.Data.Context
{
    public class Music_API_Context : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<Employee> Employee { get; set; }

        public Music_API_Context(DbContextOptions<Music_API_Context> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SeedDatabase();
        }
    }
}