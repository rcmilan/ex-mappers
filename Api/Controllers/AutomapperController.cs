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

        [HttpGet("existing_object")]
        public IActionResult ExistingObject()
        {
            var source = new Person
            {
                Address = new Address
                {
                    Id = Guid.NewGuid(),
                    Street = "Rua 123",
                    District = "Bairro 123",
                    Number = "123A"
                }
            };

            var result = new Person
            {
                Id = 1000,
                Name = "Pessoa ABC",
                Phone = "Phone-123",
            };

            _mapper.Map(source, result);

            return Ok(result);
        }

        [HttpGet("enumerable")]
        public IActionResult MapEnumerable()
        {
            List<Author> authors = new List<Author>
            {
                new Author("Autor A", new List<Book>()),
                new Author("Autor B", new List<Book> { new Book("Livro 123", 2000) }),
                new Author("Autor C", new List<Book> { new Book("Livro 123", 2000), new Book("Livro 456", 2001) }),
            };

            var result = _mapper.Map<List<AuthorDto>>(authors);

            return Ok(result);
        }

        [HttpGet("simple_map")]
        public IActionResult Simple()
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