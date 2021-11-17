using System;
using System.Collections.Generic;

namespace OtherGenericCollectionClasses
{
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
            students.Sort();
            foreach (Student item in students)
            {
                Console.WriteLine($"{item.Id}, {item.Name}");
            }
           
        }
    }
}
