using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeakerAPI.Data.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "0cbd8424-0f3a-4860-abba-0ef4a05734b7");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "202227c3-0a88-457e-bebe-bdbc81c39d92");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "5b8c8adc-02d4-4dd4-b6a6-bfd986c79cc8");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "68c95d72-621d-4939-bd08-475f10794f64");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "202227c3-0a88-457e-bebe-bdbc81c39d92", "Tom", "Day" },
                    { "68c95d72-621d-4939-bd08-475f10794f64", "Ann", "Fox" },
                    { "0cbd8424-0f3a-4860-abba-0ef4a05734b7", "Art", "Ash" },
                    { "5b8c8adc-02d4-4dd4-b6a6-bfd986c79cc8", "Mia", "Hay" }
                });
        }
    }
}
