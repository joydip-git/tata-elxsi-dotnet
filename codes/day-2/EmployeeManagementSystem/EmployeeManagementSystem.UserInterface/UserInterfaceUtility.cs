using EmployeeManagementSystem.Entities;
using System;
using static System.Console;

namespace EmployeeManagementSystem.UserInterface
{
    static class UserInterfaceUtility
    {
        public static int GetCount()
        {
            Write("How many records? ");
            return int.Parse(ReadLine());
        }

        public static void PrintOpions()
        {
            WriteLine("\n1. Create Developer");
            WriteLine("2. Create Hr");
        }

        public static int GetChoice()
        {
            Write("Enter Choice[1/2]: ");
            return int.Parse(ReadLine());
        }

        public static Employee CreateEmployee(int choice)
        {
            Employee employee = null;

            Write("\nName: ");
            string name = ReadLine();

            Write("Id: ");
            int id = int.Parse(ReadLine());

            Write("Basic: ");
            decimal basic = decimal.Parse(ReadLine());

            Write("Da: ");
            decimal da = decimal.Parse(ReadLine());

            Write("Hra: ");
            decimal hra = decimal.Parse(ReadLine());

            switch (choice)
            {
                case 1:

                    Write("Incentive: ");
                    decimal incentive = decimal.Parse(ReadLine());

                    employee = new Developer(id, name, basic, da, hra, incentive);
                    break;

                case 2:

                    Write("Gratuity: ");
                    decimal gratuity = decimal.Parse(ReadLine());

                    employee = new Hr(id, name, basic, da, hra, gratuity);
                    break;

                default:
                    WriteLine("\nEnter proper choice...");
                    break;
            }
            return employee;
        }

        public static void PrintSalary(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Employee e = employees[i];
                e.CalculateSalary();
                WriteLine(e.TotalSalary);
            }
        }
    }
}
