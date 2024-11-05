using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using WebServer.Models;
using WebServer.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Logging.ClearProviders();
builder.Logging.AddConsole(options =>
{
#pragma warning disable CS0618 // Type or member is obsolete
    options.TimestampFormat = "[dd:MM:yy HH:mm:ss:fff] ";
    options.UseUtcTimestamp = true;
#pragma warning restore CS0618 // Type or member is obsolete
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddAutoMapper(typeof(Program));

var connectionString = Environment.GetEnvironmentVariable("ASPNETCORE_SPA_SHOP_WEBSERVER_CONNECTIONSTRING");

if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("Строка подключения не найдена. Убедитесь, что переменная окружения 'ASPNETCORE_WEBSERVER_CONNECTIONSTRING' задана.");
}

builder.Services.AddDbContext<ProductsContext>(options =>
{
    options.UseNpgsql(connectionString);
});

builder.Services.AddScoped<ProductsService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
