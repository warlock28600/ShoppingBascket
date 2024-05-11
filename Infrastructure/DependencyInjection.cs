using Infrastructure.DbContexts;
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
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddDbContext<ShoppingBascketDbContext>(options =>
            options.UseSqlServer("Data Source=.;Initial Catalog=ProductDb;Integrated Security=true;Encrypt=false"));
            return services;

            //services.AddAutoMapper(typeof().Assembly);


        }
    }
}
