namespace EmployeeSalary.Api.Models.Entities;

public abstract class HasLeaderEmployee<TEmployee> : Entities.Employee where TEmployee : Entities.Employee
{

    private TEmployee Leader { get; set; }



    protected HasLeaderEmployee()
    {
    }

    protected HasLeaderEmployee(int id,string name, double salary, TEmployee leader) : base(id,name,
       salary)
    {
        Leader = leader;
    }

}