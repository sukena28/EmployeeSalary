using EmployeeSalary.Api.Common.Attributes;
using EmployeeSalary.Api.Common.Configurations;
using EmployeeSalary.Api.Common.Middlewares;
using EmployeeSalary.Api.V1.Extensions;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddApiVersioningConfigured();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddLogging();

//Custom Services
builder.Services.AddScoped<ModelValidationAttribute>();
builder.Services.AddServices();
builder.Services.AddApiVersioningConfigured();



builder.Host.ConfigureLogging(logging =>
{
    logging.ClearProviders();
    logging.AddConsole();
});

builder.Configuration.SetBasePath(Directory.GetCurrentDirectory());
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
builder.Configuration.AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Stage"}.json", optional: true);
builder.Configuration.AddJsonFile($"appsettings.{Environment.MachineName}.json", optional: true);
builder.Configuration.AddEnvironmentVariables();

builder.Host.UseSerilog((context, config) =>
                                        config.WriteTo
                                        .Console()
                                        .ReadFrom.Configuration(context.Configuration));
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpLogging();
app.MapControllers();

app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
