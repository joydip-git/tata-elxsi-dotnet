using System;

namespace StaticDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Employee.JoiningBonus);
            //Employee anilEmployee = new Employee(1, "anil", 1000, 2000, 3000);
            //anilEmployee.CalculateSalary();
            //Console.WriteLine(Employee.JoiningBonus);
            //Console.WriteLine(anilEmployee.TotalSalary);

            //Employee sunilEmployee = new Employee(2, "sunil", 2000, 3000, 4000);
            //sunilEmployee.CalculateSalary();
            //Console.WriteLine(Employee.JoiningBonus);
            //Console.WriteLine(sunilEmployee.TotalSalary);
            DaoUtility.OpenConnection();
            //data access code
            DaoUtility.CloseConnection();
            //DaoUtility dao = new DaoUtility();
            
        }
    }
}
