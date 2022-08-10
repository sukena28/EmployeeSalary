
namespace EmployeeSalary.Api.Models.Employee.ConcreteEmployee
{
    public class HR : HasLeaderEmployee<Manager>
    {
        #region Constructor

        public HR()
        {
        }

        public HR(string name, int workingHours, double ratingHour, Manager manager) : base(name, workingHours,
            ratingHour, manager)
        {
        }

        #endregion

    }
}
