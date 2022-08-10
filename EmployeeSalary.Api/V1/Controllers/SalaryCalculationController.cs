using EmployeeSalary.Api.Models.Employee.ConcreteEmployee;
using EmployeeSalary.Api.V1.DTOs;
using EmployeeSalary.Api.V1.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EmployeeSalary.Api.V1.Controllers;

[ApiController]
[Route("api/v1/employee/salary-calculation")]
public class SalaryCalculationController : ControllerBase
{
    private readonly ISalaryCalculationService _salaryCalculationService;

    private readonly ILogger<SalaryCalculationController> _logger;

    public SalaryCalculationController(ISalaryCalculationService salaryCalculationService,
        ILogger<SalaryCalculationController> logger)
    {
        _logger = logger;
        _salaryCalculationService = salaryCalculationService;
    }

    [HttpPost]
    [Route("sales")]
    public IActionResult Calculate(SalesSalaryCalculationDto input)
    {
        _logger.LogInformation(JsonConvert.SerializeObject(input));

        var salary = _salaryCalculationService.CalculateSalary<SalesSalaryCalculationDto, Sales>(input);

        return Ok(salary);
    }

    [HttpPost]
    [Route("manager")]
    public IActionResult Calculate(ManagerSalaryCalculationDto input)
    {
        var salary = _salaryCalculationService.CalculateSalary<ManagerSalaryCalculationDto, Manager>(input);

        return Ok(salary);
    }

    [HttpPost]
    [Route("developer")]
    public IActionResult Calculate(DeveloperSalaryCalculationDto input)
    {
        var salary = _salaryCalculationService.CalculateSalary<DeveloperSalaryCalculationDto, Developer>(input);

        return Ok(salary);
    }

    [HttpPost]
    [Route("leadDeveloper")]
    public IActionResult Calculate(LeadDeveloperSalaryCalculationDto input)
    {
        var salary = _salaryCalculationService.CalculateSalary<LeadDeveloperSalaryCalculationDto, LeadDeveloper>(input);

        return Ok(salary);
    }

    [HttpPost]
    [Route("HR")]
    public IActionResult Calculate(HRSalaryCalculationDto input)
    {
        var salary = _salaryCalculationService.CalculateSalary<HRSalaryCalculationDto, HR>(input);

        return Ok(salary);
    }
}