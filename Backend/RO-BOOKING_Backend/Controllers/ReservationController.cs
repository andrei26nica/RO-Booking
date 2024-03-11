using Microsoft.AspNetCore.Mvc;
using RO_BOOKING_Backend.Entities.CreateDTO;
using RO_BOOKING_Backend.Entities;
using RO_BOOKING_Backend.Entities.DTO_s;
using RO_BOOKING_Backend.Repositories.ReservationRepositories;

namespace RO_BOOKING_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationRepository _repository;

        public ReservationController(IReservationRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllReservations()
        {
            var reservations = await _repository.GetAllReservations();

            var reservationToReturn = new List<ReservationDTO>();

            foreach (var reservation in reservations)
            {
                reservationToReturn.Add(new ReservationDTO(reservation));
            }

            return Ok(reservationToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetReservationById(int id)
        {
            var reservation = await _repository.GetByIdAsync(id);

            if (reservation == null)
            {
                return NotFound("Reservation not found!");
            }

            return Ok(new ReservationDTO(reservation));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservation(int id)
        {
            var reservation = await _repository.GetByIdAsync(id);

            if (reservation == null)
            {
                return NotFound("Reservation does not exist!");
            }

            _repository.Delete(reservation);

            await _repository.SaveAsync();
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> CreateReservation(CreateReservationDTO dto)
        {
            Reservation newReservation = new Reservation
            {
                IdDestination = dto.IdDestination,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                IdUser = dto.IdUser
            };

            _repository.Create(newReservation);

            await _repository.SaveAsync();

            return Ok(new ReservationDTO(newReservation));
        }

        [HttpPut("UpdateForForm")]
        public async Task<IActionResult> UpdateAsync([FromBody] Reservation reservation)
        {
            var array_reservation = await _repository.GetAllReservations();

            var reservationIndex = array_reservation.FindIndex((Reservation _reservation) => _reservation.IdUser.Equals(reservation.IdUser));

            array_reservation[reservationIndex] = reservation;

            return Ok(array_reservation);
        }
    }
}
