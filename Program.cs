using Blog.Data;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;
DotNetEnv.Env.Load();

var builder = WebApplication.CreateBuilder(args);

// var connectionString = builder.Configuration.GetConnectionString("SqlServer");
var dbConnectionString = Env.GetString("SqlServer");

builder.Services.AddDbContext<BlogDataContext>(options => options.UseSqlServer(dbConnectionString));
builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();