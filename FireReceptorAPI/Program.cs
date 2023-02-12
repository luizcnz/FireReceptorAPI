using AutoMapper;
using FireReceptorAPI.Automapper;
using FireReceptorAPI.Features.Alertas;
using FireReceptorAPI.Features.Dispositivos;
using FireReceptorAPI.Features.Ubicaciones;
using FireReceptorAPI.Interfaces.Alertas;
using FireReceptorAPI.Interfaces.Dispositivos;
using FireReceptorAPI.Interfaces.Ubicaciones;
using FireReceptorAPI.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

var MapperConfig = new MapperConfiguration(mapper =>
{
    mapper.AddProfile(new MappingProfile());
});
IMapper mapper = MapperConfig.CreateMapper();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAlertasAppService, AlertasAppService>()
                .AddScoped<IAlertasRepository, AlertaRepository>()
                .AddScoped<IUbicacionesAppService, UbicacionesAppService>()
                .AddScoped<IUbicacionesRepository, UbicacionesRepository>()
                .AddScoped<IDispositivosAppService, DispositivosAppService>()
                .AddScoped<IDispositivosRepository, DispositivosRepository>()
                .AddSingleton(mapper)
                .AddMvc();

builder.Services.AddDbContext<FireContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"));

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
