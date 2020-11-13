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
                
                context.SaveChanges();
            }
        }
    }
}
