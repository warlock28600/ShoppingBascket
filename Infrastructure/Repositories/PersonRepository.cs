using Infrastructure.DbContexts;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
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
        public async Task CreatePerson(Person person)
        {
            await _context.Persons.AddAsync(person);
        }

        public void DeletePerson(Person person)
        {
           
            _context.Persons.Remove(person);
           
        }

        public async Task<IEnumerable<Person>> getAllPerson()
        {
            return await _context.Persons.OrderBy(e=>e.LastName).ToListAsync();
        }

        public async Task<Person> GetPersonWithId(int id)
        {
            return await _context.Persons.Where(e=>e.PersonId==id).FirstOrDefaultAsync();
        }

        public async Task<bool> PersonExists(int personId)
        {
            return await _context.Persons.AnyAsync(p => p.PersonId == personId);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }
    }
}
