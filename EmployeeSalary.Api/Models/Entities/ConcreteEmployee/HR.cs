
namespace EmployeeSalary.Api.Models.Entities.ConcreteEmployee
{
    public class HR : HasLeaderEmployee<Manager>
    {
        public HR() { }
        public HR(int id,string name, double salary, Manager manager) : base(id,name, salary, manager)
        {
        }
    }
}
