using Microsoft.EntityFrameworkCore;
using PruebaSD.Data.DataContext;
using PruebaSD.Data.Repository;
using PruebaSD.Data.SeedDB;
using PruebaSD.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContextDB>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddTransient<DataSeeder>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

if(args.Length == 1 && args[0].ToLower() == "seeddata")
{
    SeedData(app);
}

static void SeedData(IHost app)
{
    var scopeFactory = app.Services.GetService<IServiceScopeFactory>();
    using (var scope = scopeFactory?.CreateScope())
    {
        var service = scope?.ServiceProvider.GetService<DataSeeder>();
        service?.Seed();
    }
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.UseCors(options => options.WithOrigins("http://localhost:4200")
    .AllowAnyMethod()
    .AllowAnyHeader());

app.Run();
