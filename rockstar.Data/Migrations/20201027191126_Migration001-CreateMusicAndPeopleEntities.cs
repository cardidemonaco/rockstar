using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace rockstar.Data.Migrations
{
    public partial class Migration001CreateMusicAndPeopleEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistName = table.Column<string>(nullable: false),
                    ArtistBiography = table.Column<string>(nullable: true),
                    ArtistCareerStart = table.Column<DateTimeOffset>(nullable: true),
                    ArtistCareerEnd = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistID);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonNameFirst = table.Column<string>(nullable: false),
                    PersonNameMiddle = table.Column<string>(nullable: true),
                    PersonNameLast = table.Column<string>(nullable: true),
                    PersonGender = table.Column<int>(nullable: false),
                    PersonBirthdate = table.Column<DateTime>(nullable: true),
                    PersonBirthdateMonth = table.Column<int>(nullable: true),
                    PersonBirthdateDay = table.Column<int>(nullable: true),
                    PersonDeathDate = table.Column<DateTime>(nullable: true),
                    PersonDetails = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonID);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumName = table.Column<string>(nullable: false),
                    AlbumDescription = table.Column<string>(nullable: true),
                    AlbumReleaseDate = table.Column<DateTimeOffset>(nullable: true),
                    AlbumCoverURL = table.Column<string>(nullable: true),
                    ArtistID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumID);
                    table.ForeignKey(
                        name: "FK_Albums_Artists_ArtistID",
                        column: x => x.ArtistID,
                        principalTable: "Artists",
                        principalColumn: "ArtistID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonArtists",
                columns: table => new
                {
                    PersonArtistID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonID = table.Column<int>(nullable: false),
                    ArtistID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonArtists", x => x.PersonArtistID);
                    table.ForeignKey(
                        name: "FK_PersonArtists_Artists_ArtistID",
                        column: x => x.ArtistID,
                        principalTable: "Artists",
                        principalColumn: "ArtistID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonArtists_People_PersonID",
                        column: x => x.PersonID,
                        principalTable: "People",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongName = table.Column<string>(nullable: false),
                    SongDescription = table.Column<string>(nullable: true),
                    SongLength = table.Column<int>(nullable: false),
                    AlbumID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongID);
                    table.ForeignKey(
                        name: "FK_Songs_Albums_AlbumID",
                        column: x => x.AlbumID,
                        principalTable: "Albums",
                        principalColumn: "AlbumID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistID",
                table: "Albums",
                column: "ArtistID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonArtists_ArtistID",
                table: "PersonArtists",
                column: "ArtistID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonArtists_PersonID",
                table: "PersonArtists",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumID",
                table: "Songs",
                column: "AlbumID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonArtists");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
