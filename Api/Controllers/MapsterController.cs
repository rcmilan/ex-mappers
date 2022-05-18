using Domain.DTOs;
using Domain.Models;
using ex_mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapsterController : ControllerBase
    {

        [HttpGet("simple_map")]
        public IActionResult Simple()
        {
            var adapter = new GenericAdapter<Author, AuthorDto>();

            var Author = new Author("Autor B", new List<Book> { new Book("Livro 123", 2000) });

            var result = adapter.Map(Author);

            return Ok(result);
        }
    }
}
