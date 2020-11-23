using Microsoft.Net.Http.Headers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

[Table("Cars")]
    public class Car
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]   
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Class { get; set; }
        [Required]
        [MaxLength(255)]
        public string Brand { get; set; }
        [Required]
        [MaxLength(255)]
        public string Model { get; set; }
        [MaxLength(4)]
        public int Year { get; set; }
        [MaxLength(255)]
        public string Color { get; set; }
        [Required]
        public string EngineCapacity { get; set; }
        [Required]
        [MaxLength(1)]
        public int Seats { get; set; }
        [Required]
        [MaxLength(2)]
        public string Gearbox { get; set; }
        [Required]
        [MaxLength(10)]
        public string TrunkCapacity { get; set; }
        [Required]
        public bool RoofRack { get; set; }
        [Required]
        [MaxLength(20)]
        public string BodyType { get; set; }

    [JsonIgnore]
    public virtual CarCopy CarCopy { get; set; }
    }
