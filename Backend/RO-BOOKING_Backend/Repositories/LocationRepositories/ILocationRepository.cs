using RO_BOOKING_Backend.Entities;
using RO_BOOKING_Backend.Repositories.GenericRepositories;

namespace RO_BOOKING_Backend.Repositories.LocationRepositories
{
    public interface ILocationRepository : IGenericRepository<Location>
    {
        Task<List<Location>> GetAllLocations();
        Task<Location> GetLocationById(int Id);
        Task<Location> GetLocationByStreetAsync(string street);
        Task<Location> GetLocationByZipCodeAsync(string zipCode);
    }
   
}
