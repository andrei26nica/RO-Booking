using RO_BOOKING_Backend.Entities;
using RO_BOOKING_Backend.Repositories.GenericRepositories;

namespace RO_BOOKING_Backend.Repositories.DestinationRepositories
{
    public interface IDestinationRepository : IGenericRepository<Destination>
    {
        Task<List<Destination>> GetAllDestinations();
        Task<Destination> GetDestinationById(int destinationId);
    }
}
