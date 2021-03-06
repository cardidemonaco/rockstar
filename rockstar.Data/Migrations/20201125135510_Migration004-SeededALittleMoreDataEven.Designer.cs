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
    [Migration("20201125135510_Migration004-SeededALittleMoreDataEven")]
    partial class Migration004SeededALittleMoreDataEven
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
                });

            modelBuilder.Entity("rockstar.Data.Entities.Album", b =>
                {
                    b.HasOne("rockstar.Data.Entities.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("rockstar.Data.Entities.PersonArtist", b =>
                {
                    b.HasOne("rockstar.Data.Entities.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("rockstar.Data.Entities.Person", "Person")
                        .WithMany()
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
