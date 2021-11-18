using DelegateLibrary;
using System;
using System.Collections.Generic;

namespace DelegatesBegining
{

    class Program
    {
        static List<T> Filter<T>(List<T> inputList, FilterLogicHandler<T> logicHandler)
        {
            List<T> list = new List<T>();

            foreach (T item in inputList)
            {
                if (logicHandler(item))
                    list.Add(item);
            }

            return list;
        }
        static void Main()
        {
            //FilterListOfNumbers();
            FilterStudents();
        }

        private static void FilterStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id=1, Name="anil", Marks=89.45 },
                new Student { Id=2, Name="sunil", Marks=70.76 },
                new Student { Id=3, Name="joy", Marks=60.34 }
            };

            FilterLogic logic = new FilterLogic();
            FilterLogicHandler<Student> logicHandler = new FilterLogicHandler<Student>(logic.IsMarksGreaterThanSeventy);
            List<Student> result = Filter(students, logicHandler);
            foreach (Student item in result)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void FilterListOfNumbers()
        {
            //source of data
            List<int> numbers = new List<int> { 1, 4, 3, 6, 8, 7, 2, 9, 0, 5 };

            FilterLogic filterLogic = new FilterLogic();
            //delegate object holding reference to a logic function
            FilterLogicHandler<int> evenLogic = new FilterLogicHandler<int>(filterLogic.IsGreaterThanFive);

            List<int> resultList = Filter(numbers, evenLogic);
            foreach (int item in resultList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
