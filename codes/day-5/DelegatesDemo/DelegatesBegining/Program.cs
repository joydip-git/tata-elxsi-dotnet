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
            //FilterLogicHandler<Student> logicHandler = new FilterLogicHandler<Student>(logic.IsMarksGreaterThanSeventy);

            //FilterLogicHandler<Student> logicHandler = new FilterLogicHandler<Student>(
            //    delegate (Student s)
            //{
            //    return s.Marks > 70;
            //}
            //);
            //int thresholdMarks = 70;
            //FilterLogicHandler<Student> logicHandler = delegate (Student s)
            //   {
            //       //thresholdMarks--> outer variable in anonymous method
            //       return s.Marks > thresholdMarks;
            //   };

            //Lambda expression (shorthand notation of anonymous method)
            FilterLogicHandler<Student> logicHandler = (s) => s.Marks > 70;

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
            //FilterLogicHandler<int> evenLogic = new FilterLogicHandler<int>(filterLogic.IsGreaterThanFive);

            FilterLogicHandler<int> evenLogic = delegate (int num) { return num % 2 == 0; };

            //Lambda expression (2007-3.0)
            FilterLogicHandler<int> oddLogic = (int num) => { return num % 2 == 0; };
            FilterLogicHandler<int> greaterThanFiveLogic = (num) => num % 2 == 0;
            //FilterLogicHandler<int> greaterThanFiveLogic
            //= new FilterLogicHandler<int>((num) => num % 2 == 0);

            List<int> resultList = Filter(numbers, evenLogic);
            foreach (int item in resultList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
