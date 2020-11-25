using Microsoft.EntityFrameworkCore.Migrations;

namespace rockstar.Data.Migrations
{
    public partial class Migration006Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonID", "PersonBirthdate", "PersonBirthdateDay", "PersonBirthdateMonth", "PersonDeathDate", "PersonDetails", "PersonGender", "PersonNameFirst", "PersonNameLast", "PersonNameMiddle" },
                values: new object[,]
                {
                    { 5, null, null, null, null, null, 0, "Lars", "Ulrich", null },
                    { 6, null, null, null, null, null, 0, "James", "Hetfield", null },
                    { 7, null, null, null, null, null, 0, "Kirk", "Hammett", null },
                    { 8, null, null, null, null, null, 0, "Robert", "Trujillo", null }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongID", "AlbumID", "SongDescription", "SongLength", "SongName" },
                values: new object[,]
                {
                    { 18, 3, null, 0, "Leper Messiah" },
                    { 17, 3, null, 0, "Disposable Heroes" },
                    { 16, 3, null, 0, "Welcome Home (Sanitarium)" },
                    { 15, 3, null, 0, "The Thing That Should Not Be" },
                    { 14, 3, null, 0, "Master of Puppets" },
                    { 13, 3, null, 0, "Battery" },
                    { 12, 5, null, 0, "The Struggle Within" },
                    { 11, 5, null, 0, "My Friend of Misery" },
                    { 10, 5, null, 0, "The God That Failed" },
                    { 8, 5, null, 0, "Nothing Else Matters" },
                    { 19, 3, null, 0, "Orion" },
                    { 7, 5, null, 0, "Through the Never" },
                    { 6, 5, null, 0, "Don't Tread On Me" },
                    { 5, 5, null, 0, "Wherever I May Roam" },
                    { 4, 5, null, 0, "The Unforgiven" },
                    { 3, 5, null, 0, "Holier Than Thou" },
                    { 2, 5, null, 0, "Sad But True" },
                    { 1, 5, null, 0, "Enter Sandman" },
                    { 9, 5, null, 0, "Of Wolf and Man" },
                    { 20, 3, null, 0, "Damage, Inc." }
                });

            migrationBuilder.InsertData(
                table: "PersonArtists",
                columns: new[] { "PersonArtistID", "ArtistID", "PersonID" },
                values: new object[,]
                {
                    { 5, 3, 5 },
                    { 6, 3, 6 },
                    { 7, 3, 7 },
                    { 8, 3, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PersonArtists",
                keyColumn: "PersonArtistID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PersonArtists",
                keyColumn: "PersonArtistID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PersonArtists",
                keyColumn: "PersonArtistID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PersonArtists",
                keyColumn: "PersonArtistID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonID",
                keyValue: 8);
        }
    }
}
