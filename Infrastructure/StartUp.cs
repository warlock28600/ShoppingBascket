using Infrastructure.DbContexts;
using Infrastructure.Interfaces;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class StartUp
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddDbContext<ShoppingBascketDbContext>(options => options.UseSqlServer("Data Source=.;Initial Catalog=ProductDb;Integrated Security=true;Encrypt=false"));
            services.AddScoped<IPersonRepository, PersonRepository>();
        }
    }
}
