using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Phaseend.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PhaseendEmpDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PhaseendEmpDbContext") ?? throw new InvalidOperationException("Connection string 'PhaseendEmpDbContext' not found.")));
builder.Services.AddDbContext<PhaseendDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PhaseendDbContext") ?? throw new InvalidOperationException("Connection string 'PhaseendDbContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
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
