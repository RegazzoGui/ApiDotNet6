

using Api.DotNet6.Domain.Repositories;
using ApiDotNet6.Application.DTOs;
using ApiDotNet6.Application.Interfaces;
using AutoMapper;

namespace ApiDotNet6.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        public PersonService(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public Task<ResultService<PersonDTO>> CreateAsync(PersonDTO personDTO)
        {
            throw new NotImplementedException();
        }
    }
}
