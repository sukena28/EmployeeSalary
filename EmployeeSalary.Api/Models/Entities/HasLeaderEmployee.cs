namespace EmployeeSalary.Api.Models.Entities;

public abstract class HasLeaderEmployee<TEmployee> : Entities.Employee where TEmployee : Entities.Employee
{
    #region Properies

    private TEmployee Leader { get; set; }

    #endregion

    #region Constructors

    protected HasLeaderEmployee()
    {
    }

    protected HasLeaderEmployee(int id,string name, int workingHours, double ratingHour, TEmployee leader) : base(id,name,
        workingHours, ratingHour)
    {
        Leader = leader;
    }

    #endregion
}