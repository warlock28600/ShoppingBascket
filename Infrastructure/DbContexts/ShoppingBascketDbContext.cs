using Domain.Entity;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DbContexts
{
    public class ShoppingBascketDbContext : DbContext
    {
        public ShoppingBascketDbContext(DbContextOptions<ShoppingBascketDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Product> Products { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            
        }

    }
}
