using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApi.Migrations
{
    public partial class migracja2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ClientDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientDetails_UserId",
                table: "ClientDetails",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientDetails_AspNetUsers_UserId",
                table: "ClientDetails",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientDetails_AspNetUsers_UserId",
                table: "ClientDetails");

            migrationBuilder.DropIndex(
                name: "IX_ClientDetails_UserId",
                table: "ClientDetails");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ClientDetails");
        }
    }
}
