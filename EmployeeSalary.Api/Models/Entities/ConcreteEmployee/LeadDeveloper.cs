
namespace EmployeeSalary.Api.Models.Entities.ConcreteEmployee
{
    public class LeadDeveloper : HasLeaderEmployee<Manager>
    {
        public LeadDeveloper() { }
        public LeadDeveloper(int id,string name, double salary, Manager manager) :
            base(id,name,salary, manager)
        {

        }
    }
}
