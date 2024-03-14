namespace RO_BOOKING_Backend.Entities.CreateDTO
{
    public class CreateUserDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string HomeCity { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
