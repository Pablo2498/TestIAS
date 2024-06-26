using Microsoft.EntityFrameworkCore;
using TestIASApi.Context;
using TestIASApi.Repositories;
using TestIASApi.Repositories.Interfaces;
using TestIASApi.Services;
using TestIASApi.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("Database"))
    );

builder.Services.AddTransient<IVehicleRepository, VehicleRepository>(); 
builder.Services.AddTransient<IVehicleService, VehicleService>(); 
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
