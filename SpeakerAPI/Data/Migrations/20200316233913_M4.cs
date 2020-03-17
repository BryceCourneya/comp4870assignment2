using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeakerAPI.Data.Migrations
{
    public partial class M4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "41fb7377-dbcf-46ee-b7a6-19dcd0728f04");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "995752f3-2e48-4636-a4c0-977641929ad9");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "c69fed55-9a5b-4c6e-b27c-45e1c3da011d");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "fdccf36f-b096-4c13-9d3a-7a802d361701");

            migrationBuilder.InsertData(
                table: "Speakers",
                columns: new[] { "SpeakerId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { "3d1da08e-0ab5-4d07-aa81-a37312a0e7cc", "Tom", "Day" },
                    { "c4f94c6d-35ef-4955-8fe8-a2a7a484e9f7", "John", "Fox" },
                    { "b3dd0f2d-459a-4cfa-9b82-f16343ba2e7e", "Art", "Ash" },
                    { "1fa047e7-b7b1-4c30-808e-73c2fa2524b3", "Mia", "Hay" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "1fa047e7-b7b1-4c30-808e-73c2fa2524b3");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "3d1da08e-0ab5-4d07-aa81-a37312a0e7cc");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "b3dd0f2d-459a-4cfa-9b82-f16343ba2e7e");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "c4f94c6d-35ef-4955-8fe8-a2a7a484e9f7");

            migrationBuilder.InsertData(
                table: "Speakers",
                columns: new[] { "SpeakerId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { "fdccf36f-b096-4c13-9d3a-7a802d361701", "Tom", "Day" },
                    { "995752f3-2e48-4636-a4c0-977641929ad9", "Ann", "Fox" },
                    { "41fb7377-dbcf-46ee-b7a6-19dcd0728f04", "Art", "Ash" },
                    { "c69fed55-9a5b-4c6e-b27c-45e1c3da011d", "Mia", "Hay" }
                });
        }
    }
}
