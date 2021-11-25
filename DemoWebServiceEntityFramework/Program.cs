using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DemoWebServiceEntityFramework.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TodoContext>(options => {
    //options.UseSqlServer("name=ConnectionStrings:DafaultConnection")
    options.UseSqlServer(builder.Configuration.GetConnectionString("DafaultConnection"));
    options.LogTo(Console.WriteLine).EnableSensitiveDataLogging();
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
