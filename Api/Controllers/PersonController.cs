using Application.Businesses;
using AutoMapper;
using Domain.Models;
using Infrastructure.Profiles;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/v1/person")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonBusiness _personService;
        private readonly IMapper _mapper;

        public PersonController(IPersonBusiness personService, IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;

        }

        [HttpGet("AllPersons")]
        public async Task<ActionResult<IEnumerable<PersonModel>>> GetAllPersons()
        {
            var persons = await _personService.GetPersons();
            if (persons == null)
            {
                return NoContent();  
            }
            return Ok(persons);

        }
        [HttpGet("Person")]
        public async Task<ActionResult<PersonModel>> GetPersonWithId(int id)
        {
            var person=await _personService.GetPersonWithId(id);

            return Ok(person);
        }

        [HttpPost]
        public async void AddPerson(PersonToCreateModel person)
        {
             _personService.CraetePerson(person);

            Ok();
          
        }

        [HttpDelete]
        public void DeletePerson(int id)
        {
            _personService.DeletePerson(id);

            Ok();
        }


    }
}
