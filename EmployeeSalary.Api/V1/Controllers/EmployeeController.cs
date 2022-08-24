using EmployeeSalary.Api.Data;
using EmployeeSalary.Api.V1.Services;
using Microsoft.AspNetCore.Mvc;


namespace EmployeeSalary.Api.V1.Controllers;

[ApiController]
[Route("api/v1/employee/")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;


    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    [Route("salary/calculation/{id?}")]
    public IActionResult Calculate(int id)
    {
        var employee = EmployeeData.GetById(id);

        var salary = _employeeService.CalculateSalary(employee);

        return Ok(salary);
    }
}