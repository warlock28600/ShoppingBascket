using Domain.Entity;
using Domain.Models;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Businesses
{
    public class PersonBusiness : IPersonBusiness
    {
        private readonly IPersonRepository _PersonRepo;

        public PersonBusiness(IPersonRepository personRepo)
        {
            _PersonRepo = personRepo;
        }

        public async void CraetePerson(PersonToCreateModel person)
        {
             _PersonRepo.CreatePerson(person);
            
        }

        public async Task DeletePerson(int Id)
        {
          _PersonRepo.DeletePersonAsync(Id);
        }

        public async Task<IEnumerable<PersonModel>> GetPersons()
        {
            return await _PersonRepo.getAllPerson();
        }

        public async Task<PersonModel> GetPersonWithId(int id)
        {
            var person = await _PersonRepo.GetPersonWithId(id);
            return person;
        }

        public Task UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
