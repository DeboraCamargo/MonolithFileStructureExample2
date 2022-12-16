using Products.Business;
using Products.Contracts;
using Products.Infra;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IProductBusiness, ProductBusiness>();
builder.Services.AddSingleton<IProductInfra, ProductInfra>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) // if !dev can use /app.UseStaticFiles()
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

//app.UseStaticFiles();
// maybe build vuejs everytime
// localhost:8080/api/name
// localhost:8080/static
// no hot reload when debugging (sad sad)


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
