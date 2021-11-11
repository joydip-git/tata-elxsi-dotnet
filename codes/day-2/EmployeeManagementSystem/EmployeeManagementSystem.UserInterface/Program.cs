using System;
using EmployeeManagementSystem.Entities;

namespace EmployeeManagementSystem.UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee joydipEmployeeObjRef = new Employee(1, "joydip", 1000, 2000, 3000);
            Developer joydipEmployeeObjRef = new Developer(1, "joydip", 1000, 2000, 3000, 4000);         
            joydipEmployeeObjRef.CalculateSalary();
            Console.WriteLine(joydipEmployeeObjRef.TotalSalary);
        }
    }
}
