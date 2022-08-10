
namespace EmployeeSalary.Api.Models.Entities.ConcreteEmployee
{
    public class Developer : HasLeaderEmployee<LeadDeveloper>
    {
        #region Constructor
        public Developer() { }

        public Developer(int id,string name, int workingHours, double ratingHour, LeadDeveloper leadDeveloper) :
            base(id, name, workingHours, ratingHour, leadDeveloper)
        { }
        #endregion
    }
}
