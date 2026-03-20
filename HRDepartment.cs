using System;

public class HRDepartment
{
    public void HandleExit(object sender, EmployeeEventArgs e)
    {
        Console.WriteLine($"HR: Conducting exit interview for {e.EmployeeName}");
    }
}
