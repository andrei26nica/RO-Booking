using Microsoft.AspNetCore.Identity;

namespace RO_BOOKING_Backend.Entities
{
    public class UserRole : IdentityUserRole<int>
    {
        public string Role {  get; set; }
        public UserRole(string role) {  Role = role; }
    }
}
