﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rockstar.Data;

namespace rockstar.Data.Migrations
{
    [DbContext(typeof(DataModelDbContext))]
    [Migration("20201125164214_Migration006-Seeding")]
    partial class Migration006Seeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("rockstar.Data.Entities.Album", b =>
                {
                    b.Property<int>("AlbumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumCoverURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlbumDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("AlbumReleaseDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("ArtistID")
                        .HasColumnType("int");

                    b.HasKey("AlbumID");

                    b.HasIndex("ArtistID");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            AlbumID = 1,
                            AlbumName = "Kill 'Em All",
                            ArtistID = 3
                        },
                        new
                        {
                            AlbumID = 2,
                            AlbumName = "Ride the Lightning",
                            ArtistID = 3
                        },
                        new
                        {
                            AlbumID = 3,
                            AlbumName = "Master of Puppets",
                            ArtistID = 3
                        },
                        new
                        {
                            AlbumID = 4,
                            AlbumName = "...And Justice for All",
                            ArtistID = 3
                        },
                        new
                        {
                            AlbumID = 5,
                            AlbumName = "Metallica",
                            ArtistID = 3
                        },
                        new
                        {
                            AlbumID = 6,
                            AlbumName = "Load",
                            ArtistID = 3
                        },
                        new
                        {
                            AlbumID = 7,
                            AlbumName = "Reload",
                            ArtistID = 3
                        },
                        new
                        {
                            AlbumID = 8,
                            AlbumName = "St. Anger",
                            ArtistID = 3
                        },
                        new
                        {
                            AlbumID = 9,
                            AlbumName = "Death Magnetic",
                            ArtistID = 3
                        },
                        new
                        {
                            AlbumID = 10,
                            AlbumName = "Hardwired...To Self-Destruct",
                            ArtistID = 3
                        });
                });

            modelBuilder.Entity("rockstar.Data.Entities.Artist", b =>
                {
                    b.Property<int>("ArtistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtistBiography")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("ArtistCareerEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("ArtistCareerStart")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistID");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtistID = 1,
                            ArtistCareerEnd = new DateTimeOffset(new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ArtistCareerStart = new DateTimeOffset(new DateTime(1968, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ArtistName = "Rush"
                        },
                        new
                        {
                            ArtistID = 2,
                            ArtistCareerStart = new DateTimeOffset(new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ArtistName = "blink 182"
                        },
                        new
                        {
                            ArtistID = 3,
                            ArtistCareerStart = new DateTimeOffset(new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ArtistName = "Metallica"
                        });
                });

            modelBuilder.Entity("rockstar.Data.Entities.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("PersonBirthdate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PersonBirthdateDay")
                        .HasColumnType("int");

                    b.Property<int?>("PersonBirthdateMonth")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PersonDeathDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PersonDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonGender")
                        .HasColumnType("int");

                    b.Property<string>("PersonNameFirst")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonNameLast")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonNameMiddle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonID");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            PersonID = 1,
                            PersonBirthdate = new DateTime(1952, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonDeathDate = new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonGender = 0,
                            PersonNameFirst = "Neil",
                            PersonNameLast = "Peart"
                        },
                        new
                        {
                            PersonID = 2,
                            PersonBirthdate = new DateTime(1953, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonGender = 0,
                            PersonNameFirst = "Geddy",
                            PersonNameLast = "Lee"
                        },
                        new
                        {
                            PersonID = 3,
                            PersonBirthdate = new DateTime(1953, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonGender = 0,
                            PersonNameFirst = "Alex",
                            PersonNameLast = "Lifeson"
                        },
                        new
                        {
                            PersonID = 4,
                            PersonBirthdate = new DateTime(1975, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PersonGender = 0,
                            PersonNameFirst = "Travis",
                            PersonNameLast = "Barker"
                        },
                        new
                        {
                            PersonID = 5,
                            PersonGender = 0,
                            PersonNameFirst = "Lars",
                            PersonNameLast = "Ulrich"
                        },
                        new
                        {
                            PersonID = 6,
                            PersonGender = 0,
                            PersonNameFirst = "James",
                            PersonNameLast = "Hetfield"
                        },
                        new
                        {
                            PersonID = 7,
                            PersonGender = 0,
                            PersonNameFirst = "Kirk",
                            PersonNameLast = "Hammett"
                        },
                        new
                        {
                            PersonID = 8,
                            PersonGender = 0,
                            PersonNameFirst = "Robert",
                            PersonNameLast = "Trujillo"
                        });
                });

            modelBuilder.Entity("rockstar.Data.Entities.PersonArtist", b =>
                {
                    b.Property<int>("PersonArtistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistID")
                        .HasColumnType("int");

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.HasKey("PersonArtistID");

                    b.HasIndex("ArtistID");

                    b.HasIndex("PersonID");

                    b.ToTable("PersonArtists");

                    b.HasData(
                        new
                        {
                            PersonArtistID = 1,
                            ArtistID = 1,
                            PersonID = 1
                        },
                        new
                        {
                            PersonArtistID = 2,
                            ArtistID = 1,
                            PersonID = 2
                        },
                        new
                        {
                            PersonArtistID = 3,
                            ArtistID = 1,
                            PersonID = 3
                        },
                        new
                        {
                            PersonArtistID = 4,
                            ArtistID = 2,
                            PersonID = 4
                        },
                        new
                        {
                            PersonArtistID = 5,
                            ArtistID = 3,
                            PersonID = 5
                        },
                        new
                        {
                            PersonArtistID = 6,
                            ArtistID = 3,
                            PersonID = 6
                        },
                        new
                        {
                            PersonArtistID = 7,
                            ArtistID = 3,
                            PersonID = 7
                        },
                        new
                        {
                            PersonArtistID = 8,
                            ArtistID = 3,
                            PersonID = 8
                        });
                });

            modelBuilder.Entity("rockstar.Data.Entities.Song", b =>
                {
                    b.Property<int>("SongID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumID")
                        .HasColumnType("int");

                    b.Property<string>("SongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SongLength")
                        .HasColumnType("int");

                    b.Property<string>("SongName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SongID");

                    b.HasIndex("AlbumID");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            SongID = 1,
                            AlbumID = 5,
                            SongLength = 0,
                            SongName = "Enter Sandman"
                        },
                        new
                        {
                            SongID = 2,
                            AlbumID = 5,
                            SongLength = 0,
                            SongName = "Sad But True"
                        },
                        new
                        {
                            SongID = 3,
                            AlbumID = 5,
                            SongLength = 0,
                            SongName = "Holier Than Thou"
                        },
                        new
                        {
                            SongID = 4,
                            AlbumID = 5,
                            SongLength = 0,
                            SongName = "The Unforgiven"
                        },
                        new
                        {
                            SongID = 5,
                            AlbumID = 5,
                            SongLength = 0,
                            SongName = "Wherever I May Roam"
                        },
                        new
                        {
                            SongID = 6,
                            AlbumID = 5,
                            SongLength = 0,
                            SongName = "Don't Tread On Me"
                        },
                        new
                        {
                            SongID = 7,
                            AlbumID = 5,
                            SongLength = 0,
                            SongName = "Through the Never"
                        },
                        new
                        {
                            SongID = 8,
                            AlbumID = 5,
                            SongLength = 0,
                            SongName = "Nothing Else Matters"
                        },
                        new
                        {
                            SongID = 9,
                            AlbumID = 5,
                            SongLength = 0,
                            SongName = "Of Wolf and Man"
                        },
                        new
                        {
                            SongID = 10,
                            AlbumID = 5,
                            SongLength = 0,
                            SongName = "The God That Failed"
                        },
                        new
                        {
                            SongID = 11,
                            AlbumID = 5,
                            SongLength = 0,
                            SongName = "My Friend of Misery"
                        },
                        new
                        {
                            SongID = 12,
                            AlbumID = 5,
                            SongLength = 0,
                            SongName = "The Struggle Within"
                        },
                        new
                        {
                            SongID = 13,
                            AlbumID = 3,
                            SongLength = 0,
                            SongName = "Battery"
                        },
                        new
                        {
                            SongID = 14,
                            AlbumID = 3,
                            SongLength = 0,
                            SongName = "Master of Puppets"
                        },
                        new
                        {
                            SongID = 15,
                            AlbumID = 3,
                            SongLength = 0,
                            SongName = "The Thing That Should Not Be"
                        },
                        new
                        {
                            SongID = 16,
                            AlbumID = 3,
                            SongLength = 0,
                            SongName = "Welcome Home (Sanitarium)"
                        },
                        new
                        {
                            SongID = 17,
                            AlbumID = 3,
                            SongLength = 0,
                            SongName = "Disposable Heroes"
                        },
                        new
                        {
                            SongID = 18,
                            AlbumID = 3,
                            SongLength = 0,
                            SongName = "Leper Messiah"
                        },
                        new
                        {
                            SongID = 19,
                            AlbumID = 3,
                            SongLength = 0,
                            SongName = "Orion"
                        },
                        new
                        {
                            SongID = 20,
                            AlbumID = 3,
                            SongLength = 0,
                            SongName = "Damage, Inc."
                        });
                });

            modelBuilder.Entity("rockstar.Data.Entities.Album", b =>
                {
                    b.HasOne("rockstar.Data.Entities.Artist", null)
                        .WithMany("Albums")
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("rockstar.Data.Entities.PersonArtist", b =>
                {
                    b.HasOne("rockstar.Data.Entities.Artist", "Artist")
                        .WithMany("ArtistMembers")
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("rockstar.Data.Entities.Person", "Person")
                        .WithMany("PersonBands")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("rockstar.Data.Entities.Song", b =>
                {
                    b.HasOne("rockstar.Data.Entities.Album", "Album")
                        .WithMany()
                        .HasForeignKey("AlbumID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}