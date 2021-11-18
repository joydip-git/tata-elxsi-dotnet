using System;
using System.Collections.Generic;

namespace DelegatesBegining
{
    class Program
    {
        static List<int> Filter(List<int> inputList)
        {
            List<int> list = new List<int>();

            foreach (int item in inputList)
            {
                //if (item % 2 == 0)
                if (item % 2 != 0)
                    list.Add(item);
            }

            return list;
        }
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 4, 3, 6, 8, 7, 2, 9, 0, 5 };
            List<int> resultList = Filter(numbers);
            foreach (int item in resultList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
