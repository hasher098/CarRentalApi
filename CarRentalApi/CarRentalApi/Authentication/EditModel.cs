using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApi.Authentication
{
    public class EditModel
    {
        
        
        public string id { get; set; }

        
        public string lastName { get; set; }

        public string firstName { get; set; }
        public string pesel { get; set; }
        public string Adress { get; set; }
        public string IdcardNumber { get; set; }


    }
}
