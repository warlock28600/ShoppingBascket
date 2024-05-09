using Application;
using Application.Businesses;
using Infrastructure;
using Infrastructure.DbContexts;
using Infrastructure.Profiles;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ShoppingBascketDbContext>(options =>
//options.UseSqlServer("Data Source=.;Initial Catalog=ProductDb;Integrated Security=true;Encrypt=false")

options.UseSqlServer("Data Source=.;Initial Catalog=ProductDb;Integrated Security=true;Encrypt=false",
            b => b.MigrationsAssembly("Api"))
);

builder.Services.AddAutoMapper(typeof(Infrastructure.StartUp));

builder.Services.AddApplication().AddInfrastructure();

builder.Services.AddScoped<IPersonBusiness, PersonBusiness>();
builder.Services.AddScoped<IPersonRepository,PersonRepository>();


void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    else
    {
        // Other error handling middleware for non-development environments...
    }

    // Other middleware configurations...
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
