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



    }
}
