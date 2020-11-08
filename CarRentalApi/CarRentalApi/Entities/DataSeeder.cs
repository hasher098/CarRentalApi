using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApi.Entities
{
    public class DataSeeder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            
            using (var context = new CarRentDbContext(serviceProvider.GetRequiredService<DbContextOptions<CarRentDbContext>>()))
            {
                context.Cars.AddRange(
                     new Car
                     {
                         
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
                context.Users.AddRange(
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
                /*context.ClientDetails.AddRange(
                    new ClientDetails
                    {
                        Id = "b889e9e9-0b5d-453f-9363-e93637b854aa",
                        LastName = "Nowak",
                        FirstName = "Jan",
                        Address = "Warszawa ul.Długa 12",
                        Email = "Nowak@car.pl",
                        IDcardNumber = "ABC2121",
                        Pesel = "54632697601",
                        IsActive = true

                    },
                    new ClientDetails
                    {
                        Id = "6bb1647e-c2f3-4def-a875-32644e0b2b9f",
                        LastName = "Kowalski",
                        FirstName = "Adam",
                        Address = "Warszawa ul.Szkolna 17",
                        Email = "Kowalski@car.pl",
                        IDcardNumber = "GHV3420",
                        Pesel = "73819281215",
                        IsActive = true

                    }
                    );
                context.BlackList.AddRange(
                    new BlackList
                    {
                        IsBlacklisted = true,
                        ClientId = "6bb1647e-c2f3-4def-a875-32644e0b2b9f",
                        Reason ="Nie oddanie auta"
                    });
                /*
                context.CarCopies.AddRange(
                    new CarCopy
                    {
                        RegistrationNumber = "ABC 2121",
                        CarId = 1,
                        IsRented = true
                    },
                    new CarCopy
                    {
                        RegistrationNumber = "EBG 0E31",
                        CarId = 2,
                        IsRented = false
                    },
                    new CarCopy
                    {
                        RegistrationNumber = "EWI SA12",
                        CarId = 3,
                        IsRented = false
                    },
                    new CarCopy
                    {
                        RegistrationNumber = "ETM DC30",
                        CarId = 4,
                        IsRented = false
                    },
                    new CarCopy
                    {
                        RegistrationNumber = "OOL 1231",
                        CarId = 5,
                        IsRented = false
                    });*/
                /*context.Pricings.AddRange(
                    new Pricing
                    {
                        Class = "A",
                        Description = "Małe auto miejskie",
                        PricePerDay = 80
                    });
                context.Rents.AddRange(
                    new Rent
                    {
                        ClientId = "b889e9e9-0b5d-453f-9363-e93637b854aa",
                        CarCopyId = 1,
                        RentDate = new DateTime(2,11,2020),
                        ReturnDate = new DateTime(12, 11, 2020)

                    });
                
                */
                context.SaveChanges();
            }

               



            
        }
    }
}
