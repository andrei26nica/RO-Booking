using Microsoft.AspNetCore.Mvc;
using RO_BOOKING_Backend.Entities.CreateDTO;
using RO_BOOKING_Backend.Entities.DTO_s;
using RO_BOOKING_Backend.Entities;
using RO_BOOKING_Backend.Repositories.DestinationRepositories;

namespace RO_BOOKING_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationController : ControllerBase
    {
        private readonly IDestinationRepository _repository;

        public DestinationController(IDestinationRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDestinations()
        {
            var destinations = await _repository.GetAllDestinations();

            var destinationToReturn = new List<DestinationDTO>();

            foreach (var destination in destinations)
            {
                destinationToReturn.Add(new DestinationDTO(destination));
            }

            return Ok(destinationToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDestinationById(int id)
        {
            var destination = await _repository.GetDestinationById(id);

            if (destination == null)
            {
                return NotFound("Destination not found!");
            }

            var destinationToReturn = new DestinationDTO(destination);

            return Ok(destinationToReturn);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDestination(int id)
        {
            var destination = await _repository.GetByIdAsync(id);

            if (destination == null)
            {
                return NotFound("Destination does not exist!");
            }

            _repository.Delete(destination);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDestination(CreateDestinationDTO dto)
        {
            Destination newDestination = new Destination();

            newDestination.Budget = dto.Budget;
            newDestination.LocationId = dto.LocationId;
            newDestination.DestinationTypeId = dto.DestinationTypeId;

            // Set other properties if needed

            _repository.Create(newDestination);

            await _repository.SaveAsync();

            return Ok(new DestinationDTO(newDestination));
        }

        [HttpPut("UpdateForForm")]
        public async Task<IActionResult> UpdateAsync([FromBody] Destination destination)
        {
            var arrayDestinations = await _repository.GetAllDestinations();

            var destinationIndex = arrayDestinations.FindIndex((Destination dest) => dest.Id.Equals(destination.Id));

            arrayDestinations[destinationIndex] = destination;

            return Ok(arrayDestinations);
        }
    }
}
