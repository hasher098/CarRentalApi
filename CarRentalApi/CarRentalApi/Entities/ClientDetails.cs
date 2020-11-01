using CarRentalApi.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace CarRentalApi.Entities
{
    [Table("ClientDetails")]
    public class ClientDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(255)]
        public string Address { get; set; }
        [Required]
        [MaxLength(9, ErrorMessage ="Card ID must be 9 characters long"), MinLength(9)]
        public string IDcardNumber { get; set; }
        [Required]
        [MaxLength(11, ErrorMessage ="Pesel must be 11 characters long"),MinLength(11)]
        public string Pesel { get; set; }
        [Required]
        public bool IsActive { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        


    }
}
