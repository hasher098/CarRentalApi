using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rent",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rent",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rent",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rent",
                keyColumn: "Id",
                keyValue: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pricing",
                columns: new[] { "Id", "CarCopyId", "Class", "Description", "PricePerDay" },
                values: new object[,]
                {
                    { 1, 1, "A", "Mały samochód", 50 },
                    { 2, 4, "B", "Auto miejskie", 100 },
                    { 3, 5, "C", "Auto typu Kompakt", 150 },
                    { 4, 3, "D", "Auto klasy średniej", 200 },
                    { 5, 7, "E", "Auto klasy wyższej", 350 },
                    { 6, 2, "F", "Auto luksusowe", 500 },
                    { 7, 10, "S", "Auto sportowe", 500 },
                    { 8, 8, "H", "Auto typu Kabriolet", 250 },
                    { 9, 9, "J", "Auto terenowe", 400 },
                    { 10, 1, "M", "Auto typu VAN", 300 }
                });

            migrationBuilder.InsertData(
                table: "Rent",
                columns: new[] { "Id", "CarCopyId", "RentDate", "ReturnDate", "UserID" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "6bb1647e-c2f3-4def-a875-32644e0b2b9f" },
                    { 3, 3, new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "6bb1647e-c2f3-4def-a875-32644e0b2b9f" },
                    { 4, 4, new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "6bb1647e-c2f3-4def-a875-32644e0b2b9f" },
                    { 5, 5, new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "6bb1647e-c2f3-4def-a875-32644e0b2b9f" }
                });
        }
    }
}
