using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCDHProject.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Custid", "Balance", "City", "Name", "Status" },
                values: new object[,]
                {
                    { 101, 50000.00m, "Delhi", "Sai", true },
                    { 102, 40000.00m, "Mumbai", "Sonia", true },
                    { 103, 30000.00m, "Chennai", "Pankaj", true },
                    { 104, 25000.00m, "Bengaluru", "Samuels", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Custid",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Custid",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Custid",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Custid",
                keyValue: 104);
        }
    }
}
