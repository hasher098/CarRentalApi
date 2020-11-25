using CarRentalApi.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CarRentalApi.Authentication
{
    public class ApplicationUser : IdentityUser
    {

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Address { get; set; }

        [MaxLength(9, ErrorMessage = "Card ID must be 9 characters long"), MinLength(9)]
        public string IDcardNumber { get; set; }

        [MaxLength(11, ErrorMessage = "Pesel must be 11 characters long"), MinLength(11)]
        public string Pesel { get; set; }

        public bool IsActive { get; set; }
        [JsonIgnore]
        public virtual BlackList BlackList { get; set; }
        [JsonIgnore]
        public virtual IList<Rent> Rent { get; set; }


    }
}