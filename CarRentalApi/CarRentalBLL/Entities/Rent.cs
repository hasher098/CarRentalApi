using System;
namespace CarRentalBLL.Entities
{
    public class Rent
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}