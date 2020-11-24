using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApi.Authentication
{
    public class UserDetails
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Address { get; set; }

        public string IDcardNumber { get; set; }

        public string Pesel { get; set; }
    }
}