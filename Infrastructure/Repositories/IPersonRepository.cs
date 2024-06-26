﻿using Domain.Entity;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IPersonRepository
    {
        Task<IEnumerable<PersonModel>> getAllPerson();


        Task<PersonModel> GetPersonWithId(int id);

        Task<bool> PersonExists(int personId);

        void CreatePerson(PersonToCreateModel person);

        void DeletePersonAsync(int id);

        Task<bool> SaveChangesAsync();
    }
}
