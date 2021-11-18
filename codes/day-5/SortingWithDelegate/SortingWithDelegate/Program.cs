using System;
using System.Collections.Generic;

namespace SortingWithDelegate
{
    delegate int CompareValues<in T>(T a, T b);
    //delegate int Comparison<in T>(T x, T y);
    class SortLogic
    {
        public int CompareNumbers(int a, int b)
        {
            return a.CompareTo(b);
        }
        public int CompareStudentsByMarks(Student a, Student b)
        {
            return a.Marks.CompareTo(b.Marks);
        }
    }
    class Program
    {
        static void SortValues<T>(List<T> input, CompareValues<T> compare)
        {
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = i + 1; j < input.Count; j++)
                {
                    int res = compare(input[i], input[j]);
                    if (res > 0)
                    {
                        T temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
        }
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 4, 2, 5, 3, 6, 0, 7, 9, 8 };
            Comparison<int> comparison = (a, b) => b.CompareTo(a);
            numbers.Sort(comparison);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            List<Student> students = new List<Student>
            {
                new Student {Id=2, Name="sunil", Marks=45 },
                new Student {Id=1, Name="Joy", Marks=59 },
                new Student {Id=3, Name="anil", Marks=67 }
            };

            Comparison<Student> compareByName = (s1, s2) => s1.Name.CompareTo(s2.Name);
            //students.Sort(compareByName);
            //students.Sort((S1, s2) => S1.Marks.CompareTo(s2.Marks));
            students.Sort((s1, s2) => s1.Id.CompareTo(s2.Id));
            foreach (Student item in students)
            {
                Console.WriteLine($"{item.Name}, {item.Marks}");
            }
        }
        static void CustomDelegateUsage()
        {
            List<int> numbers = new List<int> { 1, 4, 2, 5, 3, 6, 0, 7, 9, 8 };
            CompareValues<int> compareNumbers = new CompareValues<int>(new SortLogic().CompareNumbers);
            SortValues(numbers, compareNumbers);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            List<Student> students = new List<Student>
            {
                new Student {Id=2, Name="sunil", Marks=45 },
                new Student {Id=1, Name="Joy", Marks=59 },
                new Student {Id=3, Name="anil", Marks=67 }
            };

            CompareValues<Student> compareByMarks = new CompareValues<Student>(new SortLogic().CompareStudentsByMarks);

            CompareValues<Student> compareByName = new CompareValues<Student>(
                delegate (Student s1, Student s2)
                {
                    return s1.Name.CompareTo(s2.Name);
                }
                );

            CompareValues<Student> compareById = (s1, s2) => s1.Id.CompareTo(s2.Id);

            //SortValues(students, compareByMarks);
            // SortValues(students, compareByName);
            SortValues(students, compareById);
            foreach (Student item in students)
            {
                Console.WriteLine($"{item.Name}, {item.Marks}");
            }
        }
    }
}
