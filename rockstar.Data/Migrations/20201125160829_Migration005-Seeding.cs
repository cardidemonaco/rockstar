using Microsoft.EntityFrameworkCore.Migrations;

namespace rockstar.Data.Migrations
{
    public partial class Migration005Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumID", "AlbumCoverURL", "AlbumDescription", "AlbumName", "AlbumReleaseDate", "ArtistID" },
                values: new object[,]
                {
                    { 1, null, null, "Kill 'Em All", null, 3 },
                    { 2, null, null, "Ride the Lightning", null, 3 },
                    { 3, null, null, "Master of Puppets", null, 3 },
                    { 4, null, null, "...And Justice for All", null, 3 },
                    { 5, null, null, "Metallica", null, 3 },
                    { 6, null, null, "Load", null, 3 },
                    { 7, null, null, "Reload", null, 3 },
                    { 8, null, null, "St. Anger", null, 3 },
                    { 9, null, null, "Death Magnetic", null, 3 },
                    { 10, null, null, "Hardwired...To Self-Destruct", null, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumID",
                keyValue: 10);
        }
    }
}
