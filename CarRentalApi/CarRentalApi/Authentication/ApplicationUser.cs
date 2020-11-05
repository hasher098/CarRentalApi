using CarRentalApi.Entities;
using Microsoft.AspNetCore.Identity;

namespace CarRentalApi.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ClientDetails ClientDetails { get; set; }

    }
}