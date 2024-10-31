using Microsoft.EntityFrameworkCore;
using NetCore.Business.Interfaces;
using NetCore.Business.Services;
using NetCore.Data;

var builder = WebApplication.CreateBuilder(args);

// Bağlantı dizesini al
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// DbContext'i DI ile ekleyin
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString)); // SQLite kullanıyorsanız

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
