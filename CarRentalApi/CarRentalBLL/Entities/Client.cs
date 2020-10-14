using Microsoft.AspNetCore.Identity;

namespace CarRentalBLL.Entities
{
    public class Client :IdentityUser<int>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string Pesel { get; set; }
        //pesel w incie siê nie zmieœci
        public bool IsActive { get; set; }
    }
}