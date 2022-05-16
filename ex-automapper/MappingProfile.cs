using AutoMapper;
using Domain.DTOs;
using Domain.Models;

namespace ex_automapper
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonDto>()
                .ForMember(dest => dest.Street, opt => opt.MapFrom(src => src.Address.Street))
                .ForMember(dest => dest.District, opt => opt.MapFrom(src => src.Address.District))
                .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.Address.Number))
                ;
        }
    }
}
