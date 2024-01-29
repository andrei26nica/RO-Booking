namespace RO_BOOKING_Backend.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int IdUser { get; set; }
        public virtual User User { get; set; }
        public Destination Destination { get; set; }

    }
}
