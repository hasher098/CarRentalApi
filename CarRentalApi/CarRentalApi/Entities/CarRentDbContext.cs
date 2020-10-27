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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
