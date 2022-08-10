namespace EmployeeSalary.Api.Models.Entities.ConcreteEmployee;

public class Manager : Entities.Employee
{
    #region properties
    public double Bonus { get; set; }

    #endregion

    #region Constructor

    public Manager()
    {
    }

    public Manager(int id,string name, int workingHours, double ratingHour, double bonus) : base(id, name, workingHours,
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