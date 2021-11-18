using System;

namespace DelegatesIntro
{
    //public or internal
    

    class Calculation
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void Subtract(int x, int y)
        {
            Console.WriteLine(x - y);
        }
    }
}
