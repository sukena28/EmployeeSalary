
namespace EmployeeSalary.Api.Models.Entities.ConcreteEmployee
{
    public class LeadDeveloper : HasLeaderEmployee<Manager>
    {
        #region Constructor
        public LeadDeveloper() { }
        public LeadDeveloper(int id,string name, int workingHours, double ratingHour, Manager manager) :
            base(id,name, workingHours, ratingHour, manager)
        {

        }
        #endregion
    }
}
