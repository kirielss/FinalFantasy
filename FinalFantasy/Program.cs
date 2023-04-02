using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using FinalFantasy.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FinalFantasyDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetService<FinalFantasyDbContext>();
    dbContext.Database.Migrate();
}

app.Run();
