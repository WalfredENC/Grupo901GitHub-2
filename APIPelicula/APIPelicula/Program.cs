using APIPelicula.Data;
using Microsoft.EntityFrameworkCore;
using APIPelicula.Repository.IRepository;
using APIPelicula.Repository;
using APIPelicula.PeliculasMappers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(Options  => Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Add services to the container.

// Invocamos el repository
builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddAutoMapper(typeof(PeliculasMappers));

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

ControllerActionEndpointConventionBuilder controllerActionEndpointConventionBuilder = app.MapControllers();

app.Run();
