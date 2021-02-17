using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsStoreMVC.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1L, "Watersports", "Protective and fashionable", "Lifejacket", 48.95m },
                    { 2L, "Soccer", "FIFA-approved size and weight", "Soccer Ball", 19.50m },
                    { 3L, "Soccer", "Give your playing field a professional touch", "Corner Flags", 34.95m },
                    { 4L, "Soccer", "Flat-packed 35,000-seat stadium", "Stadium", 79500m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4L);
        }
    }
}
