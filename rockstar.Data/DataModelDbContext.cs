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

            //Artists...
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

            //People...
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

            //Attach rockstars to Artists...
            mb.Entity<PersonArtist>().HasData(new PersonArtist { PersonArtistID = 1, ArtistID = 1, PersonID = 1 }); //Rush / Neil
            mb.Entity<PersonArtist>().HasData(new PersonArtist { PersonArtistID = 2, ArtistID = 1, PersonID = 2 }); //Rush / Geddy
            mb.Entity<PersonArtist>().HasData(new PersonArtist { PersonArtistID = 3, ArtistID = 1, PersonID = 3 }); //Rush / Alex
        }

        // ENTITIES //
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonArtist> PersonArtists { get; set; }
    }
}
