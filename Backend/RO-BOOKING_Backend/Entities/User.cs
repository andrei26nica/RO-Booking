namespace RO_BOOKING_Backend.Entities
{
    public class User
    {
        public int IdUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeCity { get; set; }
        public string Phone { get; set; }
        public string Email {  get; set; }
        public string Password { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<Reservation> Reservations { get; set; }

    }
}
