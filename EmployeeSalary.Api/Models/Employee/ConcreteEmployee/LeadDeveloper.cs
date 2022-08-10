
namespace EmployeeSalary.Api.Models.Employee.ConcreteEmployee
{
    public class LeadDeveloper : HasLeaderEmployee<Manager>
    {
        #region Constructor
        public LeadDeveloper() { }
        public LeadDeveloper(string name, int workingHours, double ratingHour, Manager manager) :
            base(name, workingHours, ratingHour, manager)
        {

        }
        #endregion
    }
}
