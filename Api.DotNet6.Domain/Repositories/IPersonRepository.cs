using Api.DotNet6.Domain.Entities;


namespace Api.DotNet6.Domain.Repositories
{
    public interface IPersonRepository
    {
        Task<Person> GetByIdAsync(int id);
        Task<ICollection<Person>> GetPeopleAsync();
        Task<Person> CreateAsync(Person person);
        Task DeleteAsync(Person person);

        Task EditAsync(Person person);
    }
}
