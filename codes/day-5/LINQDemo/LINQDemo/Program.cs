using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    class CompareNumbersInDecsendingOrder : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }
    class Program
    {
        static void Main()
        {
            List<string> names = new List<string> { "Bangalore", "Chennai", "Hyderabad", "Coimbatore", "Baroda" };

            //var x = 10;
            //x = false;

            /*
             * IEnumerable<IGrouping<char,string>>
             * new Group { Key='B', values=new List<string>{"Bangalore", "Baroda"} }
             * new Group { Key='C', values=new List<string>{"Chennai", "Coimbatore"} }
             * new Group { Key='H', values=new List<string>{"Hyderabad"} }
             */
            //implicit typing (no strict typing)

            //deferred execution (Query Syntax)
            IEnumerable<IGrouping<char, string>> query = from name in names
                                                          group name by name[0];

            //Immediate execution (Method query)
            //IEnumerable<IGrouping<char, string>> gropus = names.GroupBy(name => name[0]);

            foreach (IGrouping<char, string> gr in query)
            {
                Console.WriteLine($"Names starting with:{gr.Key}");
                Console.WriteLine("---------------------------------------");
                foreach (string name in gr)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine("\n");
            }

            //group all the names by the starting letter of the names
            /*
             * Names starting with B:
             * ---------------------------------
             * Bangalore
             * Baroda
             * 
             * Names starting with C:
             * ---------------------------------
             * Chennai
             * Coimbatore
             * 
             * Names starting with H:
             * ---------------------------------
             * Hyderabad
             */
        }
        private void UseLinq()
        {
            List<int> numbers = new List<int> { 1, 4, 2, 5, 3, 7, 9, 6, 0, 8 };
            //1. filter all the even numbers
            //2. sort the filtered even numbers in descending order
            //3. print the result

            //Method query syntax
            numbers
                .Where(a => a % 2 == 0)
                .OrderByDescending(a => a)
                .ToList<int>()
                .ForEach(a => Console.WriteLine(a));

            //query operator syntax
            //numbers--> source of data
            //a--> range variable
            IOrderedEnumerable<int> sortedEvenNumbers =
                from a in numbers
                where a % 2 == 0
                orderby a descending
                select a;

            //List<int> sortedEvenNumbersList = sortedEvenNumbers.ToList<int>();
            foreach (int item in sortedEvenNumbers)
            {
                Console.WriteLine(item);
            }


            /*
            //1. filter all the even numbers
            //Func<int, bool> evenLogic = a => a % 2 == 0;
            //IEnumerable<int> evenNumbers = numbers.Where(evenLogic);
            IEnumerable<int> evenNumbers = numbers.Where(a => a % 2 == 0);

            //2. sort the filtered even numbers in descending order
            //evenNumbers.Sort(new CompareNumbersInDecsendingOrder());
            IOrderedEnumerable<int> sortedEvenNumbers = evenNumbers.OrderByDescending(a => a);

            //3. print the result
            //foreach (int item in evenNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            sortedEvenNumbers.ToList<int>().ForEach(a => Console.WriteLine(a));
            */
        }
        private static void Implement()
        {
            List<int> numbers = new List<int> { 1, 4, 2, 5, 3, 7, 9, 6, 0, 8 };
            //1. filter all the even numbers
            //2. sort the filtered even numbers in descending order
            //3. print the result

            //1. filter all the even numbers
            List<int> evenNumbers = new List<int>();
            foreach (int item in numbers)
            {
                if (item % 2 == 0)
                {
                    evenNumbers.Add(item);
                }
            }

            //2. sort the filtered even numbers in descending order
            evenNumbers.Sort(new CompareNumbersInDecsendingOrder());

            //3. print the result
            foreach (int item in evenNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
