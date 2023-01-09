using DinPlan.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

string ConnectionKey = "Prod";
#if DEBUG
ConnectionKey = "Dev";
#endif

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString(ConnectionKey));
});


var app = builder.Build();
app.UseCors(x =>
{
    x.AllowAnyOrigin()  //chaining together
    .AllowAnyHeader()
    .AllowAnyMethod();
});

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
