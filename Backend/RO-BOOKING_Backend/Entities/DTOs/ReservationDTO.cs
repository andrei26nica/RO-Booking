namespace RO_BOOKING_Backend.Entities.DTO_s
{
    public class ReservationDTO
    {
        public int IdDestination { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int IdUser { get; set; }

        public ReservationDTO(Reservation reservation)
        {
            this.IdDestination = reservation.IdDestination;
            this.StartDate = reservation.StartDate;
            this.EndDate = reservation.EndDate;
            this.IdUser = reservation.IdUser;
        }
    }
}
