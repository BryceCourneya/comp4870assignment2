using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeakerAPI.data.migrations
{
    public partial class M7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "c5d5ffff-9c58-4cb8-ac7c-0211aa7bcf9e", "Tom", "Day" },
                    { "5750ffae-c8bb-4dcb-b468-d0f503e3762f", "John", "Fox" },
                    { "dc7f6f4d-7f10-4cf4-8681-1ee32e8476ea", "Art", "Ash" },
                    { "6069ec86-3442-48e8-9767-d4d859a57211", "Mia", "Hay" },
                    { "69ac8727-2713-4d9d-9bb5-de9d7758bb8a", "Xam", "Xyllene" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "5750ffae-c8bb-4dcb-b468-d0f503e3762f");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "6069ec86-3442-48e8-9767-d4d859a57211");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "69ac8727-2713-4d9d-9bb5-de9d7758bb8a");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "c5d5ffff-9c58-4cb8-ac7c-0211aa7bcf9e");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "dc7f6f4d-7f10-4cf4-8681-1ee32e8476ea");

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
    }
}
