using System;

namespace OOP_Refresh
{
    class A
    {
        int b;
        public A() { }
        public A(int b)
        {
            this.b = b;
        }
        public int B
        {
            get => b;
        }
    }
    class Program
    {
        static void Main()
        {
            //a--> value type variable
            //int--> value type data type
            int a = 10;

            //obj --> reference type variable
            //A--> reference type (user-defined) data type
            A obj = null;
            obj = new A(120);

            string str = "joydip";

            //Array numbers = new Array(typeof(int),2);
            //array of value types
            int[] numbers = null;
            numbers = new int[2];
            numbers[0] = 10;
            numbers[1] = 20;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //Array names = new Array(typeof(string),2);
            //array of reference types
            string[] names = new string[2];
            names[0] = "Priyanka";
            names[1] = "Nidhi";

            //Array aObjs = new Array(typeof(A),2);
            A[] aObjs = new A[2];

            A obj1 = new A(100);
            A obj2 = new A(200);

            aObjs[0] = obj1;
            aObjs[1] = obj2;

            for (int i = 0; i < aObjs.Length; i++)
            {
                A x = aObjs[i];
                Console.WriteLine(x.B);
            }
        }
    }
}
