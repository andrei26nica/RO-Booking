namespace RO_BOOKING_Backend.Entities
{
    public class DestinationType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public ICollection<Destination> Destinations { get; set; }
    }
}

