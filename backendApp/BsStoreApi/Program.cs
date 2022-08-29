using BsStoreApi.Extensions;
using Microsoft.EntityFrameworkCore;
using Repositories.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddApplicationPart(typeof(BsStoreApi.Presentation.AssemblyReference).Assembly);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers()
    .AddApplicationPart(typeof(BsStoreApi.Presentation.AssemblyReference).Assembly)
    .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.ConfigureSqlConnection(builder.Configuration);
builder.Services.RegisterToIo();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.ConfigureExceptionHandler();
app.MapControllers();

app.Run();
