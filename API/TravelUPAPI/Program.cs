using Microsoft.Extensions.DependencyInjection.Extensions;
using TravelUP.BLL.Implementation;
using TravelUP.BLL.Service;
using TravelUP.DLL.Implementation;
using TravelUP.DLL.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

builder.Services.TryAddScoped<IDBManagerBL, DBManagerBL>();
builder.Services.TryAddScoped<IDBManagerDL, DBManagerDL>();
builder.Services.TryAddScoped<IDapperHelper, DapperHelper>();

var app = builder.Build();

IConfiguration configuration = app.Configuration;
IWebHostEnvironment environment = app.Environment;

var config = new ConfigurationBuilder()
.SetBasePath(System.IO.Directory.GetCurrentDirectory())
.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(
options => options.SetIsOriginAllowed(x => _ = true)
.AllowAnyMethod()
.AllowAnyHeader()
.AllowCredentials());

app.UseAuthorization();

app.MapControllers();

app.Run();
