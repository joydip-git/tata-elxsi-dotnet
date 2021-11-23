using System;

namespace WcfServiceApp.Entities
{
    public class Calculation : ICalculation
    {
        public Calculation()
        {
            Console.WriteLine("object created");
        }
        public int AddNumbers(int a, int b)
        {
            return (a + b);
        }
    }
}
