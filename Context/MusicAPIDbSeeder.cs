using Music_API.Data.Model;

namespace Music_API.Data.Context
{
    public static class MusicAPIDbSeeder
    {
        public static void SeedDatabase(this ModelBuilder builder)
        {
            var albums = new List<Album>();
            var artists = new List<Artist>();
            var songs = new List<Song>();
            var playlists = new List<Playlist>();
            var genres = new List<Genre>();
            SeedGenres(genres);
            SeedPlaylists(playlists);
            SeedSongs(songs);
            SeedArtists(artists);
            SeedAlbums(albums);
            builder.Entity<Album>().HasData(albums);
            builder.Entity<Song>().HasData(songs);
            builder.Entity<Artist>().HasData(artists);
            builder.Entity<Playlist>().HasData(playlists);
            builder.Entity<Genre>().HasData(genres);
        }

        private static void SeedAlbums(List<Album> albums)
        {
            albums.Add(new Album
            {
                AlbumId = 50,
                AlbumDescription = "Extella OST"
            });
            albums.Add(new Album
            {
                AlbumId = 51,
                AlbumDescription = "Extella/Link OST"
            });
            albums.Add(new Album
            {
                AlbumId = 52,
                AlbumDescription = "Extra OST"
            });
            albums.Add(new Album
            {
                AlbumId = 53,
                AlbumDescription = "Extella OST"
            });
        }

        private static void SeedArtists(List<Artist> artists)
        {
            artists.Add(new Artist
            {
                ArtistId = 50,
                ArtistDescription = "Kalafina"
            });
            artists.Add(new Artist
            {
                ArtistId = 51,
                ArtistDescription = "Hideyuki Fukasawa"
            });
            artists.Add(new Artist
            {
                ArtistId = 52,
                ArtistDescription = "Tatsuya Kato"
            });
            artists.Add(new Artist
            {
                ArtistId = 53,
                ArtistDescription = "Keita Haga"
            });
            artists.Add(new Artist
            {
                ArtistId = 54,
                ArtistDescription = "James Harris"
            });
        }

        private static void SeedPlaylists(List<Playlist> playlists)
        {
            playlists.Add(new Playlist
            {
                PlaylistId = 51,
                PlaylistDescription = "Extra"
            });
            playlists.Add(new Playlist
            {
                PlaylistId = 50,
                PlaylistDescription = "Extra CCC"
            });
            playlists.Add(new Playlist
            {
                PlaylistId = 52,
                PlaylistDescription = "Extella"
            });
            playlists.Add(new Playlist
            {
                PlaylistId = 53,
                PlaylistDescription = "Extella/Link"
            });
            playlists.Add(new Playlist
            {
                PlaylistId = 54,
                PlaylistDescription = "Stay/Night"
            });
            playlists.Add(new Playlist
            {
                PlaylistId = 55,
                PlaylistDescription = "Hollow Ataraxia"
            });
            playlists.Add(new Playlist
            {
                PlaylistId = 56,
                PlaylistDescription = "Zero"
            });
            playlists.Add(new Playlist
            {
                PlaylistId = 57,
                PlaylistDescription = "Prisma Illya"
            });
        }

        private static void SeedGenres(List<Genre> genres)
        {
            genres.Add(new Genre
            {
                GenreId = 50,
                GenreDescription = "Electronic"
            });
            genres.Add(new Genre
            {
                GenreId = 51,
                GenreDescription = "Chiptune"
            });
            genres.Add(new Genre
            {
                GenreId = 52,
                GenreDescription = "Orchestral"
            });
            genres.Add(new Genre
            {
                GenreId = 53,
                GenreDescription = "Spinal Coaster"
            });
        }

        private static void SeedSongs(List<Song> songs)
        {
            songs.Add(new Song
            {
                SongId = 50,
                SongDescription = "Namida No Hoshi",
            });
            songs.Add(new Song
            {
                SongId = 51,
                SongDescription = "Private (Ivy)"
            });
            songs.Add(new Song
            {
                SongId = 52,
                SongDescription = "Souten Ni Baranosaku"
            });
            songs.Add(new Song
            {
                SongId = 53,
                SongDescription = "Shintenchi no Kaze"
            });
            songs.Add(new Song
            {
                SongId = 54,
                SongDescription = "Ouken Tansaku"
            });
            songs.Add(new Song
            {
                SongId = 55,
                SongDescription = "Senketsu Majou New World"
            });
            songs.Add(new Song
            {
                SongId = 56,
                SongDescription = "Razoredge"
            });
            songs.Add(new Song
            {
                SongId = 57,
                SongDescription = "Gunyuu Kakkyo"
            });
            songs.Add(new Song
            {
                SongId = 58,
                SongDescription = "Seven Master War"
            });
            songs.Add(new Song
            {
                SongId = 59,
                SongDescription = "Shikai No Ura"
            });
            songs.Add(new Song
            {
                SongId = 60,
                SongDescription = "Emiya - Extella"
            });
            songs.Add(new Song
            {
                SongId = 61,
                SongDescription = "Strike back"
            });
            songs.Add(new Song
            {
                SongId = 62,
                SongDescription = "Intruder"
            });
            songs.Add(new Song
            {
                SongId = 63,
                SongDescription = "Rise and Fall"
            });
            songs.Add(new Song
            {
                SongId = 64,
                SongDescription = "Shiroi Kenki"
            });
            songs.Add(new Song
            {
                SongId = 65,
                SongDescription = "Raging Torrent"
            });
            songs.Add(new Song
            {
                SongId = 66,
                SongDescription = "Ryusei no Extella"
            });
            songs.Add(new Song
            {
                SongId = 67,
                SongDescription = "Last Stand"
            });
            songs.Add(new Song
            {
                SongId = 68,
                SongDescription = "Charles Patricius"
            });
            songs.Add(new Song
            {
                SongId = 69,
                SongDescription = "Mare Cruor"
            });
            songs.Add(new Song
            {
                SongId = 70,
                SongDescription = "In case of a nap to the Moon"
            });
            songs.Add(new Song
            {
                SongId = 71,
                SongDescription = "Kaiser und Helliger"
            });
            songs.Add(new Song
            {
                SongId = 72,
                SongDescription = "Mare Lamentatio"
            });
        }
    }
}