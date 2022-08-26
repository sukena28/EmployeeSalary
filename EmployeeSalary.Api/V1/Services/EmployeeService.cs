using EmployeeSalary.Api.Models.Entities;

namespace EmployeeSalary.Api.V1.Services
{
    public class EmployeeService : IEmployeeService
    {
        public double CalculateSalary(Employee employee)
        {
            return employee.CalculateSalary();
        }
    }
}
