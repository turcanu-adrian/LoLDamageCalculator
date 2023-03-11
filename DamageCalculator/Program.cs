using Infrastructure.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Application.Abstract;
using Infrastructure;
using System.Text;
using Domain;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DamageCalculator;Trusted_Connection=True"));
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddCors();

builder.Services.AddAuthorization();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<IChampionRepository>());

builder.Services.AddScoped<IChampionRepository, ChampionRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(
    config => config.AllowAnyHeader()
            .AllowAnyMethod()
            .WithOrigins("http://localhost:3000")
            .AllowCredentials()
            );

app.UseAuthorization();

app.MapControllers();

app.Run();
