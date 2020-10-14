namespace CarRentalBLL.Entities
{
    public class BlackList
    {
        public bool IsBlacklisted { get; set; }
        public int ClientId { get; set; }
        public string Reason { get; set; }
    }
}