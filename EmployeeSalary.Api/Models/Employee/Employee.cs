namespace EmployeeSalary.Api.Models.Employee;

public abstract class Employee
{
    #region Properties
    public string Name { get; set; }
    public int WorkingHours { get; set; }
    public double RatingHour { get; set; }

    #endregion

    #region Constructor

    protected Employee()
    {
    }

    protected Employee(string name, int workingHours, double ratingHour)
    {
        Name = name;
        WorkingHours = workingHours;
        RatingHour = ratingHour;
    }

    #endregion

    #region Methods

    public virtual double CalculateSalary()
    {
        return RatingHour * WorkingHours;
    }

    #endregion
}