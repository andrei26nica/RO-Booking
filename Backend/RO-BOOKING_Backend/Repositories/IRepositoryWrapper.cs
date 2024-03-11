using RO_BOOKING_Backend.Repositories.DestinationRepositories;
using RO_BOOKING_Backend.Repositories.DestinationTypeRepositories;
using RO_BOOKING_Backend.Repositories.LocationRepositories;
using RO_BOOKING_Backend.Repositories.ReservationRepositories;
using RO_BOOKING_Backend.Repositories.SessionTokenRepositories;
using RO_BOOKING_Backend.Repositories.UserRepositories;

namespace RO_BOOKING_Backend.Repositories
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        ILocationRepository Location { get; }
        IDestinationRepository Destination { get; }
        IDestinationTypeRepository DestinationType { get; }
        IReservationRepository Reservation { get; }
        ISessionTokenRepository SessionToken { get; }

        Task SaveAsync();
    }
}
