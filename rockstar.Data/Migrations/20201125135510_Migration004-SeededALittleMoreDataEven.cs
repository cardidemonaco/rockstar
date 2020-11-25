using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace rockstar.Data.Migrations
{
    public partial class Migration004SeededALittleMoreDataEven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonID", "PersonBirthdate", "PersonBirthdateDay", "PersonBirthdateMonth", "PersonDeathDate", "PersonDetails", "PersonGender", "PersonNameFirst", "PersonNameLast", "PersonNameMiddle" },
                values: new object[] { 4, new DateTime(1975, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 0, "Travis", "Barker", null });

            migrationBuilder.InsertData(
                table: "PersonArtists",
                columns: new[] { "PersonArtistID", "ArtistID", "PersonID" },
                values: new object[] { 4, 2, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PersonArtists",
                keyColumn: "PersonArtistID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonID",
                keyValue: 4);
        }
    }
}
