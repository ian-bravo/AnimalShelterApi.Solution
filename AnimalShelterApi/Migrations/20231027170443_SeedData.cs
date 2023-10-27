using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Age", "Name", "Sex", "Size" },
                values: new object[,]
                {
                    { 1, 7, "Anya", "Female", "Large" },
                    { 2, 10, "Faith", "Female", "Medium" },
                    { 3, 2, "Willow", "Female", "Medium" },
                    { 4, 4, "Spike", "Male", "Small" },
                    { 5, 10, "Giles", "Male", "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Name", "Sex", "Size" },
                values: new object[,]
                {
                    { 1, 5, "Beatrice", "Female", "Large" },
                    { 2, 3, "Winky", "Male", "Small" },
                    { 3, 2, "Hubert", "Male", "Large" },
                    { 4, 4, "Rhapsody", "Female", "Large" },
                    { 5, 7, "Jessica", "Female", "Medium" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 5);
        }
    }
}
