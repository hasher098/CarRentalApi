using CarRentalApi.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApi.Authentication
{
    public class ApplicationUser: IdentityUser
    {
        public virtual ClientDetails ClientDetails { get; set; }
    }
}
