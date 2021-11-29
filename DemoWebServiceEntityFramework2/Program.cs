using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DemoWebServiceEntityFramework2.Models;
using DemoWebServiceEntityFramework2.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BdContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DafaultConnection"));
    options.LogTo(Console.WriteLine).EnableSensitiveDataLogging();
});
builder.Services.AddScoped<IProdutoRepository,ProdutoRepositoryEF>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
