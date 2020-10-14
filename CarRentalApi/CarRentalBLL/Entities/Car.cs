namespace CarRentalBLL.Entities
{  
    public class Car
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string EngineCapacity { get; set; }
        public int Seats { get; set; }
        public string Gearbox { get; set; }
        public string TrunkCapacity { get; set; }
        public bool RoofRack { get; set; }
        public string BodyType { get; set; }
    }
}
