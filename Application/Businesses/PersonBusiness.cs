﻿using Domain.Entity;
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

        public async Task CraetePerson(Person person)
        {
            await _PersonRepo.CreatePerson(person);
        }

        public async Task DeletePerson(int Id)
        {
            var person=await _PersonRepo.GetPersonWithId(Id);
             _PersonRepo.DeletePerson(person);
        }

        public async Task<IEnumerable<Person>> GetPersons()
        {
            return await _PersonRepo.getAllPerson();
        }

        public async Task<Person> GetPersonWithId(int id)
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
