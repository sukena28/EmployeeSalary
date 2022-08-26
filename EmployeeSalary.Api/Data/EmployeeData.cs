using EmployeeSalary.Api.Models.Entities;
using EmployeeSalary.Api.Models.Entities.ConcreteEmployee;

namespace EmployeeSalary.Api.Data
{
    public static class EmployeeData
    {
        private static List<Employee> employeeList = GetData();
        public static Employee GetById(int id)
        {
            return employeeList.Single(x=> x.Id == id);
        }
        private static List<Employee> GetData()
        {
            var employeeList = new List<Employee>();

            var manager = new Manager(1, "Manager", 3000, 10);

            var leadDeveloper = new LeadDeveloper(3, "Lead Developer", 1000, manager);

            employeeList.Add(manager);
            employeeList.Add(leadDeveloper);
            employeeList.AddRange(new List<Employee>()
            {
                new HR(2, "HR", 500, manager),
                new Sales(4, "Sales", 1500, .05, 1000, manager),
                new Developer(5, "Developer", 500, leadDeveloper)
            });

            return employeeList;
        }
    }
}
