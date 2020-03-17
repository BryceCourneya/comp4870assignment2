using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeakerAPI.data.migrations
{
    public partial class M6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "3ee00e53-f591-4cf9-a9bf-e71daf11200b", "Tom", "Day" },
                    { "6770d994-6e0c-4374-91f5-efadbd0368c9", "John", "Fox" },
                    { "b4dc5948-2db1-481e-a88a-269e51d846cc", "Art", "Ash" },
                    { "56afc14c-b967-486b-a513-b3ef08749097", "Mia", "Hay" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "3ee00e53-f591-4cf9-a9bf-e71daf11200b");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "56afc14c-b967-486b-a513-b3ef08749097");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "6770d994-6e0c-4374-91f5-efadbd0368c9");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "b4dc5948-2db1-481e-a88a-269e51d846cc");

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
    }
}
