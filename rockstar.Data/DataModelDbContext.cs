using Microsoft.EntityFrameworkCore;
using rockstar.Data.Entities;
using System;

namespace rockstar.Data
{
    public class DataModelDbContext : DbContext
    {
        //To update the database (make sure blank "rockstar" database created first)
        //  Open View > Package Manager Console
        //dotnet ef migrations add Migration00* --project rockstar.Data --context DataModelDbContext (updates Project)
        //dotnet ef database update --project rockstar.Data --context DataModelDbContext (updates Database)
        //dotnet ef migrations remove --project rockstar.Data --context DataModelDbContext (removes latest migration)

        public DataModelDbContext(DbContextOptions<DataModelDbContext> options)
            : base(options) { }

        public DataModelDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //use appsettings.json instead?...
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=rockstar;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            // SEED DATA //

            //=========//
            // Artists //
            //=========//

            mb.Entity<Artist>().HasData(new Artist
            {
                ArtistID = 1,
                ArtistName = "Rush",
                ArtistCareerStart = new DateTimeOffset(1968, 8, 1, 0, 0, 0, TimeSpan.Zero),
                ArtistCareerEnd = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero)
            });
            mb.Entity<Artist>().HasData(new Artist
            {
                ArtistID = 2,
                ArtistName = "blink 182",
                ArtistCareerStart = new DateTimeOffset(1992, 1, 1, 0, 0, 0, TimeSpan.Zero)
            });
            mb.Entity<Artist>().HasData(new Artist
            {
                ArtistID = 3,
                ArtistName = "Metallica",
                ArtistCareerStart = new DateTimeOffset(1981, 1, 1, 0, 0, 0, TimeSpan.Zero)
            });

            //========//
            // People //
            //========//

            mb.Entity<Person>().HasData(new Person
            {
                PersonID = 1,
                PersonNameFirst = "Neil",
                PersonNameLast = "Peart",
                PersonBirthdate = new DateTime(1952, 9, 12),
                PersonDeathDate = new DateTime(2020, 1, 7)
            });
            mb.Entity<Person>().HasData(new Person
            {
                PersonID = 2,
                PersonNameFirst = "Geddy",
                PersonNameLast = "Lee",
                PersonBirthdate = new DateTime(1953, 7, 29)
            });
            mb.Entity<Person>().HasData(new Person
            {
                PersonID = 3,
                PersonNameFirst = "Alex",
                PersonNameLast = "Lifeson",
                PersonBirthdate = new DateTime(1953, 8, 27)
            });
            mb.Entity<Person>().HasData(new Person
            {
                PersonID = 4,
                PersonNameFirst = "Travis",
                PersonNameLast = "Barker",
                PersonBirthdate = new DateTime(1975, 11, 14)
            });
            mb.Entity<Person>().HasData(new Person
            {
                PersonID = 5,
                PersonNameFirst = "Lars",
                PersonNameLast = "Ulrich"
            });
            mb.Entity<Person>().HasData(new Person
            {
                PersonID = 6,
                PersonNameFirst = "James",
                PersonNameLast = "Hetfield"
            });
            mb.Entity<Person>().HasData(new Person
            {
                PersonID = 7,
                PersonNameFirst = "Kirk",
                PersonNameLast = "Hammett"
            });
            mb.Entity<Person>().HasData(new Person
            {
                PersonID = 8,
                PersonNameFirst = "Robert",
                PersonNameLast = "Trujillo"
            });

            //Attach rockstars to Artists...
            mb.Entity<PersonArtist>().HasData(new PersonArtist { PersonArtistID = 1, ArtistID = 1, PersonID = 1 }); //Rush / Neil
            mb.Entity<PersonArtist>().HasData(new PersonArtist { PersonArtistID = 2, ArtistID = 1, PersonID = 2 }); //Rush / Geddy
            mb.Entity<PersonArtist>().HasData(new PersonArtist { PersonArtistID = 3, ArtistID = 1, PersonID = 3 }); //Rush / Alex
            mb.Entity<PersonArtist>().HasData(new PersonArtist { PersonArtistID = 4, ArtistID = 2, PersonID = 4 }); //blink 182 / Travis
            mb.Entity<PersonArtist>().HasData(new PersonArtist { PersonArtistID = 5, ArtistID = 3, PersonID = 5 }); //Metallica / Lars
            mb.Entity<PersonArtist>().HasData(new PersonArtist { PersonArtistID = 6, ArtistID = 3, PersonID = 6 }); //Metallica / James
            mb.Entity<PersonArtist>().HasData(new PersonArtist { PersonArtistID = 7, ArtistID = 3, PersonID = 7 }); //Metallica / Kirk
            mb.Entity<PersonArtist>().HasData(new PersonArtist { PersonArtistID = 8, ArtistID = 3, PersonID = 8 }); //Metallica / Robert

