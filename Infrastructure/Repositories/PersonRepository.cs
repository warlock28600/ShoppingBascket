using Infrastructure.DbContexts;
using Infrastructure.Interfaces;
using Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class PersonRepository : IPersonRepository
    {
        private readonly ShoppingBascketDbContext _context;
        public PersonRepository(ShoppingBascketDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public Task CreatePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public Task DeletePerson(int personId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Person>> getAllPerson()
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetPersonWithId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PersonExists(int personId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
