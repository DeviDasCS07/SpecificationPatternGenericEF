using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace SpecificationPatterGenericEFRepo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DevelopersController : ControllerBase
    {
        public readonly IGenericRepository<Developer> _repository;

        public DevelopersController(IGenericRepository<Developer> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var developers = await _repository.GetAllAsync();
            return Ok(developers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var developer = await _repository.GetByIdAsync(id);
            return Ok(developer);
        }

        [HttpGet("specify")]
        public async Task<IActionResult> Specify()
        {
            var specification = new DeveloperWithAddressSpecification(10);
            // var specification = new DeveloperByIncomeSpecification();
            var developers = _repository.FindWithSpecificationPattern(specification);
            return Ok(developers);
        }
    }
}