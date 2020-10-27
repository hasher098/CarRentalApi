using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApi.Entities
{
    [Table("ClientDetails")]
    public class ClientDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string IDcardNumber { get; set; }
        [Required]
        public string Pesel { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
