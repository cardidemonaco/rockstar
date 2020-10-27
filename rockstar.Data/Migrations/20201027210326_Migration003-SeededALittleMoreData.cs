using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace rockstar.Data.Migrations
{
    public partial class Migration003SeededALittleMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonID", "PersonBirthdate", "PersonBirthdateDay", "PersonBirthdateMonth", "PersonDeathDate", "PersonDetails", "PersonGender", "PersonNameFirst", "PersonNameLast", "PersonNameMiddle" },
                values: new object[] { 1, new DateTime(1952, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "Neil", "Peart", null });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonID", "PersonBirthdate", "PersonBirthdateDay", "PersonBirthdateMonth", "PersonDeathDate", "PersonDetails", "PersonGender", "PersonNameFirst", "PersonNameLast", "PersonNameMiddle" },
                values: new object[] { 2, new DateTime(1953, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 0, "Geddy", "Lee", null });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonID", "PersonBirthdate", "PersonBirthdateDay", "PersonBirthdateMonth", "PersonDeathDate", "PersonDetails", "PersonGender", "PersonNameFirst", "PersonNameLast", "PersonNameMiddle" },
                values: new object[] { 3, new DateTime(1953, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 0, "Alex", "Lifeson", null });

            migrationBuilder.InsertData(
                table: "PersonArtists",
                columns: new[] { "PersonArtistID", "ArtistID", "PersonID" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "PersonArtists",
                columns: new[] { "PersonArtistID", "ArtistID", "PersonID" },
                values: new object[] { 2, 1, 2 });

            migrationBuilder.InsertData(
                table: "PersonArtists",
                columns: new[] { "PersonArtistID", "ArtistID", "PersonID" },
                values: new object[] { 3, 1, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PersonArtists",
                keyColumn: "PersonArtistID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PersonArtists",
                keyColumn: "PersonArtistID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PersonArtists",
                keyColumn: "PersonArtistID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonID",
                keyValue: 3);
        }
    }
}
