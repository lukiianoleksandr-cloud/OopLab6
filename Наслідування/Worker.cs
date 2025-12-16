using System;

public class Worker : Human
{
    private decimal weekSalary;
    private double hoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, double hoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.HoursPerDay = hoursPerDay;
    }

    public decimal WeekSalary
    {
        get => this.weekSalary;
        private set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = value;
        }
    }

    public double HoursPerDay
    {
        get => this.hoursPerDay;
        private set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            this.hoursPerDay = value;
        }
    }

    public decimal CalculateSalaryPerHour()
    {
        // 5 робочих днів
        decimal salaryPerHour = this.WeekSalary / (decimal)(this.HoursPerDay * 5);
        return salaryPerHour;
    }

    public override string ToString()
    {
        return $"First Name: {this.FirstName}{Environment.NewLine}" +
               $"Last Name: {this.LastName}{Environment.NewLine}" +
               $"Week Salary: {this.WeekSalary:F2}{Environment.NewLine}" +
               $"Hours per day: {this.HoursPerDay:F2}{Environment.NewLine}" +
               $"Salary per hour: {this.CalculateSalaryPerHour():F2}";
    }
}