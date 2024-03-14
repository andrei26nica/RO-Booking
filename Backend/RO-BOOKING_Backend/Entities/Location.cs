namespace RO_BOOKING_Backend.Entities
{
    public class Location
    {
        public int Id {  get; set; }
        public string street { get; set; }
        public string City { get; set; }
        public string zipCode { get; set; }
        public ICollection<Destination> Destinations { get; set; }
    }
}
