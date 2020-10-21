using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("BlackList")]
    public class BlackList
    {
        [Key]
        public int Id { get; set; }
        public bool IsBlacklisted { get; set; }
        public int ClientId { get; set; }
        public string Reason { get; set; }
    }