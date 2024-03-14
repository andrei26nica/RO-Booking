using Microsoft.AspNetCore.Identity;

namespace RO_BOOKING_Backend.Entities
{
    public class User : IdentityUser<int>
    {
        public User() : base() { }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string HomeCity { get; set; }
        public string Phone { get; set; }
        public string Email {  get; set; }
        public string Password { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<Reservation> Reservations { get; set; }

    }
}
