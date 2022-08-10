using EmployeeSalary.Api.Models.Employee;
using EmployeeSalary.Api.V1.DTOs;

namespace EmployeeSalary.Api.V1.Services
{
    public interface ISalaryCalculationService
    {
        double CalculateSalary<TInputDto, TEmployee>(TInputDto input) where TEmployee : Employee where TInputDto : BasicSalaryCalculationDto;
    }
}
