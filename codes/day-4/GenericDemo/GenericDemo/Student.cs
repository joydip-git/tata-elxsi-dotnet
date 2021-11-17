using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class Student
    {
        string name;
        int id;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }

        public object this[int x]
        {
            set
            {
                if (x == 0)
                {
                    name = (string)value;
                }
                if (x == 1)
                {
                    id = (int)value;
                }
            }
            get
            {
                if (x == 0)
                {
                    return name;
                }
                if (x == 1)
                {
                    return id;
                }
                return "No data for that index value";
            }
        }

        public object this[string paramName]
        {
            set
            {
                if (paramName == "name")
                {
                    name = (string)value;
                }
                if (paramName == "id")
                {
                    id = (int)value;
                }
            }
            get
            {
                if (paramName == "name")
                {
                    return name;
                }
                if (paramName == "id")
                {
                    return id;
                }
                return "No data for that index value";
            }
        }
    }
}
