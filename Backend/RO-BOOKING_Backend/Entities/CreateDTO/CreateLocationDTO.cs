namespace RO_BOOKING_Backend.Entities.CreateDTO
{
    public class CreateLocationDTO
    {
        public int id { get; set; }
        public string street { get; set; }
        public string City { get; set; }
        public string zipCode { get; set; }
        public int idDestination { get; set; }
    }
}
