using Microsoft.EntityFrameworkCore;
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

builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

builder.Services.AddControllers()
    .AddMvcLocalization()
    .AddDataAnnotationsLocalization();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddLocalization();
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

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllCors",
        builder =>
        {
            builder.AllowAnyHeader();
            builder.AllowAnyMethod();
            builder.AllowAnyOrigin();
        });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var supportedCultures = new[] { "en-US", "ru-RU" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);

app.UseHttpsRedirection();

app.UseCors("AllCors");

app.UseAuthorization();

app.MapControllers();

app.Run();
