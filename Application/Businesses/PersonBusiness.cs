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

        public async void CraetePerson(PersonModel person)
        {
             _PersonRepo.CreatePerson(person);
             _PersonRepo.SaveChangesAsync();
        }

        public async Task DeletePerson(int Id)
        {
            //var person=await _PersonRepo.GetPersonWithId(Id);
            //var personToDelete=
            // _PersonRepo.DeletePerson(person);

           
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
