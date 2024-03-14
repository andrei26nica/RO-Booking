namespace RO_BOOKING_Backend.Entities.CreateDTO
{
    public class CreateReservationDTO
    {
        public int DestinationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UserId { get; set; }
    }
}
