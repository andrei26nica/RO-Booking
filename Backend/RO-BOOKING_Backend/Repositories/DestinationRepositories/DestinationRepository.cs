using Microsoft.EntityFrameworkCore;
using RO_BOOKING_Backend.Data;
using RO_BOOKING_Backend.Entities;
using RO_BOOKING_Backend.Repositories.GenericRepositories;

namespace RO_BOOKING_Backend.Repositories.DestinationRepositories
{
    public class DestinationRepository : GenericRepository<Destination>, IDestinationRepository
    {
        public DestinationRepository(AppDbContext context) : base(context) { } 

        public async Task<List<Destination>> GetAllDestinations()
        {
            return await _context.Destinations.ToListAsync();
        }

        public async Task<Destination> GetDestinationById(int destinationId)
        {
            return await _context.Destinations
                .Where(d => d.Id == destinationId)
                .FirstOrDefaultAsync();
        }
    }
}