            //========//
            // Albums //
            //========//

            mb.Entity<Album>().HasData(new Album { AlbumID = 1, AlbumName = "Kill 'Em All", ArtistID = 3 });
            mb.Entity<Album>().HasData(new Album { AlbumID = 2, AlbumName = "Ride the Lightning", ArtistID = 3 });
            mb.Entity<Album>().HasData(new Album { AlbumID = 3, AlbumName = "Master of Puppets", ArtistID = 3 });
            mb.Entity<Album>().HasData(new Album { AlbumID = 4, AlbumName = "...And Justice for All", ArtistID = 3 });
            mb.Entity<Album>().HasData(new Album { AlbumID = 5, AlbumName = "Metallica", ArtistID = 3 });
            mb.Entity<Album>().HasData(new Album { AlbumID = 6, AlbumName = "Load", ArtistID = 3 });
            mb.Entity<Album>().HasData(new Album { AlbumID = 7, AlbumName = "Reload", ArtistID = 3 });
            mb.Entity<Album>().HasData(new Album { AlbumID = 8, AlbumName = "St. Anger", ArtistID = 3 });
            mb.Entity<Album>().HasData(new Album { AlbumID = 9, AlbumName = "Death Magnetic", ArtistID = 3 });
            mb.Entity<Album>().HasData(new Album { AlbumID = 10, AlbumName = "Hardwired...To Self-Destruct", ArtistID = 3 });

            //=======//
            // Songs //
            //=======//

            //Metallica's Black Album...
            mb.Entity<Song>().HasData(new Song { SongID = 1, SongName = "Enter Sandman", AlbumID = 5 });
            mb.Entity<Song>().HasData(new Song { SongID = 2, SongName = "Sad But True", AlbumID = 5 });
            mb.Entity<Song>().HasData(new Song { SongID = 3, SongName = "Holier Than Thou", AlbumID = 5 });
            mb.Entity<Song>().HasData(new Song { SongID = 4, SongName = "The Unforgiven", AlbumID = 5 });
            mb.Entity<Song>().HasData(new Song { SongID = 5, SongName = "Wherever I May Roam", AlbumID = 5 });
            mb.Entity<Song>().HasData(new Song { SongID = 6, SongName = "Don't Tread On Me", AlbumID = 5 });
            mb.Entity<Song>().HasData(new Song { SongID = 7, SongName = "Through the Never", AlbumID = 5 });
            mb.Entity<Song>().HasData(new Song { SongID = 8, SongName = "Nothing Else Matters", AlbumID = 5 });
            mb.Entity<Song>().HasData(new Song { SongID = 9, SongName = "Of Wolf and Man", AlbumID = 5 });
            mb.Entity<Song>().HasData(new Song { SongID = 10, SongName = "The God That Failed", AlbumID = 5 });
            mb.Entity<Song>().HasData(new Song { SongID = 11, SongName = "My Friend of Misery", AlbumID = 5 });
            mb.Entity<Song>().HasData(new Song { SongID = 12, SongName = "The Struggle Within", AlbumID = 5 });

            //Metallica's Master of Puppets...
            mb.Entity<Song>().HasData(new Song { SongID = 13, SongName = "Battery", AlbumID = 3 });
            mb.Entity<Song>().HasData(new Song { SongID = 14, SongName = "Master of Puppets", AlbumID = 3 });
            mb.Entity<Song>().HasData(new Song { SongID = 15, SongName = "The Thing That Should Not Be", AlbumID = 3 });
            mb.Entity<Song>().HasData(new Song { SongID = 16, SongName = "Welcome Home (Sanitarium)", AlbumID = 3 });
            mb.Entity<Song>().HasData(new Song { SongID = 17, SongName = "Disposable Heroes", AlbumID = 3 });
            mb.Entity<Song>().HasData(new Song { SongID = 18, SongName = "Leper Messiah", AlbumID = 3 });
            mb.Entity<Song>().HasData(new Song { SongID = 19, SongName = "Orion", AlbumID = 3 });
            mb.Entity<Song>().HasData(new Song { SongID = 20, SongName = "Damage, Inc.", AlbumID = 3 });


            // GET MORE SEED DATA FROM A SPREADSHEET //
            //TO-DO
        }

        // ENTITIES //
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonArtist> PersonArtists { get; set; }
    }
}
