using System;

class Program
{
    static void Main()
    {
        // Publisher
        EmployeeService empService = new EmployeeService();

        // Subscribers
        FinanceDepartment finance = new FinanceDepartment();
        HRDepartment hr = new HRDepartment();

        // Subscribe to event
        empService.OnEmployeeSeparated += finance.ProcessSettlement;
        empService.OnEmployeeSeparated += hr.HandleExit;

        // Trigger event
        empService.SeparateEmployee(101, "Ravi");
        empService.SeparateEmployee(102, "Reshma");
    }
}
