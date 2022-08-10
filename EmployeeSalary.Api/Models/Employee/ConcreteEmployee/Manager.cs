using System.ComponentModel.DataAnnotations;

namespace EmployeeSalary.Api.Models.Employee.ConcreteEmployee;

public class Manager : Employee
{
    #region properties
    public double Bonus { get; set; }

    #endregion

    #region Constructor

    public Manager()
    {
    }

    public Manager(string name, int workingHours, double ratingHour, double bonus) : base(name, workingHours,
        ratingHour)
    {
        Bonus = bonus;
    }

    #endregion

    #region Methods

    public override double CalculateSalary()
    {
        var baseSalary = base.CalculateSalary();

        return baseSalary + Bonus;
    }

    #endregion
}