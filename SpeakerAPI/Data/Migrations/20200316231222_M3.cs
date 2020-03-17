using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeakerAPI.Data.Migrations
{
    public partial class M3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "69c1fe72-f9fa-4340-b89d-a032c3086567");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "78436cc2-964a-4df6-9da5-b42d7a565484");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "b9461f67-a78b-4a07-9289-23f9ad3c7838");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "cfef28c7-35f3-41aa-bafe-d83cfcf08068");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "78436cc2-964a-4df6-9da5-b42d7a565484", "Tom", "Day" },
                    { "cfef28c7-35f3-41aa-bafe-d83cfcf08068", "Ann", "Fox" },
                    { "69c1fe72-f9fa-4340-b89d-a032c3086567", "Art", "Ash" },
                    { "b9461f67-a78b-4a07-9289-23f9ad3c7838", "Mia", "Hay" }
                });
        }
    }
}
