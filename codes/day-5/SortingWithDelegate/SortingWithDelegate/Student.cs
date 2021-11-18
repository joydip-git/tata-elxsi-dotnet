using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingWithDelegate
{
    class Student//:IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }

        //public int CompareTo(Student other)
        //{
        //    throw new NotImplementedException();
        //}
    }
    /*
    class StudentComparison : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            throw new NotImplementedException();
        }
    }
    */
}
