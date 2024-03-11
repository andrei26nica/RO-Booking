namespace RO_BOOKING_Backend.Entities.DTO_s
{
    public class DestinationTypeDTO
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public DestinationTypeDTO(DestinationType destinationType)
        {
            this.Id = destinationType.Id;
            this.TypeName = destinationType.TypeName;
        }
    }
}
