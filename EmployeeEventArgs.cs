using System;

public class EmployeeEventArgs : EventArgs
{
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
}