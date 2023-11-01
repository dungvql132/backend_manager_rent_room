using BusinessLayer.AutoMapper;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using DataLayer.Interfaces;
using DataLayer.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// app.Run();
