using CarRentalApi.Authentication;
using CarRentalApi.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

[Table("BlackList")]
    public class BlackList
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key] 
        public int Id { get; set; }
        [ForeignKey("ApplicationUser")]
        public string BlacklistedUserId { get; set; }
        [JsonIgnore]
        public virtual ApplicationUser ApplicationUser { get; set; }
        [Required]
        public bool IsBlacklisted { get; set; }
        [Required]
        [MaxLength(255)]
        public string Reason { get; set; }
    }