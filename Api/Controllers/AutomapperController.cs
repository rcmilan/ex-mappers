using AutoMapper;
using Domain.DTOs;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutomapperController : ControllerBase
    {
        private readonly IMapper _mapper;

        public AutomapperController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var person = new Person
            {
                Id = 1000,
                Name = "Pessoa ABC",
                Phone = "Phone-123",
                Address = new Address
                {
                    Id = Guid.NewGuid(),
                    Street = "Rua 123",
                    District = "Bairro 123",
                    Number = "123A"
                }
            };

            var result = _mapper.Map<PersonDto>(person);

            return Ok(result);
        }
    }
}