using System.ComponentModel.DataAnnotations;

namespace EmployeeSalary.Api.V1.DTOs
{
    public class ManagerSalaryCalculationDto: BasicSalaryCalculationDto
    {
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Value for {0} must be greater than or equal {1}")]
        public double Bonus { get; set; }
    }
}
