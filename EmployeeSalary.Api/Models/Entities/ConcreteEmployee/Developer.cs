
namespace EmployeeSalary.Api.Models.Entities.ConcreteEmployee
{
    public class Developer : HasLeaderEmployee<LeadDeveloper>
    {
        public Developer() { }
        public Developer(int id,string name, double salary, LeadDeveloper leadDeveloper) :
            base(id, name,salary, leadDeveloper) { }
    }
}
