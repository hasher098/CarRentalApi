using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApi.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Rent");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "BlackList");

            migrationBuilder.AddColumn<string>(
                name: "AspNetUsers",
                table: "Rent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AspNetUsers",
                table: "BlackList",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rent_AspNetUsers",
                table: "Rent",
                column: "AspNetUsers",
                unique: true,
                filter: "[AspNetUsers] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BlackList_AspNetUsers",
                table: "BlackList",
                column: "AspNetUsers",
                unique: true,
                filter: "[AspNetUsers] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_BlackList_AspNetUsers_AspNetUsers",
                table: "BlackList",
                column: "AspNetUsers",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_AspNetUsers_AspNetUsers",
                table: "Rent",
                column: "AspNetUsers",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlackList_AspNetUsers_AspNetUsers",
                table: "BlackList");

            migrationBuilder.DropForeignKey(
                name: "FK_Rent_AspNetUsers_AspNetUsers",
                table: "Rent");

            migrationBuilder.DropIndex(
                name: "IX_Rent_AspNetUsers",
                table: "Rent");

            migrationBuilder.DropIndex(
                name: "IX_BlackList_AspNetUsers",
                table: "BlackList");

            migrationBuilder.DropColumn(
                name: "AspNetUsers",
                table: "Rent");

            migrationBuilder.DropColumn(
                name: "AspNetUsers",
                table: "BlackList");

            migrationBuilder.AddColumn<string>(
                name: "ClientId",
                table: "Rent",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientId",
                table: "BlackList",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
