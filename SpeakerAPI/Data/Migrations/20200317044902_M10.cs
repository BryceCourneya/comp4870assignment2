using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeakerAPI.data.migrations
{
    public partial class M10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "AreaOfSpecialization",
                table: "Speakers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CityOfResidence",
                table: "Speakers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Speakers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Employer",
                table: "Speakers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "Speakers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProvinceOfResidence",
                table: "Speakers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Speakers",
                columns: new[] { "SpeakerId", "AreaOfSpecialization", "CityOfResidence", "Email", "Employer", "FirstName", "LastName", "MobileNumber", "ProvinceOfResidence" },
                values: new object[,]
                {
                    { "a5ab360d-f299-4c26-8777-a5e08f4ac4d6", "Plumber", "Surrey", "TomDay@gmail.com", "Super Plumber", "Tom", "Day", "778-554-2322", "BC" },
                    { "2cbba902-cdd4-402e-80bc-9494137ab3cf", "Construction", "Surrey", "JohnFox@gmail.com", "JF Construction", "John", "Fox", "778-554-2888", "BC" },
                    { "5290943c-ea01-4afa-964b-dacf6f5b8eb3", "Waitress", "Surrey", "ArtAsh@gmail.com", "Cactus Club", "Art", "Ash", "778-554-4444", "BC" },
                    { "b2a532cd-4378-4754-9ad2-f5f817b75915", "Technician", "Surrey", "HiaMia@gmail.com", "Yessir", "Mia", "Hay", "778-554-7777", "BC" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "2cbba902-cdd4-402e-80bc-9494137ab3cf");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "5290943c-ea01-4afa-964b-dacf6f5b8eb3");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "a5ab360d-f299-4c26-8777-a5e08f4ac4d6");

            migrationBuilder.DeleteData(
                table: "Speakers",
                keyColumn: "SpeakerId",
                keyValue: "b2a532cd-4378-4754-9ad2-f5f817b75915");

            migrationBuilder.DropColumn(
                name: "AreaOfSpecialization",
                table: "Speakers");

            migrationBuilder.DropColumn(
                name: "CityOfResidence",
                table: "Speakers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Speakers");

            migrationBuilder.DropColumn(
                name: "Employer",
                table: "Speakers");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "Speakers");

            migrationBuilder.DropColumn(
                name: "ProvinceOfResidence",
                table: "Speakers");

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
    }
}
