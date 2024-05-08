using AutoMapper;
using Infrastructure.Profiles;
using Microsoft.AspNetCore.Mvc;
using Services.Models;
using Services.Services;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/v1/person")]
    public class PersonController : ControllerBase
    {
        private readonly PersonService _personService;
        private readonly IMapper _mapper;

        public PersonController(PersonService personService, IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonDto>>> GetAllPersons()
        {

            var persons = await _personService.GetPersons();
             var personToReturn=_mapper.Map<PersonDto>(persons);
            return Ok(personToReturn);
        }



    }
}
