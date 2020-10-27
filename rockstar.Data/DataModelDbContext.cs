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
        }

        // ENTITIES //
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonArtist> PersonArtists { get; set; }
    }
}
