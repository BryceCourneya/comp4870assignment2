using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeakerAPI.Data.Migrations
{
    public partial class M5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "88e69f5b-7d87-4d38-b29a-60dffbe0f78c", "Tom", "Day" },
                    { "5404cb88-d41d-4202-b65d-bef8a200fb6c", "John", "Fox" },
                    { "55d49db9-93d6-4cd7-b6db-f8ef75221ea1", "Art", "Ash" },
                    { "2cd1857a-024e-46e1-ae01-2fdca1654dfc", "Mia", "Hay" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "2cd1857a-024e-46e1-ae01-2fdca1654dfc");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "5404cb88-d41d-4202-b65d-bef8a200fb6c");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "55d49db9-93d6-4cd7-b6db-f8ef75221ea1");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "88e69f5b-7d87-4d38-b29a-60dffbe0f78c");

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
    }
}
