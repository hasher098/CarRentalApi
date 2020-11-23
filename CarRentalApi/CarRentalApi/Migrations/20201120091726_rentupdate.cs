using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApi.Migrations
{
    public partial class rentupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rent_UserID",
                table: "Rent");

            migrationBuilder.CreateIndex(
                name: "IX_Rent_UserID",
                table: "Rent",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rent_UserID",
                table: "Rent");

            migrationBuilder.CreateIndex(
                name: "IX_Rent_UserID",
                table: "Rent",
                column: "UserID",
                unique: true,
                filter: "[UserID] IS NOT NULL");
        }
    }
}
