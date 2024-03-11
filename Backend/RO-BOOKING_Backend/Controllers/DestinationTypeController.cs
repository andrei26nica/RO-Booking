using Microsoft.AspNetCore.Mvc;
using RO_BOOKING_Backend.Entities.CreateDTO;
using RO_BOOKING_Backend.Entities.DTO_s;
using RO_BOOKING_Backend.Entities;
using RO_BOOKING_Backend.Repositories.DestinationTypeRepositories;

namespace RO_BOOKING_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationTypeController : ControllerBase
    {
        private readonly IDestinationTypeRepository _repository;

        public DestinationTypeController(IDestinationTypeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDestinationTypes()
        {
            var destinationTypes = await _repository.GetAllDestinationTypes();

            var destinationTypesToReturn = new List<DestinationTypeDTO>();

            foreach (var destinationType in destinationTypes)
            {
                destinationTypesToReturn.Add(new DestinationTypeDTO(destinationType));
            }

            return Ok(destinationTypesToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDestinationTypeById(int id)
        {
            var destinationType = await _repository.GetDestinationTypeById(id);

            if (destinationType == null)
            {
                return NotFound("DestinationType does not exist!");
            }

            var destinationTypeToReturn = new DestinationTypeDTO(destinationType);

            return Ok(destinationTypeToReturn);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDestinationType(CreateDestinationTypeDTO dto)
        {
            DestinationType newDestinationType = new DestinationType();

            newDestinationType.TypeName = dto.TypeName;

            _repository.Create(newDestinationType);

            await _repository.SaveAsync();

            return Ok(new DestinationTypeDTO(newDestinationType));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDestinationType(int id)
        {
            var destinationType = await _repository.GetDestinationTypeById(id);

            if (destinationType == null)
            {
                return NotFound("DestinationType does not exist!");
            }

            _repository.Delete(destinationType);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("UpdateForForm")]
        public async Task<IActionResult> UpdateAsync([FromBody] DestinationType destinationType)
        {
            var destinationTypes = await _repository.GetAllDestinationTypes();

            var destinationTypeIndex = destinationTypes.FindIndex(
                (DestinationType _destinationType) => _destinationType.Id.Equals(destinationType.Id));

            destinationTypes[destinationTypeIndex] = destinationType;

            return Ok(destinationTypes);
        }
    }
}
