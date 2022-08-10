
namespace EmployeeSalary.Api.Models.Employee.ConcreteEmployee
{
    public class Developer : HasLeaderEmployee<LeadDeveloper>
    {
        #region Constructor
        public Developer() { }

        public Developer(string name, int workingHours, double ratingHour, LeadDeveloper leadDeveloper) :
            base(name, workingHours, ratingHour, leadDeveloper)
        { }
        #endregion
    }
}
