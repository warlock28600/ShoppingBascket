using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class StartUp
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            //services.AddDbContext<ShoppingBascketDbContext>(options => options.UseSqlServer("Data Source=.;Initial Catalog=ProductDb;Integrated Security=true;Encrypt=false"));


            services.AddScoped<IPersonService, PersonService>();

            return services; 
        }
    }
}
