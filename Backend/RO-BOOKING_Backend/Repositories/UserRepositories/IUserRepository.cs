using RO_BOOKING_Backend.Entities;
using RO_BOOKING_Backend.Repositories.GenericRepositories;

namespace RO_BOOKING_Backend.Repositories.UserRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserByEmail(string Email);
        Task<User> GetByIdWithRoles(int Id);

        Task<User> GetUserById(int Id);
    }
    
}
