using Microsoft.EntityFrameworkCore;
using RO_BOOKING_Backend.Data;
using RO_BOOKING_Backend.Entities;
using RO_BOOKING_Backend.Repositories.GenericRepositories;

namespace RO_BOOKING_Backend.Repositories.LocationRepositories
{
    public class LocationRepository : GenericRepository<Location>, ILocationRepository
    {
        public LocationRepository(AppDbContext context) : base(context) { }

        public async Task<List<Location>> GetAllLocations()
        {
            return await _context.Locations.ToListAsync();
        }
        public async Task<Location> GetLocationById(int Id)
        {
            return await _context.Locations.Where(a => a.Id.Equals(Id)).FirstOrDefaultAsync();
        }

        public async Task<Location> GetLocationsByCity(string City)
        {
            return await _context.Locations.Where(a => a.City.Equals(City)).FirstOrDefaultAsync();
        }

    }
}