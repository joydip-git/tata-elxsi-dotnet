using System;
using EFCoreWithDbFirstUsingDotNetCLI.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreWithDbFirstUsingDotNetCLI
{
    class Program
    {
        static void Main()
        {
            tataelxsidbContext dbObject = new tataelxsidbContext();
            DbSet<Employee> all = dbObject.Employees;
            Employee employee = new Employee
            {
                Employeename = "suresh",
                Employeesalary = 40000,
                Location = "Mumbai"
            };
            all.Add(employee);
            int rowsAdded = dbObject.SaveChanges();
            Console.WriteLine($"{rowsAdded} record(s) added");
        }
    }
}
