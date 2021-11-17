using System;
using System.Collections.Generic;

namespace UniqueValueCollection
{
    class Student //:object //: IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override int GetHashCode()
        {
            const int seedValue = 23;
            int hash = this.Id.GetHashCode() * seedValue;
            return hash;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                throw new NullReferenceException("null has been passed");

            if (!(obj is Student))
            {
                throw new ArgumentException("Not of type Student");
            }

            Student other = obj as Student;
            if (this == other)
                return true;

            if (!this.Id.Equals(other.Id))
                return false;

            if (!this.Name.Equals(other.Name))
                return false;

            return true;
        }

        public override string ToString()
        {
            return $"{this.Id}, {this.Name}";
        }

        /*
        public int CompareTo(Student other)
        {
            if (other == null)
                throw new NullReferenceException("other instance is NULL");

            if (this == other)
                return 0;

            if (this.Id.CompareTo(other.Id) == 0)
                return this.Name.CompareTo(other.Name);
            else
                return this.Id.CompareTo(other.Id);
        }
        */
    }
    class Program
    {
        static void Main()
        {
            //Student anilStudent = new Student { Id = 1, Name = "anil" };
            //Student sunilStudent = new Student { Id = 2, Name = "sunil" };
            Student anilStudent = new Student();
            Student sunilStudent = new Student();
            //Student sunilStudent = anilStudent;

            //Console.WriteLine(anilStudent.ToString());
            //Console.WriteLine(sunilStudent);

            // if (anilStudent.Equals(sunilStudent))
            //if (anilStudent.GetHashCode().Equals(sunilStudent.GetHashCode()))
            //{
            //    if (anilStudent.Equals(sunilStudent))
            //        Console.WriteLine("same");
            //    else
            //        Console.WriteLine("not same");
            //}
            //else
            //{
            //    Console.WriteLine("not same");
            //}
            //if (this == other)
            //{
            //    return true
            //}
            //else
            //{
            //   return false;
            //}

            /*
            //comparison: greater, less and equal
            anilStudent.CompareTo(sunilStudent);

            List<Student> students = new List<Student>
            {
                anilStudent,sunilStudent
            };
            students.Sort();
            */

            //collection of unique items
            //HashSet<int> numbers = new HashSet<int>();
            //numbers.Add(12);
            //numbers.Add(1);
            //numbers.Add(12);
            //numbers.Add(13);

            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            HashSet<Student> students = new HashSet<Student>();
            students.Add(anilStudent);
            students.Add(sunilStudent);
            students.Add(anilStudent);

            foreach (Student item in students)
            {
                Console.WriteLine(item);
            }
            //for (int i = 0; i < 5; i++)
            //{
            //    yield return i;
            //}
        }
    }
}
