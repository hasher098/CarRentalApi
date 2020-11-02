using CarRentalApi.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Rent")]
    public class Rent
    {
    [   Key]
        public int Id { get; set; }
        [ForeignKey("ClientDetails")]
        public string ClientId { get; set; }
        public virtual ClientDetails Client { get; set; }
        [ForeignKey("CarCopy")]
        public int CarCopyId { get; set; }
        public CarCopy CarCopy { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
