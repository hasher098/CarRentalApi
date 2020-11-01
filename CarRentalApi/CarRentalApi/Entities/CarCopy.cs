using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("CarCopy")]
    public class CarCopy
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(8),MinLength(7)]
        public string RegistrationNumber { get; set; }
        //numer rejestracyjny nie tylko zawiera liczby, dlatego int raczej si� tu nie przyda
        [ForeignKey("Car")]
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public bool IsRented { get; set; }
        public virtual Pricing Pricing { get; set; }
    }
