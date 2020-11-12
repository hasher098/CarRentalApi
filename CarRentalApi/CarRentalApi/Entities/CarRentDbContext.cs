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

                 }//HASLO Nowak123!
                 );


            builder.Entity<Car>().HasData(
                 new Car
                 {
                     Id = 1,
                     Class = "B",
                     Brand = "Kia",
                     Model = "Rio",
                     Year = 2012,
                     Color = "Czarny",
                     EngineCapacity = "1.4",
                     Seats = 5,
                     Gearbox = "M",
                     TrunkCapacity = "400L",
                     RoofRack = false,
                     BodyType = "Hatchback"
                 },
             new Car
             {
                 Id = 2,
                 Class = "B",
                 Brand = "Toyota",
                 Model = "Yaris",
                 Year = 2015,
                 Color = "Srebrny",
                 EngineCapacity = "1.0",
                 Seats = 5,
                 Gearbox = "M",
                 TrunkCapacity = "768L",
                 RoofRack = false,
                 BodyType = "Hatchback"
             },
              new Car
              {
                  Id = 3,
                  Class = "B",
                  Brand = "Opel",
                  Model = "Corsa",
                  Year = 2010,
                  Color = "Niebieski",
                  EngineCapacity = "1.6 T",
                  Seats = 5,
                  Gearbox = "A",
                  TrunkCapacity = "1100L",
                  RoofRack = false,
                  BodyType = "Hatchback"
              },
               new Car
               {
                   Id = 4,
                   Class = "D",
                   Brand = "Volkswagen",
                   Model = "Passat",
                   Year = 2016,
                   Color = "Czarny",
                   EngineCapacity = "2.0",
                   Seats = 5,
                   Gearbox = "M",
                   TrunkCapacity = "1150L",
                   RoofRack = false,
                   BodyType = "Sedan"
               },
               new Car
               {
                   Id = 5,
                   Class = "D",
                   Brand = "Opel",
                   Model = "Insignia",
                   Year = 2016,
                   Color = "Czarny",
                   EngineCapacity = "2.0",
                   Seats = 5,
                   Gearbox = "M",
                   TrunkCapacity = "1470L",
                   RoofRack = false,
                   BodyType = "Sedan"
               },
               new Car
               {
                   Id = 6,
                   Class = "A",
                   Brand = "Nissan",
                   Model = "Micra",
                   Year = 2015,
                   Color = "Czerwony",
                   EngineCapacity = "1.0",
                   Seats = 5,
                   Gearbox = "M",
                   TrunkCapacity = "800L",
                   RoofRack = false,
                   BodyType = "Hatchback"
               },
               new Car
               {
                   Id = 7,
                   Class = "A",
                   Brand = "Nissan",
                   Model = "Micra",
                   Year = 2015,
                   Color = "Czerwony",
                   EngineCapacity = "1.0",
                   Seats = 5,
                   Gearbox = "M",
                   TrunkCapacity = "800L",
                   RoofRack = false,
                   BodyType = "Hatchback"
               },
               new Car
               {
                   Id = 8,
                   Class = "B",
                   Brand = "Volkswagen",
                   Model = "Golf",
                   Year = 2017,
                   Color = "Niebieski",
                   EngineCapacity = "2.0 TSI",
                   Seats = 5,
                   Gearbox = "AT",
                   TrunkCapacity = "800L",
                   RoofRack = false,
                   BodyType = "Hatchback"
               },
               new Car
               {
                   Id = 9,
                   Class = "D",
                   Brand = "Volkswagen",
                   Model = "Passat",
                   Year = 2013,
                   Color = "Czarny",
                   EngineCapacity = "2.0 TSI",
                   Seats = 5,
                   Gearbox = "M",
                   TrunkCapacity = "1400L",
                   RoofRack = true,
                   BodyType = "Kombi"
               },
               new Car
               {
                   Id = 10,
                   Class = "D",
                   Brand = "Mazda",
                   Model = "6",
                   Year = 2015,
                   Color = "Czerwony",
                   EngineCapacity = "2.0 Skyaktiv",
                   Seats = 5,
                   Gearbox = "AT",
                   TrunkCapacity = "1400L",
                   RoofRack = true,
                   BodyType = "Kombi"
               },
               new Car
               {
                   Id = 11,
                   Class = "D",
                   Brand = "Ford",
                   Model = "Mondeo",
                   Year = 2016,
                   Color = "Czarny",
                   EngineCapacity = "2.0 TDCi",
                   Seats = 5,
                   Gearbox = "M",
                   TrunkCapacity = "1450L",
                   RoofRack = false,
                   BodyType = "Sedan"
               },
               new Car
               {
                   Id = 12,
                   Class = "F",
                   Brand = "Audi",
                   Model = "A8",
                   Year = 2016,
                   Color = "Czarny",
                   EngineCapacity = "4.2 TDI",
                   Seats = 5,
                   Gearbox = "AT",
                   TrunkCapacity = "1700L",
                   RoofRack = false,
                   BodyType = "Sedan"
               },
               new Car
               {
                   Id = 13,
                   Class = "F",
                   Brand = "Audi",
                   Model = "A6",
                   Year = 2014,
                   Color = "Czarny",
                   EngineCapacity = "3.0 TDI",
                   Seats = 5,
                   Gearbox = "AT",
                   TrunkCapacity = "1570L",
                   RoofRack = true,
                   BodyType = "Kombi"
               },
               new Car
               {
                   Id = 14,
                   Class = "S",
                   Brand = "Audi",
                   Model = "RS6",
                   Year = 2010,
                   Color = "Czarny",
                   EngineCapacity = "5.0 V10 TFSI",
                   Seats = 5,
                   Gearbox = "AT",
                   TrunkCapacity = "1500L",
                   RoofRack = false,
                   BodyType = "Sedan"
               },
               new Car
               {
                   Id = 15,
                   Class = "A",
                   Brand = "Fiat",
                   Model = "Panda",
                   Year = 2017,
                   Color = "Biały",
                   EngineCapacity = "1.0",
                   Seats = 5,
                   Gearbox = "M",
                   TrunkCapacity = "1000L",
                   RoofRack = false,
                   BodyType = "Hatchback"
               },
               new Car
               {
                   Id = 16,
                   Class = "C",
                   Brand = "BMW",
                   Model = "Seria 1",
                   Year = 2013,
                   Color = "Czarny",
                   EngineCapacity = "2.0 D",
                   Seats = 5,
                   Gearbox = "M",
                   TrunkCapacity = "1280L",
                   RoofRack = false,
                   BodyType = "Hatchback"
               },
               new Car
               {
                   Id = 17,
                   Class = "C",
                   Brand = "Audi",
                   Model = "A3",
                   Year = 2014,
                   Color = "Czarny",
                   EngineCapacity = "2.0 TDI",
                   Seats = 5,
                   Gearbox = "AT",
                   TrunkCapacity = "1250L",
                   RoofRack = false,
                   BodyType = "Hatchback"
               },
               new Car
               {
                   Id = 18,
                   Class = "S",
                   Brand = "Lamborghini",
                   Model = "Aventador",
                   Year = 2016,
                   Color = "Żółty",
                   EngineCapacity = "6.5 V12",
                   Seats = 5,
                   Gearbox = "AT",
                   TrunkCapacity = "1450L",
                   RoofRack = false,
                   BodyType = "Coupe"
               },
               new Car
               {
                   Id = 19,
                   Class = "S",
                   Brand = "Audi",
                   Model = "R8",
                   Year = 2018,
                   Color = "Niebieski",
                   EngineCapacity = "5.2",
                   Seats = 5,
                   Gearbox = "AT",
                   TrunkCapacity = "---",
                   RoofRack = false,
                   BodyType = "Coupe"
               },
               new Car
               {
                   Id = 20,
                   Class = "H",
                   Brand = "Audi",
                   Model = "TT",
                   Year = 2015,
                   Color = "Biały",
                   EngineCapacity = "2.0 TFSI",
                   Seats = 5,
                   Gearbox = "AT",
                   TrunkCapacity = "600L",
                   RoofRack = false,
                   BodyType = "Cabriolet"
               },
               new Car
               {
                   Id = 21,
                   Class = "H",
                   Brand = "BMW",
                   Model = "Z4",
                   Year = 2016,
                   Color = "Czarny",
                   EngineCapacity = "2.5",
                   Seats = 5,
                   Gearbox = "M",
                   TrunkCapacity = "280L",
                   RoofRack = false,
                   BodyType = "Cabriolet"
               },
               new Car
               {
                   Id = 22,
                   Class = "M",
                   Brand = "Volkswagen",
                   Model = "Sharan",
                   Year = 2016,
                   Color = "Czarny",
                   EngineCapacity = "2.0 TDI",
                   Seats = 7,
                   Gearbox = "AT",
                   TrunkCapacity = "2000L",
                   RoofRack = false,
                   BodyType = "Van"
               },
               new Car
               {
                   Id = 23,
                   Class = "M",
                   Brand = "Seat",
                   Model = "Alhambra",
                   Year = 2018,
                   Color = "Srebrny",
                   EngineCapacity = "2.0 TDI",
                   Seats = 5,
                   Gearbox = "M",
                   TrunkCapacity = "2000L",
                   RoofRack = false,
                   BodyType = "Van"
               },
               new Car
               {
                   Id = 24,
                   Class = "M",
                   Brand = "Ford",
                   Model = "Galaxy",
                   Year = 2017,
                   Color = "Czarny",
                   EngineCapacity = "2.0 Ecoblue",
                   Seats = 5,
                   Gearbox = "AT",
                   TrunkCapacity = "2000L",
                   RoofRack = false,
                   BodyType = "Minivan"
               },
               new Car
               {
                   Id = 25,
                   Class = "J",
                   Brand = "Audi",
                   Model = "Q7",
                   Year = 2017,
                   Color = "Czarny",
                   EngineCapacity = "3.0 TDI",
                   Seats = 5,
                   Gearbox = "M",
                   TrunkCapacity = "1930L",
                   RoofRack = true,
                   BodyType = "SUV"
               });
            builder.Entity<BlackList>().HasData(
                new BlackList
                {
                    Id = 1,
                    BlacklistedUserId = "b889e9e9-0b5d-453f-9363-e93637b854aa",
                    IsBlacklisted = true,
                    Reason = "Ukradł drzwi"
                }
                );
            builder.Entity<CarCopy>().HasData(
                new CarCopy
                {
                    Id = 1,
                    RegistrationNumber = "ERA 2137",
                    CarId = 1,
                    IsRented = true
                }
                );
            builder.Entity<Pricing>().HasData(
               new Pricing
               {
                   Id = 1,
                   CarCopyId = 1,
                   Class = "B",
                   Description = "Allalalalalalalalalalalala",
                   PricePerDay = 500
               }
               );
            builder.Entity<Rent>().HasData(
               new Rent
               {
                   Id = 1,
                   UserID = "6bb1647e-c2f3-4def-a875-32644e0b2b9f",
                   CarCopyId = 1,
                   RentDate = data1,
                   ReturnDate = data2
               }
               );
        }

    }
}
