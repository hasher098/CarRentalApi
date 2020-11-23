using CarRentalApi.Authentication;
using CarRentalApi.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

[Table("Rent")]
    public class Rent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [ForeignKey("ApplicationUser")]
        public string UserID { get; set; }
        [JsonIgnore]
        public virtual ApplicationUser ApplicationUser { get; set; }
        
        [ForeignKey("CarCopy")]
        public int CarCopyId { get; set; }
        [JsonIgnore]
        public CarCopy CarCopy { get; set; }
        [Required]
        public DateTime RentDate { get; set; }
        [Required]
        public DateTime ReturnDate { get; set; }
    }
