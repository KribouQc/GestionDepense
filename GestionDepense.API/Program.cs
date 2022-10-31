using AutoMapper;
using Gestion_Depense_core.CompteBanquaire.Application;
using GestionDepense.Core.CompteBanquaire.Application.Interface;
using GestionDepense.Infrastructure;
using GestionDepense.Infrastructure.CompteBanquaire;
using GestionDepense.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(AutoMapperProfil));
builder.Services.AddDbContext<UniteDeTravailInMemory>
(o => o.UseInMemoryDatabase("MesDepense"));

builder.Services.AddScoped<ICompteBanquaireRepository, CompteBanquaireRepositoryInMemory>();
builder.Services.AddScoped<ICompteBanquaireService, CompteBanquaireService>();


var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

