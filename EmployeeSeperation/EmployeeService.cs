using System;

public class EmployeeService
{
    // Event using built-in delegate
    public event EventHandler<EmployeeEventArgs> OnEmployeeSeparated;

    public void SeparateEmployee(int id, string name)
    {
        Console.WriteLine($"Employee {name} separated.");

        // Raise event
        OnEmployeeSeparated?.Invoke(this, new EmployeeEventArgs
        {
            EmployeeId = id,
            EmployeeName = name
        });
    }
}