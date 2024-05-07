using Microsoft.EntityFrameworkCore;
using Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DbContexts
{
    internal class ShoppingBascketDbContext : DbContext
    {
        public ShoppingBascketDbContext(DbContextOptions<ShoppingBascketDbContext> options) : base(options)
        {

        }

        public DbSet<Person> MyProperty { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MyEntityConfiguration());
            
        }

    }
}
