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

        public async Task<Reservation> GetReservationById(int IdDestination)
        {
            return await _context.Reservations
                .Where(a => a.IdDestination.Equals(IdDestination))
                .FirstOrDefaultAsync();
        }

        public async Task<Reservation> GetReservationsById(int IdUser)
        {
            return await _context.Reservations
                .Where(a => a.IdUser.Equals(IdUser))
                .FirstOrDefaultAsync();
        }
    }

}
