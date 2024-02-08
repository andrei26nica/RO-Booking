namespace RO_BOOKING_Backend.Entities
{
    public class Reservation
    {
        public int IdUser { get; set; }
        public int IdDestination { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual User User { get; set; }
        public Destination Destination { get; set; }


    }
}
