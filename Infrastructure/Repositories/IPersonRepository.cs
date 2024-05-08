using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> getAllPerson();


        Task<Person> GetPersonWithId(int id);

        Task<bool> PersonExists(int personId);

        Task CreatePerson(Person person);

        void DeletePerson(Person person);

        Task<bool> SaveChangesAsync();
    }
}
