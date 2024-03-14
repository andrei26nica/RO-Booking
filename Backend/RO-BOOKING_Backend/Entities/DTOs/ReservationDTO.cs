namespace RO_BOOKING_Backend.Entities.DTO_s
{
    public class ReservationDTO
    {
        public int DestinationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UserId { get; set; }

        public ReservationDTO(Reservation reservation)
        {
            this.DestinationId = reservation.DestinationId;
            this.StartDate = reservation.StartDate;
            this.EndDate = reservation.EndDate;
            this.UserId = reservation.UserId;
        }
    }
}
