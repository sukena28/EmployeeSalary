using EmployeeSalary.Api.V1.DTOs;

namespace EmployeeSalary.Api.Models.Entities.ConcreteEmployee;

public class Sales : HasLeaderEmployee<Manager>
{
    public double Commission { get; set; }
    public double Target { get; set; }

    public Sales() { }
    public Sales(int id, string name, double salary, double commission, double target,Manager manger) : base(id, name,salary, manger)
    {
        Commission = commission;
        Target = target;
    }
    public override double CalculateSalary()
    {
        var baseSalary = base.CalculateSalary();

        if (Target > 0 && Target >= 1000) return baseSalary;

        return baseSalary + (Commission * Target);
    }
}