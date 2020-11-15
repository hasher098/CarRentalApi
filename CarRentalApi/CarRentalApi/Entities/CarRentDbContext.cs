using CarRentalApi.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApi.Entities
{
    public class CarRentDbContext : IdentityDbContext<ApplicationUser>
    {

        public CarRentDbContext(DbContextOptions<CarRentDbContext> options)
            : base(options)
        { }
        

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarCopy> CarCopies { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<BlackList> BlackList { get; set; }


        DateTime data1 = new DateTime(2020, 11, 12);
        DateTime data2 = new DateTime(2020, 11, 16);

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>().HasData(
                 new Authentication.ApplicationUser
                 {
                     Id = "8399119f-568a-48a8-9fb1-d6a1f451f203",
                     UserName = "Admin",
                     NormalizedUserName = "ADMIN",
                     Email = "Admin@car.pl",
                     NormalizedEmail = "ADMIN@CAR.PL",
                     EmailConfirmed = true,
                     PasswordHash = "AQAAAAEAACcQAAAAEJvecAD/HZhoJ9CP2U7W1fTqi03oqb7VOp0kMEtvLcGtQtJmb+/mRK9t2jakVFjymw==",
                     SecurityStamp = "JRO5CVOZMDY4Z2SLAFAUVRMKZRC37KYY",
                     ConcurrencyStamp = "dcb43428-689a-4a8a-b8e6-dcdb335f5ab3",
                     TwoFactorEnabled = false,
                     LockoutEnabled = true,
                     AccessFailedCount = 0
                 },//haslo Admin123!
                 new Authentication.ApplicationUser
                 {
                     Id = "6bb1647e-c2f3-4def-a875-32644e0b2b9f",
                     UserName = "Kowalski",
                     NormalizedUserName = "KOWALSKI",
                     Email = "Kowalski@car.pl",
                     NormalizedEmail = "KOWALSKI@CAR.PL",
                     EmailConfirmed = true,
                     PasswordHash = "AQAAAAEAACcQAAAAEADelhIMbQU6jfcAMsBqJQTVDiaThzjbTdIfjK2QWJNrTRzo2SY35zKu40IsY/nExg==",
                     SecurityStamp = "NF4PUWRF3ZAADUYZ4NGTF2HESVLTQI7O",
                     ConcurrencyStamp = "a5ad219f-a9f2-496b-bf0c-8c2a497b9e3e",
                     TwoFactorEnabled = false,
                     LockoutEnabled = true,
                     AccessFailedCount = 0
                 },//HASLO Kowalski123!
                 new Authentication.ApplicationUser
                 {
                     Id = "b889e9e9-0b5d-453f-9363-e93637b854aa",
                     UserName = "Nowak",
                     NormalizedUserName = "NOWAK",
                     Email = "Nowak@car.pl",
                     NormalizedEmail = "NOWAK@CAR.PL",
                     EmailConfirmed = true,
                     PasswordHash = "AQAAAAEAACcQAAAAEFXXrcu6Ye/fiHYpciyJvI4YJpii/DoUSonWk8MDmANEMmj6CWd0/4BWilxU5qrVXQ==",
                     SecurityStamp = "C6SFYJKYII3YIC3UENBIFAIUQTSLSEXZ",
                     ConcurrencyStamp = "7db6a340-5be5-4d4e-9e66-0cfcd3cafed3",
                     TwoFactorEnabled = false,
                     LockoutEnabled = true,
                     AccessFailedCount = 0
                 },//HASLO Nowak123!
                 new Authentication.ApplicationUser
                 {
                     Id = "10966c59-49f1-470a-a90c-94755d3870b3",
                     UserName = "Lewandowski",
                     NormalizedUserName = "LEWANDOWSKI",
                     Email = "Lewandowski123@gmail.com",
                     NormalizedEmail = "LEWANDOWSKI123@GMAIL.COM",
                     EmailConfirmed = true,
                     PasswordHash = "AQAAAAEAACcQAAAAEE8ySKAxHp1dS9Er4pzs8FrqWwrdhZxsEKAs5rW3DQXRMgJVn5y5g3N8/e/4EJuK+w==",
                     SecurityStamp = "AOLABNGPJHBQDI2K5K6VX2OYDOLZABWZ",
                     ConcurrencyStamp = "a870f5e2-c084-4929-bbf5-6596af966e39",
                     TwoFactorEnabled = false,
                     LockoutEnabled = true,
                     AccessFailedCount = 0
                 },//HASLO Lewandowski123!
                 new Authentication.ApplicationUser
                 {
                     Id = "c89548b7-838f-4b90-94ac-763198501ce9",
                     UserName = "OwcaWK",
                     NormalizedUserName = "OWCAWK",
                     Email = "OwcaWK@gmail.com",
                     NormalizedEmail = "OWCAWK@GMAIL.COM",
                     EmailConfirmed = true,
                     PasswordHash = "AQAAAAEAACcQAAAAEAglmTAktrhxGf8FTo4ChX6re3EMp4Hi5jMl946pGhDMhZ0BFem75BKME7CrgYpJww==",
                     SecurityStamp = "LVC765MPWOBA3V2SZXSYWLPEVTTXDRJQ",
                     ConcurrencyStamp = "18b4ca59-cb79-459c-9578-8d65a5090d6c",
                     TwoFactorEnabled = false,
                     LockoutEnabled = true,
                     AccessFailedCount = 0
                 },//HASLO OwcaWK123!
                 new Authentication.ApplicationUser
                 {
                     Id = "9952718a-e4af-40b1-8dce-fe07967d4534",
                     UserName = "EndrjuDuda",
                     NormalizedUserName = "ENDRJUDUDA",
                     Email = "EndrjuDuda@gmail.com",
                     NormalizedEmail = "ENDRJUDUDA@GMAIL.com",
                     EmailConfirmed = true,
                     PasswordHash = "AQAAAAEAACcQAAAAEB8p9tWazRY8rhOEu/USJAstdhfMDpQf+82fi51KkrGYfUCeFU0qIqoPtv7E/AhjMg==",
                     SecurityStamp = "WTWJMTDKPF3HA6OUK472DQAKAJ54XTRS",
                     ConcurrencyStamp = "08680348-2b35-47f9-a90e-430ac9e91db7",
                     TwoFactorEnabled = false,
                     LockoutEnabled = true,
                     AccessFailedCount = 0
                 },//HASLO KochamPIS1!
                 new Authentication.ApplicationUser
                 {
                     Id = "c514dedb-db0a-49e9-a5e6-44e875c0d6fd",
                     UserName = "ZbigniewZiobro",
                     NormalizedUserName = "ZBIGNIEWZIOBRO",
                     Email = "Ziobro123@gmail.com",
                     NormalizedEmail = "ZIOBRO123@GMAIL.COM",
                     EmailConfirmed = true,
                     PasswordHash = "AQAAAAEAACcQAAAAEPQ0yzuj4mcljU0lmBZHFHZun6FuoN2oR6YF6dKaDPY/xWES3NSYBRMb1gozEQuFyQ==",
                     SecurityStamp = "XJX42PJ6RHFIPJXJI25FTEH4HBEYLGSX",
                     ConcurrencyStamp = "51b33cd0-0ab7-4d8e-893d-8da6feb7096d",
                     TwoFactorEnabled = false,
                     LockoutEnabled = true,
                     AccessFailedCount = 0
                 },//HASLO ZbyszekZiobro1!
                 new Authentication.ApplicationUser
                 {
                     Id = "711aa82e-b3af-482a-b2eb-8056e2b4e482",
                     UserName = "ZbyszekStonoga",
                     NormalizedUserName = "ZBYSZEKSTONOGA",
                     Email = "Stonoga@gmail.com",
                     NormalizedEmail = "STONOGA@GMAIL.COM",
                     EmailConfirmed = true,
                     PasswordHash = "AQAAAAEAACcQAAAAEPmAxB56NFlCeenVjKtgCyLEQ9T7hEBb9OyhtOdWT1H9Ma48df361TfTHqYLxSGfqQ==",
                     SecurityStamp = "K6C2VKRDVSTZGZAOZ2SGLFV2W73L57M2",
                     ConcurrencyStamp = "c76128d8-d3a9-4b45-929f-b4375b133ffc",
                     TwoFactorEnabled = false,
                     LockoutEnabled = true,
                     AccessFailedCount = 0
                 },//HASLO ZbychuStonoga1!
                 new Authentication.ApplicationUser
                 {
                     Id = "304f6dbe-c471-45ad-a540-f4992be6f746",
                     UserName = "JerzyJanowicz",
                     NormalizedUserName = "JERZYJANOWICZ",
                     Email = "Janowicz@gmail.com",
                     NormalizedEmail = "JANOWICZ@GMAIL.COM",
                     EmailConfirmed = true,
                     PasswordHash = "AQAAAAEAACcQAAAAEKvFcCpDXeifSMEOZvbCUujCmLcw237R1v0P67LGE1MgFhB/zMQ3cG2UeBdt+BmvXQ==",
                     SecurityStamp = "TMP3G6SC4PUNHPLDMKNIQ45NIDA6CY2G",
                     ConcurrencyStamp = "4373af8a-d161-4d96-851a-8d8506071b35",
                     TwoFactorEnabled = false,
                     LockoutEnabled = true,
                     AccessFailedCount = 0
                 },//HASLO Janowicz123!
                 new Authentication.ApplicationUser
                 {
                     Id = "4b9d5218-9049-487e-b5b7-74b7b6527cf1",
                     UserName = "TomaszHajto",
                     NormalizedUserName = "TOMASZHAJTO",
                     Email = "Hajto@wp.pl",
                     NormalizedEmail = "HAJTO@WP.PL",
                     EmailConfirmed = true,
                     PasswordHash = "AQAAAAEAACcQAAAAEMhlYs1Bv230/gikTAepq5ACdvZGExUFFsg7mCr5n4djDgCHgnfFlmwdCfyjGJOnng==",
                     SecurityStamp = "6R6COOBSQJ6BUB7MODICTNADCJ7V2D4Z",
                     ConcurrencyStamp = "6056ca99-1b1a-4da3-8296-e7bfd454fbce",
                     TwoFactorEnabled = false,
                     LockoutEnabled = true,
                     AccessFailedCount = 0
                 }//HASLO Hajto123!

                 );

            builder.Entity<Car>().HasData(
                 new Car { Id = 1, Class = "B", Brand = "Kia", Model = "Rio", Year = 2012, Color = "Czarny", EngineCapacity = "1.4", Seats = 5,
                     Gearbox = "M",  TrunkCapacity = "400L", RoofRack = false, BodyType = "Hatchback" },
                 new Car { Id = 2, Class = "B", Brand = "Toyota", Model = "Yaris", Year = 2015, Color = "Srebrny", EngineCapacity = "1.0", Seats = 5, 
                     Gearbox = "M", TrunkCapacity = "768L", RoofRack = false, BodyType = "Hatchback" },
                 new Car { Id = 3, Class = "B", Brand = "Opel", Model = "Corsa", Year = 2010, Color = "Niebieski", EngineCapacity = "1.6 T", Seats = 5,
                     Gearbox = "A", TrunkCapacity = "1100L", RoofRack = false, BodyType = "Hatchback"},
                 new Car { Id = 4, Class = "D", Brand = "Volkswagen", Model = "Passat", Year = 2016, Color = "Czarny", EngineCapacity = "2.0", Seats = 5,
                     Gearbox = "M", TrunkCapacity = "1150L", RoofRack = false, BodyType = "Sedan" },
                 new Car { Id = 5, Class = "D", Brand = "Opel", Model = "Insignia", Year = 2016, Color = "Czarny", EngineCapacity = "2.0", Seats = 5,
                     Gearbox = "M", TrunkCapacity = "1470L", RoofRack = false, BodyType = "Sedan" },
                 new Car { Id = 6, Class = "A", Brand = "Nissan", Model = "Micra", Year = 2015, Color = "Czerwony", EngineCapacity = "1.0", Seats = 5,
                     Gearbox = "M", TrunkCapacity = "800L", RoofRack = false, BodyType = "Hatchback" },
                 new Car { Id = 7, Class = "A", Brand = "Nissan", Model = "Micra", Year = 2015, Color = "Czerwony", EngineCapacity = "1.0", Seats = 5,
                     Gearbox = "M", TrunkCapacity = "800L", RoofRack = false, BodyType = "Hatchback" },
                 new Car { Id = 8, Class = "B", Brand = "Volkswagen", Model = "Golf", Year = 2017, Color = "Niebieski", EngineCapacity = "2.0 TSI", Seats = 5,
                     Gearbox = "AT", TrunkCapacity = "800L", RoofRack = false, BodyType = "Hatchback" },
                 new Car { Id = 9, Class = "D", Brand = "Volkswagen", Model = "Passat", Year = 2013, Color = "Czarny", EngineCapacity = "2.0 TSI", Seats = 5,
                     Gearbox = "M", TrunkCapacity = "1400L", RoofRack = true, BodyType = "Kombi" },
                 new Car { Id = 10, Class = "D", Brand = "Mazda", Model = "6", Year = 2015, Color = "Czerwony", EngineCapacity = "2.0 Skyaktiv", Seats = 5,
                     Gearbox = "AT", TrunkCapacity = "1400L", RoofRack = true, BodyType = "Kombi" },
                 new Car { Id = 11, Class = "D", Brand = "Ford", Model = "Mondeo", Year = 2016, Color = "Czarny", EngineCapacity = "2.0 TDCi", Seats = 5,
                     Gearbox = "M", TrunkCapacity = "1450L", RoofRack = false, BodyType = "Sedan" },
                 new Car { Id = 12, Class = "F", Brand = "Audi", Model = "A8", Year = 2016, Color = "Czarny", EngineCapacity = "4.2 TDI", Seats = 5,
                     Gearbox = "AT", TrunkCapacity = "1700L", RoofRack = false, BodyType = "Sedan" },
                 new Car { Id = 13, Class = "F", Brand = "Audi", Model = "A6", Year = 2014, Color = "Czarny", EngineCapacity = "3.0 TDI", Seats = 5,
                     Gearbox = "AT", TrunkCapacity = "1570L", RoofRack = true, BodyType = "Kombi" },
                 new Car { Id = 14, Class = "S", Brand = "Audi", Model = "RS6", Year = 2010, Color = "Czarny", EngineCapacity = "5.0 V10 TFSI", Seats = 5,
                     Gearbox = "AT", TrunkCapacity = "1500L", RoofRack = false, BodyType = "Sedan" },
                 new Car { Id = 15, Class = "A", Brand = "Fiat", Model = "Panda", Year = 2017, Color = "Biały", EngineCapacity = "1.0", Seats = 5, 
                     Gearbox = "M", TrunkCapacity = "1000L", RoofRack = false, BodyType = "Hatchback" },
                 new Car { Id = 16, Class = "C", Brand = "BMW", Model = "Seria 1", Year = 2013, Color = "Czarny", EngineCapacity = "2.0 D", Seats = 5,
                     Gearbox = "M", TrunkCapacity = "1280L", RoofRack = false, BodyType = "Hatchback" },
                 new Car { Id = 17, Class = "C", Brand = "Audi", Model = "A3", Year = 2014, Color = "Czarny", EngineCapacity = "2.0 TDI", Seats = 5,
                     Gearbox = "AT", TrunkCapacity = "1250L", RoofRack = false, BodyType = "Hatchback" },
                 new Car { Id = 18, Class = "S", Brand = "Lamborghini", Model = "Aventador", Year = 2016, Color = "Żółty", EngineCapacity = "6.5 V12", Seats = 5,
                     Gearbox = "AT", TrunkCapacity = "1450L", RoofRack = false, BodyType = "Coupe" },
                 new Car { Id = 19, Class = "S", Brand = "Audi", Model = "R8", Year = 2018, Color = "Niebieski", EngineCapacity = "5.2", Seats = 5,
                     Gearbox = "AT", TrunkCapacity = "---", RoofRack = false, BodyType = "Coupe" },
                 new Car { Id = 20, Class = "H", Brand = "Audi", Model = "TT", Year = 2015, Color = "Biały", EngineCapacity = "2.0 TFSI", Seats = 5,
                     Gearbox = "AT", TrunkCapacity = "600L", RoofRack = false, BodyType = "Cabriolet" },
                 new Car { Id = 21, Class = "H", Brand = "BMW", Model = "Z4", Year = 2016, Color = "Czarny", EngineCapacity = "2.5", Seats = 5,
                     Gearbox = "M", TrunkCapacity = "280L", RoofRack = false, BodyType = "Cabriolet" },
                 new Car { Id = 22, Class = "M", Brand = "Volkswagen", Model = "Sharan", Year = 2016, Color = "Czarny", EngineCapacity = "2.0 TDI", Seats = 7,
                     Gearbox = "AT", TrunkCapacity = "2000L", RoofRack = false, BodyType = "Van" },
                 new Car { Id = 23, Class = "M", Brand = "Seat", Model = "Alhambra", Year = 2018, Color = "Srebrny", EngineCapacity = "2.0 TDI", Seats = 5,
                     Gearbox = "M", TrunkCapacity = "2000L", RoofRack = false, BodyType = "Van" },
                 new Car { Id = 24, Class = "M", Brand = "Ford", Model = "Galaxy", Year = 2017, Color = "Czarny", EngineCapacity = "2.0 Ecoblue", Seats = 5,
                     Gearbox = "AT", TrunkCapacity = "2000L", RoofRack = false, BodyType = "Minivan" },
                 new Car { Id = 25, Class = "J", Brand = "Audi", Model = "Q7", Year = 2017, Color = "Czarny", EngineCapacity = "3.0 TDI", Seats = 5,
                     Gearbox = "M", TrunkCapacity = "1930L", RoofRack = true, BodyType = "SUV" }
                 );
            builder.Entity<BlackList>().HasData(
                new BlackList { Id = 1, BlacklistedUserId = "b889e9e9-0b5d-453f-9363-e93637b854aa", IsBlacklisted = true,
                    Reason = "Ukradł drzwi" },
                new BlackList { Id = 2, BlacklistedUserId = "10966c59-49f1-470a-a90c-94755d3870b3", IsBlacklisted = true,
                    Reason = "Skasował auto" },
                new BlackList { Id = 3, BlacklistedUserId = "711aa82e-b3af-482a-b2eb-8056e2b4e482", IsBlacklisted = true,
                    Reason = "Zostawił auto w krzakach" },
                new BlackList { Id = 4, BlacklistedUserId = "c514dedb-db0a-49e9-a5e6-44e875c0d6fd", IsBlacklisted = true,
                    Reason = "Pobił prezesa firmy" },
                new BlackList { Id = 5, BlacklistedUserId = "9952718a-e4af-40b1-8dce-fe07967d4534", IsBlacklisted = true,
                    Reason = "Piłował auto do odciny i zatarł silnik" },
                new BlackList { Id = 6, BlacklistedUserId = "304f6dbe-c471-45ad-a540-f4992be6f746", IsBlacklisted = true,
                    Reason = "Potrącił starą kobiete na pasach i nie poniósł żadnych konsekwencji prawnych" }



                );
            builder.Entity<CarCopy>().HasData(
                new CarCopy { Id = 1, RegistrationNumber = "ERA 2137P", CarId = 1, IsRented = true },
                new CarCopy { Id = 2, RegistrationNumber = "SC 12345", CarId = 2, IsRented = true },
                new CarCopy { Id = 3, RegistrationNumber = "SCZ 1523A", CarId = 3, IsRented = false },
                new CarCopy { Id = 4, RegistrationNumber = "SKL S8421", CarId = 4, IsRented = true },
                new CarCopy { Id = 5, RegistrationNumber = "SLU 67123", CarId = 5, IsRented = true },
                new CarCopy { Id = 6, RegistrationNumber = "EPJ AS128", CarId = 6, IsRented = false },
                new CarCopy { Id = 7, RegistrationNumber = "EL R2321A", CarId = 7, IsRented = false },
                new CarCopy { Id = 8, RegistrationNumber = "SK 9632A", CarId = 8, IsRented = true },
                new CarCopy { Id = 9, RegistrationNumber = "SB 123123", CarId = 9, IsRented = false },
                new CarCopy { Id = 10, RegistrationNumber = "WI 48235", CarId = 10, IsRented = false },
                new CarCopy { Id = 11, RegistrationNumber = "EWI 22135", CarId = 11, IsRented = true },
                new CarCopy { Id = 12, RegistrationNumber = "SC AP442", CarId = 12, IsRented = true },
                new CarCopy { Id = 13, RegistrationNumber = "SCZ 52123", CarId = 13, IsRented = true },
                new CarCopy { Id = 14, RegistrationNumber = "GDA 32145", CarId = 14, IsRented = true },
                new CarCopy { Id = 15, RegistrationNumber = "SW 12346", CarId = 15, IsRented = true },
                new CarCopy { Id = 16, RegistrationNumber = "SZ 325SA", CarId = 16, IsRented = false },
                new CarCopy { Id = 17, RegistrationNumber = "EPI 22598", CarId = 17, IsRented = false },
                new CarCopy { Id = 18, RegistrationNumber = "EP PP223", CarId = 18, IsRented = true },
                new CarCopy { Id = 19, RegistrationNumber = "SR 42345", CarId = 19, IsRented = false },
                new CarCopy { Id = 20, RegistrationNumber = "WU 23456", CarId = 20, IsRented = true },
                new CarCopy { Id = 21, RegistrationNumber = "WZ PQW21", CarId = 21, IsRented = true },
                new CarCopy { Id = 22, RegistrationNumber = "KR 42931", CarId = 22, IsRented = false },
                new CarCopy { Id = 23, RegistrationNumber = "KRA 29341", CarId = 23, IsRented = true },
                new CarCopy { Id = 24, RegistrationNumber = "DW 33257", CarId = 24, IsRented = false },
                new CarCopy { Id = 25, RegistrationNumber = "DWR 35812", CarId = 25, IsRented = true }

                );
              builder.Entity<Pricing>().HasData(
                new Pricing { Id = 1, CarCopyId = 1, Class = "A", Description = "Mały samochód", PricePerDay = 50 },
                new Pricing { Id = 2, CarCopyId = 2, Class = "B", Description = "Auto miejskie", PricePerDay = 100 },
                new Pricing { Id = 3, CarCopyId = 3, Class = "C", Description = "Auto typu Kompakt", PricePerDay = 150 },
                new Pricing { Id = 4, CarCopyId = 4, Class = "D", Description = "Auto klasy średniej", PricePerDay = 200 },
                new Pricing { Id = 5, CarCopyId = 5, Class = "E", Description = "Auto klasy wyższej", PricePerDay = 350 },
                new Pricing { Id = 6, CarCopyId = 6, Class = "F", Description = "Auto luksusowe", PricePerDay = 500 },
                new Pricing { Id = 7, CarCopyId = 7, Class = "S", Description = "Auto sportowe", PricePerDay = 500 },
                new Pricing { Id = 8, CarCopyId = 8, Class = "H", Description = "Auto typu Kabriolet", PricePerDay = 250 },
                new Pricing { Id = 9, CarCopyId = 9, Class = "J", Description = "Auto terenowe", PricePerDay = 400},
                new Pricing { Id = 10, CarCopyId = 10, Class = "M", Description = "Auto typu VAN", PricePerDay = 300 }
               );
            builder.Entity<Rent>().HasData(
               new Rent { Id = 1, UserID = "6bb1647e-c2f3-4def-a875-32644e0b2b9f", CarCopyId = 1, RentDate = data1, ReturnDate = data2 },
               new Rent { Id = 2, UserID = "10966c59-49f1-470a-a90c-94755d3870b3", CarCopyId = 2, RentDate = data1, ReturnDate = data2 },
               new Rent { Id = 3, UserID = "c89548b7-838f-4b90-94ac-763198501ce9", CarCopyId = 3, RentDate = data1, ReturnDate = data2 },
               new Rent { Id = 4, UserID = "b889e9e9-0b5d-453f-9363-e93637b854aa", CarCopyId = 4, RentDate = data1, ReturnDate = data2 },
               new Rent { Id = 5, UserID = "304f6dbe-c471-45ad-a540-f4992be6f746", CarCopyId = 5, RentDate = data1, ReturnDate = data2 }
               );
        }

    }
}
