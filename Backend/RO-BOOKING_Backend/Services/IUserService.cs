using RO_BOOKING_Backend.Entities.DTO_s;
using System.Threading.Tasks;

namespace RO_BOOKING_Backend.Services
{
    public interface IUserService
    {
        Task<bool> RegisterUserAsync(RegisterUserDTO dto);
        Task<string> LoginUser(LoginUserDTO dto);
    }
}
