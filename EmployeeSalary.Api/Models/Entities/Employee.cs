namespace EmployeeSalary.Api.Models.Entities;

public abstract class Employee
{

    public int Id { get; set; }      
    public string Name { get; set; }
    public double Salary { get; set; }

    protected Employee()
    {
    }

    protected Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    public virtual double CalculateSalary()
    {
        return Salary;
    }

}