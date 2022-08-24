using EmployeeSalary.Api.V1.DTOs;

namespace EmployeeSalary.Api.Models.Entities.ConcreteEmployee;

public class Manager : Employee
{
    public double Bonus { get; set; }

    public Manager() {  }
    public Manager(int id,string name, double salary, double bonus) : base(id, name, salary)
    {
        Bonus = bonus;
    }
    public override double CalculateSalary()
    {
        var baseSalary = base.CalculateSalary();

        return baseSalary + Bonus;
    }
}