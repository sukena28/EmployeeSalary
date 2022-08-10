using EmployeeSalary.Api.V1.Services;

namespace EmployeeSalary.Api.V1.Extensions
{
    public static class ConfigureServicesRegisteration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ISalaryCalculationService, SalaryCalculationService>();
        }
    }
}
