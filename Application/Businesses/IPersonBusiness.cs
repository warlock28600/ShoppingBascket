using Domain.Entity;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Businesses
{
    public interface IPersonBusiness
    {
        Task<IEnumerable<PersonModel>> GetPersons();

        Task<PersonModel> GetPersonWithId(int Id);

        void  CraetePerson(PersonToCreateModel person);

        Task DeletePerson(int Id);

        Task UpdatePerson(Person person);
    }
}
