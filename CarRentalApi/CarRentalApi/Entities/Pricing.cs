using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Pricing")]
    public class Pricing
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Class { get; set; }
        public virtual CarCopy CarCopy { get; set; }
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
        [Required]
        public int PricePerDay { get; set; }

        [ForeignKey("CarCopy")]
        public int CarCopyId { get; set; }
}
