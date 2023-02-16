
using Api.DotNet6.Domain.Entities;
using ApiDotNet6.Application.DTOs;
using AutoMapper;

namespace ApiDotNet6.Application.Mappings
{
    public class DomainToDtoMapping : Profile
    {
        public DomainToDtoMapping()
        {
            CreateMap<Person, PersonDTO>();
        }
    }
}
