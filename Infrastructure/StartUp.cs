using Infrastructure.DbContexts;
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
            services.AddDbContext<ShoppingBascketDbContext>(options => options.UseSqlServer(""));
        }
    }
}
