using System;

public class FinanceDepartment
{
    public void ProcessSettlement(object sender, EmployeeEventArgs e)
    {
        Console.WriteLine($"Finance: Processing settlement for {e.EmployeeName}");
    }
}