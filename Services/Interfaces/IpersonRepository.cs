using Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IpersonRepository
    {
        Task<IEnumerable<Person>> getAllPerson();


        Task<Person> GetPersonWithId(int id);

        Task<bool> PersonExists(int personId);

        Task CreatePerson(Person person);

        void DeletePerson(Person person);

        Task<bool> SaveChangesAsync();
    }
}
