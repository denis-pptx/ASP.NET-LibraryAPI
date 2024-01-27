using FluentValidation;
using Library.API.Handlers;
using Library.BLL;
using Library.BLL.Models.Validators;
using Library.BLL.Services.Implementations;
using Library.BLL.Services.Interfaces;
using Library.DAL.Data;
using Library.DAL.Repositories.Implementations;
using Library.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// AutoMapper configuration.
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Validation configuration.
builder.Services.AddValidatorsFromAssemblyContaining<AuthorValidator>();
builder.Services.AddFluentValidationAutoValidation();

// Database configuration.
var connection = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(connection));

// Services configuration.
builder.Services.AddScoped<IAuthorService, AuthorService>();
builder.Services.AddScoped<IGenreService, GenreService>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

// Exceptions handling.
builder.Services.AddExceptionHandler<ApiExceptionHandler>();
builder.Services.AddProblemDetails();

var app = builder.Build();

app.UseExceptionHandler();

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
