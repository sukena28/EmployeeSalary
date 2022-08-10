namespace EmployeeSalary.Api.Models.Employee.ConcreteEmployee;

public class Sales : HasLeaderEmployee<Manager>
{
    #region properties
    public double Commission { get; set; }
    public double PlannedTarget { get; set; }
    public double CurrentTarget { get; set; }

    #endregion

    #region Constructor

    public Sales()
    {
    }

    public Sales(string name, int workingHours, double ratingHour, double commission, double plannedTarget,
        double currentTarget, Manager manger) : base(name, workingHours, ratingHour, manger)
    {
        Commission = commission;
        PlannedTarget = plannedTarget;
        CurrentTarget = currentTarget;
    }

    #endregion

    #region Methods

    public override double CalculateSalary()
    {
        var baseSalary = base.CalculateSalary();

        if (CurrentTarget > 0 && CurrentTarget >= PlannedTarget) return baseSalary;

        return baseSalary + Commission * CurrentTarget;
    }

    #endregion
}