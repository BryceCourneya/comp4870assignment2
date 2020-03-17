using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeakerAPI.data.migrations
{
    public partial class M9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "b294819d-17f5-4ff7-afd9-b73499fe52df", "Tom", "Day" },
                    { "370b9c45-b10e-4e4e-affc-b998344235ad", "John", "Fox" },
                    { "5d00b14b-a2b8-4e4e-8e7e-10a2894620f0", "Art", "Ash" },
                    { "f4c34bef-0554-4956-9e0c-64de17b38cfd", "Mia", "Hay" },
                    { "a66c009d-470b-4b7d-befd-364d2eb439ac", "Xam", "Xyllene" },
                    { "10ca9081-1f3b-4500-96d1-bc7fe97be6cd", "Brock", "Nguyen" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "10ca9081-1f3b-4500-96d1-bc7fe97be6cd");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "370b9c45-b10e-4e4e-affc-b998344235ad");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "5d00b14b-a2b8-4e4e-8e7e-10a2894620f0");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "a66c009d-470b-4b7d-befd-364d2eb439ac");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "b294819d-17f5-4ff7-afd9-b73499fe52df");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "f4c34bef-0554-4956-9e0c-64de17b38cfd");

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
    }
}
