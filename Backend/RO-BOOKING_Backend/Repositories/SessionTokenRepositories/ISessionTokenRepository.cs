using RO_BOOKING_Backend.Entities;
using RO_BOOKING_Backend.Repositories.GenericRepositories;

namespace RO_BOOKING_Backend.Repositories.SessionTokenRepositories
{
    public interface ISessionTokenRepository : IGenericRepository<SessionToken>
    {
        Task<SessionToken> GetByJTI(string jti);
    }
    
}
