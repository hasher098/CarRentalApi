using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApi.Migrations
{
    public partial class editlambo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Color", "Seats", "TrunkCapacity" },
                values: new object[] { "Czarny", 2, "---" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Color", "Seats", "TrunkCapacity" },
                values: new object[] { "Żółty", 5, "1450L" });
        }
    }
}
