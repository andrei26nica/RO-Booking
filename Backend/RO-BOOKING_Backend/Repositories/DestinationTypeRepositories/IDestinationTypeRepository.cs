using RO_BOOKING_Backend.Entities;
using RO_BOOKING_Backend.Repositories.GenericRepositories;

namespace RO_BOOKING_Backend.Repositories.DestinationTypeRepositories
{
    public interface IDestinationTypeRepository : IGenericRepository<DestinationType>
    {
        Task<List<DestinationType>> GetAllDestinationTypes();
        Task<DestinationType> GetDestinationTypeById(int destinationTypeId);
    }
}
