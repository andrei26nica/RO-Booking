namespace RO_BOOKING_Backend.Entities.DTO_s
{
    public class LocationDTO
    {
        public int Id { get; set; }
        public string street { get; set; }
        public string City { get; set; }
        public string zipCode { get; set; }

        public LocationDTO(Location location)
        {
            this.Id = location.Id;
            this.street = location.street;
            this.City = location.City;
            this.zipCode = location.zipCode;
        }
    }
}
