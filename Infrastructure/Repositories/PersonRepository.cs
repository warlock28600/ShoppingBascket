using AutoMapper;
using Domain.Entity;
using Domain.Models;
using Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ShoppingBascketDbContext _context;

        private readonly IMapper _mapper;

        

        public PersonRepository(ShoppingBascketDbContext context , IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException();
        }

        public async void CreatePerson(PersonModel person)
        {
            var personToSave = _mapper.Map<Person>(person);
            await _context.Persons.AddAsync(personToSave);
            
         
            
        }

        public void DeletePerson(Person person)
        {
           
            _context.Persons.Remove(person);
           
        }

        public async Task<IEnumerable<PersonModel>> getAllPerson()
        {
            var persons= await _context.Persons.OrderBy(e=>e.LastName).ToListAsync();

            if(persons.Count > 0)
            {
                return _mapper.Map<IEnumerable<PersonModel>>(persons);
            }

            else return null ;


        }

        public async Task<PersonModel> GetPersonWithId(int id)
        {
            var person= await _context.Persons.Where(e=>e.PersonId==id).FirstOrDefaultAsync();

            return _mapper.Map<PersonModel>(person);
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
