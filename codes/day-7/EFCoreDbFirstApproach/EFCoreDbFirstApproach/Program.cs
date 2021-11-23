using System;
using EFCoreDbFirstApproach.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDbFirstApproach
{
    class Program
    {
        static void Main()
        {
            tataelxsidbContext dbObject = new tataelxsidbContext();
            DbSet<Employee> all = dbObject.Employees;
            Employee employee = new Employee
            {
                Employeename = "joydip",
                Employeesalary = 30000,
                Location = "Bangalore"
            };
            all.Add(employee);
            int rowsAdded = dbObject.SaveChanges();
            Console.WriteLine($"{rowsAdded} record(s) added");
        }
    }
}
