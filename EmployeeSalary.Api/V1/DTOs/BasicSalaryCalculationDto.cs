using System.ComponentModel.DataAnnotations;

namespace EmployeeSalary.Api.V1.DTOs
{
    public class BasicSalaryCalculationDto
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Value for {0} must be greater than or equal {1}")]
        public int WorkingHours { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Value for {0} must be greater than or equal {1}")]
        public double RatingHour { get; set; }
    }
}
