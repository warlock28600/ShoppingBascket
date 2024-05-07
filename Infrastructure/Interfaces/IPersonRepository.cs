﻿using Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    internal interface IPersonRepository
    {
        Task<IEnumerable<Person>> getAllPerson();


        Task<Person> GetPersonWithId(int id);

        Task<bool> PersonExists(int personId);

        Task CreatePerson(Person person);

        Task DeletePerson(int personId);

        Task<bool> SaveChangesAsync();

    }
}