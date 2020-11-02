using CarRentalApi.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("BlackList")]
    public class BlackList
    {
        [Key]
        public int Id { get; set; }
        public bool IsBlacklisted { get; set; }
        [ForeignKey("ClientDetails")]
        public string ClientId { get; set; }
        public virtual ClientDetails Client { get; set; }
        public string Reason { get; set; }
    }