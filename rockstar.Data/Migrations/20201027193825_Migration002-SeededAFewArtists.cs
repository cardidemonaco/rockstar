using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace rockstar.Data.Migrations
{
    public partial class Migration002SeededAFewArtists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistID", "ArtistBiography", "ArtistCareerEnd", "ArtistCareerStart", "ArtistName" },
                values: new object[] { 1, null, new DateTimeOffset(new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(1968, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Rush" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistID", "ArtistBiography", "ArtistCareerEnd", "ArtistCareerStart", "ArtistName" },
                values: new object[] { 2, null, null, new DateTimeOffset(new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "blink 182" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistID", "ArtistBiography", "ArtistCareerEnd", "ArtistCareerStart", "ArtistName" },
                values: new object[] { 3, null, null, new DateTimeOffset(new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Metallica" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistID",
                keyValue: 3);
        }
    }
}
