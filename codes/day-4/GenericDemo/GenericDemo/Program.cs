using System;
using System.Collections.Generic;

namespace GenericDemo
{
    class Addition
    {
        //public void Add(int x, int y)
        //{

        //}
        //public void Add(long x, long y)
        //{

        //}
        //T--> Type parameter
        //generic method with constraint
        public void Add<T>(T x, T y) where T : struct
        {

        }
        public void Add<T1, T2>(T1 x, T2 y) where T1 : struct where T2 : struct
        {

        }
    }
    interface IA<T> //where T: struct
    {
        void Add(T x, T y);
    }
    class A : IA<int>
    {
        public void Add(int x, int y)
        {

        }
    }
    class B<T> : IA<T> where T : class, new()
    {
        public void Add(T x, T y)
        {

        }
    }
    class Program
    {
        static void Main()
        {
            //Student student = new Student();
            //student.Name = "joydip";
            //student.Id = 1;

            //Student student1 = new Student();
            //student1[0] = "anil";
            //student1[1] = 2;

            //Student student2 = new Student();
            //student2["name"] = "joydip";
            //student2["id"] = 1;

            //Console.WriteLine(student2[0]);
            //Console.WriteLine(student2[1]);

            //Console.WriteLine(student1[0]);
            //Console.WriteLine(student1[1]);
            //Console.WriteLine(student1[2]);

            //Addition addition = new Addition();
            //addition.Add<int>(10, 12);
            ////addition.Add<string>("str1", "str2");
            ////addition.Add<A>(new A(), new A());
            //B<int> obj = new B<int>();
            //obj.Add(12, 13);

            MyCollection<int> numbers = new MyCollection<int>();
            numbers.Add(12);
            numbers.Add(1);
            numbers.Add(31);
            numbers.Add(23);
            numbers.Add(34);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"Numbers[{i}]={numbers[i]}");
            }

            //during enumeration the collection object is locked, means you can not add new values into or remove old values from the collevtion
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(numbers.Count);
            //Console.WriteLine(numbers.Capacity);

            /*
           List<int> values = new List<int>();

            values.Add(12);          
            values.Add(1);
            values.Add(31);
            values.Add(23);
            values.Add(33);
            values.Insert(1, 34);

            //read-write
            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine($"Values[{i}]={values[i]}");
            }

            //read-only loop
            foreach (int item in values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(values.Count);
            Console.WriteLine(values.Capacity);
            */
        }
    }
}
