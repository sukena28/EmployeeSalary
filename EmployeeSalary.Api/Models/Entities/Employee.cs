namespace EmployeeSalary.Api.Models.Entities;

public abstract class Employee
{
    #region Properties

    public int Id { get; set; }      
    public string Name { get; set; }
    public int WorkingHours { get; set; }
    public double RatingHour { get; set; }

    #endregion

    #region Constructor

    protected Employee()
    {
    }

    protected Employee(int id, string name, int workingHours, double ratingHour)
    {
        Id = id;
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