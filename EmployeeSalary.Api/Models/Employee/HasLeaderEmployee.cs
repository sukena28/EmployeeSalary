namespace EmployeeSalary.Api.Models.Employee;

public abstract class HasLeaderEmployee<TEmployee> : Employee where TEmployee : Employee
{
    #region Properies

    private TEmployee Leader { get; set; }

    #endregion

    #region Constructors

    protected HasLeaderEmployee()
    {
    }

    protected HasLeaderEmployee(string name, int workingHours, double ratingHour, TEmployee leader) : base(name,
        workingHours, ratingHour)
    {
        Leader = leader;
    }

    #endregion
}