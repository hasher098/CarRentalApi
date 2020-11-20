using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApi.Migrations
{
    public partial class willthiswork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    IDcardNumber = table.Column<string>(maxLength: 9, nullable: true),
                    Pesel = table.Column<string>(maxLength: 11, nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Class = table.Column<string>(maxLength: 255, nullable: false),
                    Brand = table.Column<string>(maxLength: 255, nullable: false),
                    Model = table.Column<string>(maxLength: 255, nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Color = table.Column<string>(maxLength: 255, nullable: true),
                    EngineCapacity = table.Column<string>(nullable: false),
                    Seats = table.Column<int>(nullable: false),
                    Gearbox = table.Column<string>(maxLength: 2, nullable: false),
                    TrunkCapacity = table.Column<string>(maxLength: 10, nullable: false),
                    RoofRack = table.Column<bool>(nullable: false),
                    BodyType = table.Column<string>(maxLength: 20, nullable: false),
                    image = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlackList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlacklistedUserId = table.Column<string>(nullable: true),
                    IsBlacklisted = table.Column<bool>(nullable: false),
                    Reason = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlackList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlackList_AspNetUsers_BlacklistedUserId",
                        column: x => x.BlacklistedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarCopy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationNumber = table.Column<string>(maxLength: 10, nullable: false),
                    CarId = table.Column<int>(nullable: false),
                    IsRented = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCopy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarCopy_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pricing",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarCopyId = table.Column<int>(nullable: false),
                    Class = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    PricePerDay = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pricing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pricing_CarCopy_CarCopyId",
                        column: x => x.CarCopyId,
                        principalTable: "CarCopy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(nullable: true),
                    CarCopyId = table.Column<int>(nullable: false),
                    RentDate = table.Column<DateTime>(nullable: false),
                    ReturnDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rent_CarCopy_CarCopyId",
                        column: x => x.CarCopyId,
                        principalTable: "CarCopy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rent_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IDcardNumber", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Pesel", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4b9d5218-9049-487e-b5b7-74b7b6527cf1", 0, null, "6056ca99-1b1a-4da3-8296-e7bfd454fbce", "Hajto@wp.pl", true, null, null, false, null, true, null, "HAJTO@WP.PL", "TOMASZHAJTO", "AQAAAAEAACcQAAAAEMhlYs1Bv230/gikTAepq5ACdvZGExUFFsg7mCr5n4djDgCHgnfFlmwdCfyjGJOnng==", null, null, false, "6R6COOBSQJ6BUB7MODICTNADCJ7V2D4Z", false, "TomaszHajto" },
                    { "6bb1647e-c2f3-4def-a875-32644e0b2b9f", 0, null, "a5ad219f-a9f2-496b-bf0c-8c2a497b9e3e", "Kowalski@car.pl", true, null, null, false, null, true, null, "KOWALSKI@CAR.PL", "KOWALSKI", "AQAAAAEAACcQAAAAEADelhIMbQU6jfcAMsBqJQTVDiaThzjbTdIfjK2QWJNrTRzo2SY35zKu40IsY/nExg==", null, null, false, "NF4PUWRF3ZAADUYZ4NGTF2HESVLTQI7O", false, "Kowalski" },
                    { "b889e9e9-0b5d-453f-9363-e93637b854aa", 0, null, "7db6a340-5be5-4d4e-9e66-0cfcd3cafed3", "Nowak@car.pl", true, null, null, false, null, true, null, "NOWAK@CAR.PL", "NOWAK", "AQAAAAEAACcQAAAAEFXXrcu6Ye/fiHYpciyJvI4YJpii/DoUSonWk8MDmANEMmj6CWd0/4BWilxU5qrVXQ==", null, null, false, "C6SFYJKYII3YIC3UENBIFAIUQTSLSEXZ", false, "Nowak" },
                    { "10966c59-49f1-470a-a90c-94755d3870b3", 0, null, "a870f5e2-c084-4929-bbf5-6596af966e39", "Lewandowski123@gmail.com", true, null, null, false, null, true, null, "LEWANDOWSKI123@GMAIL.COM", "LEWANDOWSKI", "AQAAAAEAACcQAAAAEE8ySKAxHp1dS9Er4pzs8FrqWwrdhZxsEKAs5rW3DQXRMgJVn5y5g3N8/e/4EJuK+w==", null, null, false, "AOLABNGPJHBQDI2K5K6VX2OYDOLZABWZ", false, "Lewandowski" },
                    { "8399119f-568a-48a8-9fb1-d6a1f451f203", 0, null, "dcb43428-689a-4a8a-b8e6-dcdb335f5ab3", "Admin@car.pl", true, null, null, false, null, true, null, "ADMIN@CAR.PL", "ADMIN", "AQAAAAEAACcQAAAAEJvecAD/HZhoJ9CP2U7W1fTqi03oqb7VOp0kMEtvLcGtQtJmb+/mRK9t2jakVFjymw==", null, null, false, "JRO5CVOZMDY4Z2SLAFAUVRMKZRC37KYY", false, "Admin" },
                    { "9952718a-e4af-40b1-8dce-fe07967d4534", 0, null, "08680348-2b35-47f9-a90e-430ac9e91db7", "EndrjuDuda@gmail.com", true, null, null, false, null, true, null, "ENDRJUDUDA@GMAIL.com", "ENDRJUDUDA", "AQAAAAEAACcQAAAAEB8p9tWazRY8rhOEu/USJAstdhfMDpQf+82fi51KkrGYfUCeFU0qIqoPtv7E/AhjMg==", null, null, false, "WTWJMTDKPF3HA6OUK472DQAKAJ54XTRS", false, "EndrjuDuda" },
                    { "c514dedb-db0a-49e9-a5e6-44e875c0d6fd", 0, null, "51b33cd0-0ab7-4d8e-893d-8da6feb7096d", "Ziobro123@gmail.com", true, null, null, false, null, true, null, "ZIOBRO123@GMAIL.COM", "ZBIGNIEWZIOBRO", "AQAAAAEAACcQAAAAEPQ0yzuj4mcljU0lmBZHFHZun6FuoN2oR6YF6dKaDPY/xWES3NSYBRMb1gozEQuFyQ==", null, null, false, "XJX42PJ6RHFIPJXJI25FTEH4HBEYLGSX", false, "ZbigniewZiobro" },
                    { "711aa82e-b3af-482a-b2eb-8056e2b4e482", 0, null, "c76128d8-d3a9-4b45-929f-b4375b133ffc", "Stonoga@gmail.com", true, null, null, false, null, true, null, "STONOGA@GMAIL.COM", "ZBYSZEKSTONOGA", "AQAAAAEAACcQAAAAEPmAxB56NFlCeenVjKtgCyLEQ9T7hEBb9OyhtOdWT1H9Ma48df361TfTHqYLxSGfqQ==", null, null, false, "K6C2VKRDVSTZGZAOZ2SGLFV2W73L57M2", false, "ZbyszekStonoga" },
                    { "c89548b7-838f-4b90-94ac-763198501ce9", 0, null, "18b4ca59-cb79-459c-9578-8d65a5090d6c", "OwcaWK@gmail.com", true, null, null, false, null, true, null, "OWCAWK@GMAIL.COM", "OWCAWK", "AQAAAAEAACcQAAAAEAglmTAktrhxGf8FTo4ChX6re3EMp4Hi5jMl946pGhDMhZ0BFem75BKME7CrgYpJww==", null, null, false, "LVC765MPWOBA3V2SZXSYWLPEVTTXDRJQ", false, "OwcaWK" },
                    { "304f6dbe-c471-45ad-a540-f4992be6f746", 0, null, "4373af8a-d161-4d96-851a-8d8506071b35", "Janowicz@gmail.com", true, null, null, false, null, true, null, "JANOWICZ@GMAIL.COM", "JERZYJANOWICZ", "AQAAAAEAACcQAAAAEKvFcCpDXeifSMEOZvbCUujCmLcw237R1v0P67LGE1MgFhB/zMQ3cG2UeBdt+BmvXQ==", null, null, false, "TMP3G6SC4PUNHPLDMKNIQ45NIDA6CY2G", false, "JerzyJanowicz" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BodyType", "Brand", "Class", "Color", "EngineCapacity", "Gearbox", "Model", "RoofRack", "Seats", "TrunkCapacity", "Year", "image" },
                values: new object[,]
                {
                    { 19, "Coupe", "Audi", "S", "Niebieski", "5.2", "AT", "R8", false, 5, "---", 2018, "https://www.auto-motor-i-sport.pl/media/lib/2555/2019-audi-r8.jpg" },
                    { 25, "SUV", "Audi", "J", "Czerwony", "3.0 TDI", "M", "Q7", true, 5, "1930L", 2017, "https://i.wpimg.pl/1641x0/m.autokult.pl/audi-q7-2020-12-db837ab88fc7ecce,0,0,0,0.jpg" },
                    { 24, "Minivan", "Ford", "M", "Granatowy", "2.0 Ecoblue", "AT", "Galaxy", false, 5, "2000L", 2017, "https://mojepokrowce.pl/userdata/public/gfx/847b505b0cacd7c8a3540c729178eaa9.jpg" },
                    { 23, "Van", "Seat", "M", "Czerwony", "2.0 TDI", "M", "Alhambra", false, 5, "2000L", 2018, "https://www.autocentrum.pl/ac-file/gallery-photo/5dd3e3e5583a0f08331e2683.jpg" },
                    { 22, "Van", "Volkswagen", "M", "Czarny", "2.0 TDI", "AT", "Sharan", false, 7, "2000L", 2016, "https://a.allegroimg.com/s512/11f6a1/16b75bc14ce790cd1da60cd90de2/VW-SHARAN-2-0-TDI-140KM_BOGATY_WLASCICIEL-BOGATY" },
                    { 21, "Cabriolet", "BMW", "H", "Biały", "2.5", "M", "Z4", false, 5, "280L", 2016, "https://media.istockphoto.com/photos/white-bmw-z4-sports-car-picture-id458934741" },
                    { 20, "Cabriolet", "Audi", "H", "Biały", "2.0 TFSI", "AT", "TT", false, 5, "600L", 2015, "https://image.ceneostatic.pl/data/products/73512595/i-audi-tt-s-line-tfsi-2010-2-0-200-km-194-000km.jpg" },
                    { 18, "Coupe", "Lamborghini", "S", "Żółty", "6.5 V12", "AT", "Aventador", false, 5, "1450L", 2016, "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/2015_Lamborghini_Aventador_LP700-4_Pirelli_Edition_6.5_Front.jpg/1200px-2015_Lamborghini_Aventador_LP700-4_Pirelli_Edition_6.5_Front.jpg" },
                    { 16, "Hatchback", "BMW", "C", "Granatowy", "2.0 D", "M", "Seria 1", false, 5, "1280L", 2013, "https://www.wyborkierowcow.pl/wp-content/uploads/2017/08/BMW-serii-1-sylwetka-1.jpg" },
                    { 2, "Hatchback", "Toyota", "B", "Czerwony", "1.0", "M", "Yaris", false, 5, "768L", 2015, "https://ocdn.eu/pulscms-transforms/1/JiNktkuTURBXy8wZDczN2QxNC03MTU3LTRiMWYtYjA4ZS02YjA2Y2M2ODMyMTUuanBlZ5GVAs0EsM0CpMLD" },
                    { 3, "Hatchback", "Opel", "B", "Zielony", "1.6 T", "A", "Corsa", false, 5, "1100L", 2016, "https://www.autobaza.pl/blog/wp-content/uploads/2019/06/corsa-740x431@2x.jpg" },
                    { 4, "Kombi", "Volkswagen", "D", "Szary", "2.0", "M", "Passat", false, 5, "1150L", 2016, "https://i.wpimg.pl/1200x0/m.autokult.pl/vw-passat-rline-2019-5-e3cfb69cb.jpg" },
                    { 5, "Sedan", "Opel", "D", "Niebieski", "2.0", "M", "Insignia", false, 5, "1470L", 2016, "https://dixi-car.pl/foto/galeria/insignia-b-fl/nowy-opel-insignia-grand-sport-fl.jpg" },
                    { 6, "Hatchback", "Nissan", "A", "Pomarańczowy", "1.0", "M", "Micra", false, 5, "800L", 2015, "https://www-europe.nissan-cdn.net/content/dam/Nissan/nissan_europe/Configurator/Micra-March/k14a/grade/16TDIeulhd_B02E_MICRA_HELIOSConfigurator_002.jpg.ximg.l_12_m.smart.jpg" },
                    { 7, "Hatchback", "Nissan", "A", "Czerwony", "1.0", "M", "Micra", false, 5, "800L", 2015, "https://cdntdreditorials.azureedge.net/cache/7/e/6/b/6/3/7e6b63e11ab1d8dabff7dc0178b2653486e31f96.jpg" },
                    { 17, "Sedan", "Audi", "C", "Czarny", "2.0 TDI", "AT", "A3", false, 5, "1250L", 2014, "https://ireland.apollo.olxcdn.com/v1/files/eyJmbiI6InI2a2RyamFocTJodi1PVE9NT1RPUEwiLCJ3IjpbeyJmbiI6IndnNGducXA2eTFmLU9UT01PVE9QTCIsInMiOiIxNiIsInAiOiIxMCwtMTAiLCJhIjoiMCJ9XX0.TMLNc1Ljd6NGiAk5PU5wHeMbqFMTLJfj8xn0md7vgwk/image;s=1080x720" },
                    { 8, "Hatchback", "Volkswagen", "B", "Limonkowy", "2.0 TSI", "AT", "Golf", false, 5, "800L", 2017, "https://www.autocentrum.pl/ac-file/gallery-photo/5df60c2b57502acb2539841e/volkswagen-golf.jpg" },
                    { 10, "Sedan", "Mazda", "D", "Czerwony", "2.0 Skyaktiv", "AT", "6", true, 5, "1400L", 2015, "https://wokolmotoryzacji.pl/wp-content/uploads/2020/04/2023-mazda-6-rendering-1024x576.jpg" },
                    { 11, "Sedan", "Ford", "D", "Czarny", "2.0 TDCi", "M", "Mondeo", false, 5, "1450L", 2016, "https://img.tipcars.com/fotky_velke/18082919_1/1572854594/E/ford-mondeo-2-0-tdci-titanium.jpg" },
                    { 12, "Sedan", "Audi", "F", "Czarny", "4.2 TDI", "AT", "A8", false, 5, "1700L", 2016, "https://i.wpimg.pl/730x0/m.autokult.pl/2021-audi-a8-l-security--ec2f982.jpg" },
                    { 13, "Sedan", "Audi", "F", "Niebieski", "3.0 TDI", "AT", "A6", true, 5, "1570L", 2017, "https://i.wpimg.pl/985x0/m.autokult.pl/audi-a6-ae1f38db7ee5e6b7d4322d1d.jpg" },
                    { 14, "Kombi", "Audi", "S", "Zielony", "5.0 V10 TFSI", "AT", "RS6", false, 5, "1500L", 2019, "https://wokolmotoryzacji.pl/wp-content/uploads/2020/05/Wheelsandmore-Audi-RS6-Avant-1-1024x724.jpg" },
                    { 15, "Hatchback", "Fiat", "A", "Biały", "1.0", "M", "Panda", false, 5, "1000L", 2017, "https://img.chceauto.pl/arts/3904/fiat-panda-waze-31419_v1.jpg" },
                    { 9, "Kombi", "Volkswagen", "D", "Czarny", "2.0 TSI", "M", "Passat", true, 5, "1400L", 2013, "https://image.ceneostatic.pl/data/products/66665781/i-volkswagen-passat-b8-2017-190km-kombi-czarny.jpg" },
                    { 1, "Hatchback", "Kia", "B", "Biały", "1.4", "M", "Rio", false, 5, "400L", 2012, "https://www.newsauto.pl/wp-content/uploads/2018/03/kia-gene-rio1.jpg" }
                });

            migrationBuilder.InsertData(
                table: "BlackList",
                columns: new[] { "Id", "BlacklistedUserId", "IsBlacklisted", "Reason" },
                values: new object[,]
                {
                    { 6, "304f6dbe-c471-45ad-a540-f4992be6f746", true, "Potrącił starą kobiete na pasach i nie poniósł żadnych konsekwencji prawnych" },
                    { 4, "c514dedb-db0a-49e9-a5e6-44e875c0d6fd", true, "Pobił prezesa firmy" },
                    { 5, "9952718a-e4af-40b1-8dce-fe07967d4534", true, "Piłował auto do odciny i zatarł silnik" },
                    { 2, "10966c59-49f1-470a-a90c-94755d3870b3", true, "Skasował auto" },
                    { 1, "b889e9e9-0b5d-453f-9363-e93637b854aa", true, "Ukradł drzwi" },
                    { 3, "711aa82e-b3af-482a-b2eb-8056e2b4e482", true, "Zostawił auto w krzakach" }
                });

            migrationBuilder.InsertData(
                table: "CarCopy",
                columns: new[] { "Id", "CarId", "IsRented", "RegistrationNumber" },
                values: new object[,]
                {
                    { 25, 25, true, "DWR 35812" },
                    { 24, 24, false, "DW 33257" },
                    { 23, 23, true, "KRA 29341" },
                    { 22, 22, false, "KR 42931" },
                    { 21, 21, false, "WZ PQW21" },
                    { 20, 20, false, "WU 23456" },
                    { 19, 19, false, "SR 42345" },
                    { 18, 18, true, "EP PP223" },
                    { 17, 17, false, "EPI 22598" },
                    { 16, 16, false, "SZ 325SA" },
                    { 14, 14, false, "GDA 32145" },
                    { 13, 13, true, "SCZ 52123" },
                    { 12, 12, false, "SC AP442" },
                    { 11, 11, false, "EWI 22135" },
                    { 10, 10, false, "WI 48235" },
                    { 9, 9, false, "SB 123123" },
                    { 8, 8, false, "SK 9632A" },
                    { 7, 7, false, "EL R2321A" },
                    { 6, 6, false, "EPJ AS128" },
                    { 5, 5, false, "SLU 67123" },
                    { 4, 4, false, "SKL S8421" },
                    { 3, 3, false, "SCZ 1523A" },
                    { 2, 2, true, "SC 12345" },
                    { 15, 15, false, "SW 12346" },
                    { 1, 1, false, "ERA 2137P" }
                });

            migrationBuilder.InsertData(
                table: "Pricing",
                columns: new[] { "Id", "CarCopyId", "Class", "Description", "PricePerDay" },
                values: new object[,]
                {
                    { 1, 1, "A", "Mały samochód", 50 },
                    { 2, 2, "B", "Auto miejskie", 100 },
                    { 3, 3, "C", "Auto typu Kompakt", 150 },
                    { 4, 4, "D", "Auto klasy średniej", 200 },
                    { 5, 5, "E", "Auto klasy wyższej", 350 },
                    { 6, 6, "F", "Auto luksusowe", 500 },
                    { 7, 7, "S", "Auto sportowe", 500 },
                    { 8, 8, "H", "Auto typu Kabriolet", 250 },
                    { 9, 9, "J", "Auto terenowe", 400 },
                    { 10, 10, "M", "Auto typu VAN", 300 }
                });

            migrationBuilder.InsertData(
                table: "Rent",
                columns: new[] { "Id", "CarCopyId", "RentDate", "ReturnDate", "UserID" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "6bb1647e-c2f3-4def-a875-32644e0b2b9f" },
                    { 2, 2, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "10966c59-49f1-470a-a90c-94755d3870b3" },
                    { 3, 3, new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "c89548b7-838f-4b90-94ac-763198501ce9" },
                    { 4, 4, new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "b889e9e9-0b5d-453f-9363-e93637b854aa" },
                    { 5, 5, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "304f6dbe-c471-45ad-a540-f4992be6f746" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BlackList_BlacklistedUserId",
                table: "BlackList",
                column: "BlacklistedUserId",
                unique: true,
                filter: "[BlacklistedUserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CarCopy_CarId",
                table: "CarCopy",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Pricing_CarCopyId",
                table: "Pricing",
                column: "CarCopyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rent_CarCopyId",
                table: "Rent",
                column: "CarCopyId");

            migrationBuilder.CreateIndex(
                name: "IX_Rent_UserID",
                table: "Rent",
                column: "UserID",
                unique: true,
                filter: "[UserID] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BlackList");

            migrationBuilder.DropTable(
                name: "Pricing");

            migrationBuilder.DropTable(
                name: "Rent");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CarCopy");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
