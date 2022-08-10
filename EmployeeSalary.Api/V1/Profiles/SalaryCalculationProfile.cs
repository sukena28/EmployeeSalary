using AutoMapper;
using EmployeeSalary.Api.Models.Employee;
using EmployeeSalary.Api.Models.Employee.ConcreteEmployee;
using EmployeeSalary.Api.V1.DTOs;

namespace EmployeeSalary.Api.V1.Profiles
{
    public class SalaryCalculationProfile : Profile
    {
        public SalaryCalculationProfile()
        {

            CreateMap<BasicSalaryCalculationDto, Employee>();

            CreateMap<ManagerSalaryCalculationDto, Manager>()
              .IncludeBase<BasicSalaryCalculationDto, Employee>();

            CreateMap<SalesSalaryCalculationDto, Sales>()
                .IncludeBase<BasicSalaryCalculationDto, Employee>();

            CreateMap<HRSalaryCalculationDto, HR>()
           .IncludeBase<BasicSalaryCalculationDto, Employee>();


            CreateMap<DeveloperSalaryCalculationDto, Developer>()
           .IncludeBase<BasicSalaryCalculationDto, Employee>();


            CreateMap<LeadDeveloperSalaryCalculationDto, LeadDeveloper>()
           .IncludeBase<BasicSalaryCalculationDto, Employee>();
        }
    }
}
