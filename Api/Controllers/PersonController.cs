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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonModel>>> GetAllPersons()
        {

            var persons = await _personService.GetPersons();
             var personToReturn=_mapper.Map<PersonModel>(persons);
            return Ok(personToReturn);
        }



    }
}
