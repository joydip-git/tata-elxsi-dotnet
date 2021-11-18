using System;

namespace DelegatesIntro
{
    //1. declare delegate
    delegate void CalculationDelegate(int a, int b);

    class Program
    {
        static void Main()
        {
            //2. create delegate instance
            
            //since Add is non-static/instance method, create an instance of the Calculation class
            Calculation calculation = new Calculation();
            //pass the Add method name along with class object reference variable
            CalculationDelegate calculationDelegateAdd = new CalculationDelegate(calculation.Add);

            //pass the Subtract method name along with class name, since it is a static method
            CalculationDelegate calculationDelegateSubtract = new CalculationDelegate(Calculation.Subtract);

            //3. call the method using delegate and pass parameter, if necessary, to the delegate
            calculationDelegateAdd.Invoke(12, 13);
            //or
            calculationDelegateSubtract(12, 3);

            Console.WriteLine("\n\n");

            //multicast delegate
            CalculationDelegate multiCast = new CalculationDelegate(calculation.Add);
            multiCast += new CalculationDelegate(Calculation.Subtract);
            multiCast(12, 4);
        }
    }
}
