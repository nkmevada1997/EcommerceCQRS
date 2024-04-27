using Ecommerce.Command.Countries;
using Ecommerce.Handler.Counties;
using Ecommerce.Interface.Countries;
using Ecommerce.Query.Countries;
using Ecommerce.Repository.Context;
using Ecommerce.Repository.Repositories;
using Ecommerce.Service;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

#region Dependency Resolver - Services

builder.Services.AddScoped<ICountryService, CountryService>();

#endregion

#region Dependency Resolver - Respository

builder.Services.AddScoped<ICountryRepository, CountryRepository>();

#endregion

#region Register MediatR

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

#endregion

#region Register MediatR - Commands

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(AddCountryCommand).GetTypeInfo().Assembly));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(EditCountryCommand).GetTypeInfo().Assembly));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(DeleteCountryCommand).GetTypeInfo().Assembly));

#endregion

#region Register MediatR - Queries

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(GetCountriesQuery).GetTypeInfo().Assembly));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(GetCountryDetailQuery).GetTypeInfo().Assembly));

#endregion

#region Register MediatR - Handlers

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(AddCountryHandler).GetTypeInfo().Assembly));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(GetCountriesHandler).GetTypeInfo().Assembly));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(GetCountryDetailHandler).GetTypeInfo().Assembly));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(EditCountryHandler).GetTypeInfo().Assembly));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(DeleteCountryHandler).GetTypeInfo().Assembly));

#endregion


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
