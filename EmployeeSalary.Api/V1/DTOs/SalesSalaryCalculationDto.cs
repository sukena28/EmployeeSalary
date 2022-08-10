using System.ComponentModel.DataAnnotations;

namespace EmployeeSalary.Api.V1.DTOs
{
    public class SalesSalaryCalculationDto: BasicSalaryCalculationDto
    {
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "{0} should be greater than or equal {1}")]
        public float Commission { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "{0} should be greater than or equal {1}")]
        public double PlannedTarget { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "{0} should be greater than or equal {1}")]
        public double CurrentTarget { get; set; }
    }
}
