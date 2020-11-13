using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApi.Migrations
{
    public partial class seedy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rent_AspNetUsers_AspNetUsers",
                table: "Rent");

            migrationBuilder.DropIndex(
                name: "IX_Rent_AspNetUsers",
                table: "Rent");

            migrationBuilder.DropColumn(
                name: "AspNetUsers",
                table: "Rent");

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Rent",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IDcardNumber", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Pesel", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b889e9e9-0b5d-453f-9363-e93637b854aa", 0, null, "7db6a340-5be5-4d4e-9e66-0cfcd3cafed3", "Nowak@car.pl", true, null, null, false, null, true, null, "NOWAK@CAR.PL", "NOWAK", "AQAAAAEAACcQAAAAEFXXrcu6Ye/fiHYpciyJvI4YJpii/DoUSonWk8MDmANEMmj6CWd0/4BWilxU5qrVXQ==", null, null, false, "C6SFYJKYII3YIC3UENBIFAIUQTSLSEXZ", false, "Nowak" },
                    { "8399119f-568a-48a8-9fb1-d6a1f451f203", 0, null, "dcb43428-689a-4a8a-b8e6-dcdb335f5ab3", "Admin@car.pl", true, null, null, false, null, true, null, "ADMIN@CAR.PL", "ADMIN", "AQAAAAEAACcQAAAAEJvecAD/HZhoJ9CP2U7W1fTqi03oqb7VOp0kMEtvLcGtQtJmb+/mRK9t2jakVFjymw==", null, null, false, "JRO5CVOZMDY4Z2SLAFAUVRMKZRC37KYY", false, "Admin" },
                    { "6bb1647e-c2f3-4def-a875-32644e0b2b9f", 0, null, "a5ad219f-a9f2-496b-bf0c-8c2a497b9e3e", "Kowalski@car.pl", true, null, null, false, null, true, null, "KOWALSKI@CAR.PL", "KOWALSKI", "AQAAAAEAACcQAAAAEADelhIMbQU6jfcAMsBqJQTVDiaThzjbTdIfjK2QWJNrTRzo2SY35zKu40IsY/nExg==", null, null, false, "NF4PUWRF3ZAADUYZ4NGTF2HESVLTQI7O", false, "Kowalski" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BodyType", "Brand", "Class", "Color", "EngineCapacity", "Gearbox", "Model", "RoofRack", "Seats", "TrunkCapacity", "Year" },
                values: new object[,]
                {
                    { 25, "SUV", "Audi", "J", "Czarny", "3.0 TDI", "M", "Q7", true, 5, "1930L", 2017 },
                    { 24, "Minivan", "Ford", "M", "Czarny", "2.0 Ecoblue", "AT", "Galaxy", false, 5, "2000L", 2017 },
                    { 23, "Van", "Seat", "M", "Srebrny", "2.0 TDI", "M", "Alhambra", false, 5, "2000L", 2018 },
                    { 22, "Van", "Volkswagen", "M", "Czarny", "2.0 TDI", "AT", "Sharan", false, 7, "2000L", 2016 },
                    { 21, "Cabriolet", "BMW", "H", "Czarny", "2.5", "M", "Z4", false, 5, "280L", 2016 },
                    { 20, "Cabriolet", "Audi", "H", "Biały", "2.0 TFSI", "AT", "TT", false, 5, "600L", 2015 },
                    { 19, "Coupe", "Audi", "S", "Niebieski", "5.2", "AT", "R8", false, 5, "---", 2018 },
                    { 18, "Coupe", "Lamborghini", "S", "Żółty", "6.5 V12", "AT", "Aventador", false, 5, "1450L", 2016 },
                    { 17, "Hatchback", "Audi", "C", "Czarny", "2.0 TDI", "AT", "A3", false, 5, "1250L", 2014 },
                    { 16, "Hatchback", "BMW", "C", "Czarny", "2.0 D", "M", "Seria 1", false, 5, "1280L", 2013 },
                    { 15, "Hatchback", "Fiat", "A", "Biały", "1.0", "M", "Panda", false, 5, "1000L", 2017 },
                    { 14, "Sedan", "Audi", "S", "Czarny", "5.0 V10 TFSI", "AT", "RS6", false, 5, "1500L", 2010 },
                    { 12, "Sedan", "Audi", "F", "Czarny", "4.2 TDI", "AT", "A8", false, 5, "1700L", 2016 },
                    { 11, "Sedan", "Ford", "D", "Czarny", "2.0 TDCi", "M", "Mondeo", false, 5, "1450L", 2016 },
                    { 10, "Kombi", "Mazda", "D", "Czerwony", "2.0 Skyaktiv", "AT", "6", true, 5, "1400L", 2015 },
                    { 9, "Kombi", "Volkswagen", "D", "Czarny", "2.0 TSI", "M", "Passat", true, 5, "1400L", 2013 },
                    { 8, "Hatchback", "Volkswagen", "B", "Niebieski", "2.0 TSI", "AT", "Golf", false, 5, "800L", 2017 },
                    { 7, "Hatchback", "Nissan", "A", "Czerwony", "1.0", "M", "Micra", false, 5, "800L", 2015 },
                    { 6, "Hatchback", "Nissan", "A", "Czerwony", "1.0", "M", "Micra", false, 5, "800L", 2015 },
                    { 5, "Sedan", "Opel", "D", "Czarny", "2.0", "M", "Insignia", false, 5, "1470L", 2016 },
                    { 4, "Sedan", "Volkswagen", "D", "Czarny", "2.0", "M", "Passat", false, 5, "1150L", 2016 },
                    { 3, "Hatchback", "Opel", "B", "Niebieski", "1.6 T", "A", "Corsa", false, 5, "1100L", 2010 },
                    { 2, "Hatchback", "Toyota", "B", "Srebrny", "1.0", "M", "Yaris", false, 5, "768L", 2015 },
                    { 13, "Kombi", "Audi", "F", "Czarny", "3.0 TDI", "AT", "A6", true, 5, "1570L", 2014 },
                    { 1, "Hatchback", "Kia", "B", "Czarny", "1.4", "M", "Rio", false, 5, "400L", 2012 }
                });

            migrationBuilder.InsertData(
                table: "BlackList",
                columns: new[] { "Id", "BlacklistedUserId", "IsBlacklisted", "Reason" },
                values: new object[] { 1, "b889e9e9-0b5d-453f-9363-e93637b854aa", true, "Ukradł drzwi" });

            migrationBuilder.InsertData(
                table: "CarCopy",
                columns: new[] { "Id", "CarId", "IsRented", "RegistrationNumber" },
                values: new object[] { 1, 1, true, "ERA 2137" });

            migrationBuilder.InsertData(
                table: "Pricing",
                columns: new[] { "Id", "CarCopyId", "Class", "Description", "PricePerDay" },
                values: new object[] { 1, 1, "B", "Allalalalalalalalalalalala", 500 });

            migrationBuilder.InsertData(
                table: "Rent",
                columns: new[] { "Id", "CarCopyId", "RentDate", "ReturnDate", "UserID" },
                values: new object[] { 1, 1, new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "6bb1647e-c2f3-4def-a875-32644e0b2b9f" });

            migrationBuilder.CreateIndex(
                name: "IX_Rent_UserID",
                table: "Rent",
                column: "UserID",
                unique: true,
                filter: "[UserID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_AspNetUsers_UserID",
                table: "Rent",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rent_AspNetUsers_UserID",
                table: "Rent");

            migrationBuilder.DropIndex(
                name: "IX_Rent_UserID",
                table: "Rent");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8399119f-568a-48a8-9fb1-d6a1f451f203");

            migrationBuilder.DeleteData(
                table: "BlackList",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Pricing",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rent",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bb1647e-c2f3-4def-a875-32644e0b2b9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b889e9e9-0b5d-453f-9363-e93637b854aa");

            migrationBuilder.DeleteData(
                table: "CarCopy",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Rent");

            migrationBuilder.AddColumn<string>(
                name: "AspNetUsers",
                table: "Rent",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rent_AspNetUsers",
                table: "Rent",
                column: "AspNetUsers",
                unique: true,
                filter: "[AspNetUsers] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_AspNetUsers_AspNetUsers",
                table: "Rent",
                column: "AspNetUsers",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
