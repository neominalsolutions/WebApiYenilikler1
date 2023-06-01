using Net6WebAPI.Application.Features.Product.StockIn;
using Net6WebAPI.Application.Features.Product.StockOut;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<IStockInService, DefaultStockInService>();
builder.Services.AddScoped<IStockInService, DefaultStockInService>();
builder.Services.AddTransient<IStockOutService, DefaultStockOutService>();




builder.Services.AddMediatR(opt =>
{
  opt.RegisterServicesFromAssemblyContaining<Program>();
});


var app = builder.Build();

//var instance = app.Services.CreateScope().ServiceProvider.GetRequiredService<DefaultStockInService>();

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
