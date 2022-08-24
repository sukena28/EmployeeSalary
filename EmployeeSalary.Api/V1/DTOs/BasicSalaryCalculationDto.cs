using System.ComponentModel.DataAnnotations;

namespace EmployeeSalary.Api.V1.DTOs
{
    public interface ISalaryCalculationDto
    {
        int Salary { get; set; }
    }
    public class BasicSalaryCalculationDto : ISalaryCalculationDto
    {

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Value for {0} must be greater than or equal {1}")]
        public int Salary { get; set; }
    }
}
