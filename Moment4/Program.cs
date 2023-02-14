using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;
using Moment4.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Database connection with SQLite
builder.Services.AddDbContext<SongContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultDbString")));
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
