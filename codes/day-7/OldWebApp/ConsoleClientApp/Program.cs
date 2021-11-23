using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleClientApp.CalcService;

namespace ConsoleClientApp
{
    class Program
    {
        static void Main()
        {
            //createing object of a proxy class
            CalculationService svc = new CalculationService();
            //calling add method on proxy object, that will make an RMI request
            int result = svc.Add(12, 13);
            Console.WriteLine(result);
        }
    }
}
