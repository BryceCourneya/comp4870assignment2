using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeakerAPI.data.migrations
{
    public partial class M8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "eabfe4eb-3cd3-4db7-9026-16b84ad557e1", "Tom", "Day" },
                    { "55468490-e851-4276-9d5f-23eac9ff9576", "John", "Fox" },
                    { "863c341c-f97f-425e-bbb9-0311864c5620", "Art", "Ash" },
                    { "a1ab19f4-dea6-4275-a057-2611a915ec85", "Mia", "Hay" },
                    { "af98e926-3654-45a3-9825-ca84ee7c3321", "Xam", "Xyllene" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "55468490-e851-4276-9d5f-23eac9ff9576");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "863c341c-f97f-425e-bbb9-0311864c5620");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "a1ab19f4-dea6-4275-a057-2611a915ec85");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "af98e926-3654-45a3-9825-ca84ee7c3321");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "eabfe4eb-3cd3-4db7-9026-16b84ad557e1");

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
    }
}
