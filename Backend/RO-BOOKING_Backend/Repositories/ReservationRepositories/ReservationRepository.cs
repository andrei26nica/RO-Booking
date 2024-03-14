using Microsoft.EntityFrameworkCore;
using RO_BOOKING_Backend.Data;
using RO_BOOKING_Backend.Entities;
using RO_BOOKING_Backend.Repositories.GenericRepositories;
using System.Diagnostics.Contracts;

namespace RO_BOOKING_Backend.Repositories.ReservationRepositories
{
    public class ReservationRepository : GenericRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(AppDbContext context) : base(context) { }

        public async Task<List<Reservation>> GetAllReservations()
        {
            return await _context.Reservations.ToListAsync();
        }

        public async Task<Reservation> GetReservationById(int DestinationId)
        {
            return await _context.Reservations
                .Where(a => a.DestinationId.Equals(DestinationId))
                .FirstOrDefaultAsync();
        }

        public async Task<Reservation> GetReservationsById(int UserId)
        {
            return await _context.Reservations
                .Where(a => a.UserId.Equals(UserId))
                .FirstOrDefaultAsync();
        }
    }

}
