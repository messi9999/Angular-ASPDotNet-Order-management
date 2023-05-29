using Microsoft.EntityFrameworkCore;
using backend_ASPDotNet_2022_web_api_.Models;
using Microsoft.Extensions.DependencyInjection;
using backend_ASPDotNet_2022_web_api_.Data;
using System.Configuration;

using Pomelo.EntityFrameworkCore.MySql;



var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var serverVersion = ServerVersion.AutoDetect(connectionString);

builder.Services.AddDbContext<OrderDbContext>(dbContextOptions => dbContextOptions.UseMySql(connectionString, serverVersion)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors());

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("http://localhost:4200");
        });
});




// Add services to the container.

builder.Services.AddControllers();


//builder.Services.AddDbContext<OrderDbContext>(opt =>
//    opt.UseInMemoryDatabase("TodoList"));

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


app.MapGet("/api/order", async (OrderDbContext db) =>
    await db.Orders.ToListAsync());

app.MapGet("/api/order/{id}", async (int id, OrderDbContext db) =>

    await db.Orders.FindAsync(id)
        is Order todo
            ? Results.Ok(todo)
            : Results.NotFound());

app.MapPost("/api/order", async (Order todo, OrderDbContext db) =>
{
    db.Orders.Add(todo);
    await db.SaveChangesAsync();

    return Results.Created($"/api/order/{todo.Id}", todo);
});



app.Run();
