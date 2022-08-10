using AutoMapper;
using EmployeeSalary.Api.Models.Employee;
using EmployeeSalary.Api.Models.Shards;
using EmployeeSalary.Api.V1.DTOs;

namespace EmployeeSalary.Api.V1.Services
{
    public class SalaryCalculationService : ISalaryCalculationService
    {
        private readonly IMapper _mapper;
        public SalaryCalculationService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public double CalculateSalary<TInputDto, TEmployee>(TInputDto input) 
            where TEmployee: Employee
            where TInputDto : BasicSalaryCalculationDto
        {
            var employee = _mapper.Map<TEmployee>(input);

            if (employee == null)
                throw new AppException($"Data not correct for type {typeof(TEmployee)}");

           return employee.CalculateSalary();
        }
    }
}
