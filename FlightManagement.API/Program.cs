using FightManagements.Application.Services;
using FightManagements.Domain.Ports;
using FightManagements.Infrastructure.DataContext;
using FightManagements.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Add DbContext using MySQL
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
new MySqlServerVersion(new Version(8, 0, 21))));


builder.Services.AddScoped<IPiloteRepository, InMemoryPiloteRepository>();
builder.Services.AddScoped<IAvionRepository, InMemoryAvionRepository>();
builder.Services.AddScoped<IVolRepository, InMemoryVolRepository>();
builder.Services.AddScoped<VolService>();
builder.Services.AddScoped<PiloteService>();
builder.Services.AddScoped<AvionService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("http://localhost:4200")
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});
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

app.UseCors("AllowSpecificOrigin");


app.UseAuthorization();

app.MapControllers();

app.Run();
