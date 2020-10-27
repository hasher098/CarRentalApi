using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Pricing")]
    public class Pricing
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CarCopy")]
        public int CarCopyId { get; set; }
        public virtual CarCopy CarCopy { get; set; }
        public string Description { get; set; }
        public int PricePerDay { get; set; }
}
