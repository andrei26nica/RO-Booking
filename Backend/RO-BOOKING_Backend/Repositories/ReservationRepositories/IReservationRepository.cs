using RO_BOOKING_Backend.Entities;
using RO_BOOKING_Backend.Repositories.GenericRepositories;

namespace RO_BOOKING_Backend.Repositories.ReservationRepositories
{
    public interface IReservationRepository : IGenericRepository<Reservation>
    {
        Task<List<Reservation>> GetAllReservations();
        Task<Reservation> GetReservationsById(int IdUser);
        Task<Reservation> GetReservationById(int IdDestination);
    }
}
