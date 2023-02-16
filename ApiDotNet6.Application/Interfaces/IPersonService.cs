

using ApiDotNet6.Application.DTOs;
using ApiDotNet6.Application.Services;

namespace ApiDotNet6.Application.Interfaces
{
    public interface IPersonService
    {
        Task<ResultService<PersonDTO>> CreateAsync (PersonDTO personDTO);

    }
}
