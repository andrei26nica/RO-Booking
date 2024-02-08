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

        public async Task<Location> GetLocationById(int locationId)
        {
            return await _context.Locations
                .Where(l => l.id == locationId)
                .FirstOrDefaultAsync();
        }

        public async Task<Location> GetLocationByStreetAsync(string street)
        {
            return await _context.Locations
                .FirstOrDefaultAsync(location => location.street == street);
        }

        public async Task<Location> GetLocationByZipCodeAsync(string zipCode)
        {
            return await _context.Locations
                .FirstOrDefaultAsync(location => location.zipCode == zipCode);
        }
    }
}