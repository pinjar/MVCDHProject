using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCDHProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Custid = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    Balance = table.Column<decimal>(type: "Money", nullable: true),
                    City = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Custid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
