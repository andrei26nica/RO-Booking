using Microsoft.AspNetCore.Identity;

namespace RO_BOOKING_Backend.Entities
{
    public class UserRole : IdentityUserRole<int>
    {
        public Role Role {  get; set; }
        public User User {  get; set; }
    }
}
