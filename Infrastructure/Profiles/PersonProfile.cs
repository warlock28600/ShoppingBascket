using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
             CreateMap<Services.Entities.Person,Services.Models.PersonDto>().ReverseMap();
        }
    }
}
