using AutoMapper;
using Domain.DTOs;
using Domain.Models;

namespace ex_automapper
{
    internal class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDto>();

            CreateMap<Book, BookDto>();
        }
    }
}
