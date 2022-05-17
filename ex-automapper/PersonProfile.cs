using AutoMapper;
using Domain.DTOs;
using Domain.Models;

namespace ex_automapper
{
    internal class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonDto>()
                .ForMember(dest => dest.Street, opt => opt.MapFrom(src => src.Address.Street))
                .ForMember(dest => dest.District, opt => opt.MapFrom(src => src.Address.District))
                .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.Address.Number))
                ;

            CreateMap<Person, Person>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}