
namespace EmployeeSalary.Api.Models.Entities.ConcreteEmployee
{
    public class HR : HasLeaderEmployee<Manager>
    {
        #region Constructor

        public HR()
        {
        }

        public HR(int id,string name, int workingHours, double ratingHour, Manager manager) : base(id,name, workingHours,
            ratingHour, manager)
        {
        }

        #endregion

    }
}
