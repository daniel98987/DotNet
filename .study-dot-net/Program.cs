using study_this_framework;
using Microsoft.EntityFrameworkCore;
using study_this_framework.interfaceRepositories;
using study_this_framework.repositories;
using study_this_framework.models;
using study_this_framework.IServices;
using study_this_framework.Services;
using study_this_framework.IBase;
using study_this_framework.Base;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IGenericRepository<Especialidad>, GenericRepository<Especialidad>>();
builder.Services.AddScoped<IEspecialidadService, EspecialidadService>();
builder.Services.AddScoped<IResponseService, ResponseService>();
builder.Services.AddDbContext<HospitalDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

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
