using EmployeeSalary.Api.Models.Entities;

namespace EmployeeSalary.Api.V1.Services
{
    public interface IEmployeeService
    {
        double CalculateSalary(Employee employee);
    }
}
