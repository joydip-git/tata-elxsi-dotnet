using EmployeeManagementSystem.Entities;
//static import (importing a static type)
using static EmployeeManagementSystem.UserInterface.UserInterfaceUtility;

namespace EmployeeManagementSystem.UserInterface
{
    class Program
    {
        static void Main()
        {
            int count = GetCount();
            Employee[] employees = new Employee[count];

            for (int i = 0; i < count; i++)
            {
                PrintOpions();
                int choice = GetChoice();
                Employee employee = CreateEmployee(choice);
                employees[i] = employee;
            }
            PrintSalary(employees);
        }
    }
}
