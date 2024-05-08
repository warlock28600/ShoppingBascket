using Services.Entities;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class PersonService
    {
        private readonly IpersonRepository _personRepo;

        public PersonService(IpersonRepository personRepo)
        {
            _personRepo = personRepo ?? throw new ArgumentNullException(nameof(personRepo));
        }


       public  async Task<IEnumerable<Person>> GetPersons()
        {
            return await _personRepo.getAllPerson();
        }


        public async Task<Person> GetPersonWithId(int personId)
        {
            return await _personRepo.GetPersonWithId(personId);
        }

        

        public async void AddPerson(Person person)
        {
            await _personRepo.CreatePerson(person);
            await _personRepo.SaveChangesAsync();
        }


        public async void DeletePerson(Person person)
        {
            _personRepo.DeletePerson(person);
        }




    }
}
