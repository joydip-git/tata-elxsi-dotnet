using System;
using System.Collections.Generic;

namespace OtherGenericCollectionClasses
{
    //IComparable<T> --> System
    class Student : IComparable<Student>
    {
        //automatic property (2007-3.0)
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(Student other)
        {
            if (this == other)
                return 0;

            if (this.Id.CompareTo(other.Id) == 0)
                return this.Name.CompareTo(other.Name);
            else
                return this.Id.CompareTo(other.Id);
        }
    }
    //IComparer<T> --> System.Collections.Generic
    class StudentComparison : IComparer<Student>
    {
        private int _choice;
        public StudentComparison() { }
        public StudentComparison(int choice)
        {
            this._choice = choice;
        }
        public int Compare(Student x, Student y)
        {           
            if (x == y)
            {
                return 0;
            }
            else
            {
                int result = 0;
                switch (this._choice)
                {
                    case 1:
                        result = x.Id.CompareTo(y.Id);
                        break;

                    case 2:
                        result = x.Name.CompareTo(y.Name);
                        break;

                    default:
                        result = x.Id.CompareTo(y.Id);
                        break;
                }
                return result;
            }
        }
    }
    class Program
    {
        static void Main()
        {

            //List<int> numbers = new List<int>();
            //numbers.Add(12);
            //numbers.Add(1);

            //collection intializer (2007-3.0)
            /*
            List<int> numbers = new List<int>
            {
                12,
                1,
                31,
                23
            };
            //numbers.Sort();
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            */
            //object initializer(2007 - 3.0)
            //Student anilStudent = new Student { Id = 2, Name = "anil" };
            //Student sunilStudent = new Student { Id = 1, Name = "sunil" };
            //Student joydipStudent = new Student { Id = 3, Name = "joydip" };

            //List<Student> students = new List<Student>();
            //students.Add(anilStudent);
            //students.Add(sunilStudent);
            //students.Add(joydipStudent);

            List<Student> students = new List<Student>
            {
                new Student { Id = 2, Name = "anil" },
                new Student { Id = 1, Name = "sunil" },
                new Student { Id = 3, Name = "joydip" }
            };
            /*
            for (int i = 0; i < students.Count; i++)
            {
                for (int j = i + 1; j < students.Count; j++)
                {
                    //if (students[i].Id > students[j].Id)
                    //if (students[i].Id.CompareTo(students[j].Id) > 0)
                    //if (students[i].Name.CompareTo(students[j].Name) > 0)
                    if(students[i].CompareTo(students[j])>0)
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
            */
            //internalization of sorting
            //it expects that you have implemented IComparable<T>/IComparable interface in the Student class [int CompareTo(T other)/int CompreTo(object other)], in order to compare the objects with each other
            //students[i].CompareTo(stuents[j])
            //students.Sort();

            Console.WriteLine("1. sort by id");
            Console.WriteLine("2. sort by name");

            Console.Write("enter choice[1/2]: ");
            int choice = int.Parse(Console.ReadLine());

            //externalization of sorting
            StudentComparison studentComparison = new StudentComparison(choice);
            //it expects that you have implemented IComparer<T>/IComparer interface in the StudentComparison class [int Compare(T x, T y)/int Compre(object x, object y)], in order to compare the objects with each other
            students.Sort(studentComparison);
            //studentComparison.Compare(students[i],students[j]);

            foreach (Student item in students)
            {
                Console.WriteLine($"{item.Id}, {item.Name}");
            }

        }
    }
}
