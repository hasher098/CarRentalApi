using Microsoft.Net.Http.Headers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

    [Table("Cars")]
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Class { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        [Required]
        public string EngineCapacity { get; set; }
        [Required]
        public int Seats { get; set; }
        [Required]
        public string Gearbox { get; set; }
        [Required]
        public string TrunkCapacity { get; set; }
        [Required]
        public bool RoofRack { get; set; }
        [Required]
        public string BodyType { get; set; }
        public virtual CarCopy CarCopy { get; set; }
    }
