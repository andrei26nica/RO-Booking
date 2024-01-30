namespace RO_BOOKING_Backend.Entities.DTO_s
{
    public class DestinationDTO
    {
        public int Id { get; set; }
        public int Budget { get; set; }
        public string Location { get; set; }
        public int DestinationTypeId { get; set; }
        public int LocationId { get; set; }

        public DestinationDTO(Destination destination)
        {
            this.Id=destination.Id;
            this.Budget = destination.Budget;
            this.Location = destination.Location;
            this.DestinationTypeId = destination.DestinationTypeId;
            this.LocationId = destination.LocationId;

        }
    }
}
