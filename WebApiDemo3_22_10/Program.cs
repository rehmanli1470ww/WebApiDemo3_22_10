using Microsoft.EntityFrameworkCore;
using WebApiDemo3_22_10.Data;
using WebApiDemo3_22_10.Entities;
using WebApiDemo3_22_10.Repository.Abstract;
using WebApiDemo3_22_10.Repository.Concret;
using WebApiDemo3_22_10.Services.Abstract;
using WebApiDemo3_22_10.Services.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICustomerRepository,EFCustomerRepository>();
builder.Services.AddScoped<IProductRepository, EFProductRepository>();
builder.Services.AddScoped<IOrderRepository, EFOrderRepository>();

builder.Services.AddScoped<ICustomerService, EFCustomerService>();
builder.Services.AddScoped<IProductService, EFProductService>();
builder.Services.AddScoped<IOrderService, EFOrderService>();



var connection = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<ShoppingDbContext>(opt =>
{
    opt.UseSqlServer(connection);
});


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
