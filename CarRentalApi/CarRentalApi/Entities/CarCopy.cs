using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

[Table("CarCopy")]
    public class CarCopy
    {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
        
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string RegistrationNumber { get; set; }
        //numer rejestracyjny nie tylko zawiera liczby, dlatego int raczej siê tu nie przyda
        [ForeignKey("Car")]
        public int CarId { get; set; }
    [JsonIgnore]
        public virtual Car Car { get; set; }
        public bool IsRented { get; set; }
    [JsonIgnore]
    public virtual Pricing Pricing { get; set; }
    }
