namespace RO_BOOKING_Backend.Entities.CreateDTO
{
    public class CreateDestinationDTO
    {
        public int Id { get; set; }
        public int Budget { get; set; }
        public string Location { get; set; }
        public int DestinationTypeId { get; set; }
        public int IdLocation { get; set; }
    }
}
