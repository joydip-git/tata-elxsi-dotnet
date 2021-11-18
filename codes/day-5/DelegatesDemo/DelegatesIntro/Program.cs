using System;
using DelegateLibrary;

namespace DelegatesIntro
{
    //1. declare delegate
    //delegate void CalculationDelegate(int a, int b);

    /*
    class CalculationDelegate : MulticastDelegate //:Delegate:Object
    {
        private Object _target;
        private System.Reflection.MethodInfo _method;
        private Delegate[] _invocationList;

        public CalculationDelegate(object target, System.Reflection.MethodInfo method)
        {
            _target = target;
            _method = method;
        }
        public void Invoke(int a, int b)
        {
            _method.Invoke(_target, new object[] { a, b });
        }
    }
    */
    class Program
    {
        //private delegate void CalculationDelegate(int a, int b);
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
            //CalculationDelegate multiCast = new CalculationDelegate(calculation.Add);
            //multiCast += new CalculationDelegate(Calculation.Subtract);
            //multiCast(12, 4);
            //CalculationDelegate multiCast = new CalculationDelegate(calculationDelegateAdd);
            CalculationDelegate multiCast = calculationDelegateAdd;
            multiCast += calculationDelegateSubtract;
            //multiCast -= calculationDelegateSubtract;
            multiCast(12, 4);
        }
    }
}
