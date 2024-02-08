using Microsoft.EntityFrameworkCore;
using RO_BOOKING_Backend.Data;
using RO_BOOKING_Backend.Entities;
using RO_BOOKING_Backend.Repositories.GenericRepositories;

namespace RO_BOOKING_Backend.Repositories.DestinationTypeRepositories
{
    public class DestinationTypeRepository : GenericRepository<DestinationType>, IDestinationTypeRepository
    {
        public DestinationTypeRepository(AppDbContext context) : base(context) { }

        public async Task<List<DestinationType>> GetAllDestinationTypes()
        {
            return await _context.DestinationTypes.ToListAsync();
        }

        public async Task<DestinationType> GetDestinationTypeById(int destinationTypeId)
        {
            return await _context.DestinationTypes
                .Where(dt => dt.Id == destinationTypeId)
                .FirstOrDefaultAsync();
        }
    
    }
}
