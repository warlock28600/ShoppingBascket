using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> GetPersons();

        Task<Person> GetPersonWithId(int personId);

        void AddPerson(Person person);

       void DeletePerson(Person person);
    }
}
