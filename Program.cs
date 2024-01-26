using BookRating.Api.Validators;
using BookRating.Application.Services.Implementations;
using BookRating.Application.Services.Interfaces;
using BookRating.Infrastructure.Persistence;
using BookRatingManager.Api.Models;
using BookRatingManager.Api.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddScoped<IValidator<CreateBookModel>, CreateBookValidator>();
builder.Services.AddScoped<IValidator<CreateUserModel>, CreateUserValidator>();
builder.Services.AddScoped<IValidator<CreateRatingModel>, CreateRatingValidator>();

builder.Services.AddScoped<IUserService,UserService>();


var connectionString = builder.Configuration.GetConnectionString("BookRatingCs");
builder.Services.AddDbContext<BookRatingDbContext>(p => p.UseSqlServer(connectionString));

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
