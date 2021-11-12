using System;
using ShapeApplication.Entities;
using static ShapeApplication.UserInterface.UserInterfaceUtility;

namespace ShapeApplication.UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = GetCount();
            IShape[] shapes = new IShape[count];

            for (int i = 0; i < count; i++)
            {
                PrintOpions();
                int choice = GetChoice();
                IShape shape = CreateShape(choice);
                shapes[i] = shape;
            }

            PrintArea(shapes);
        }
    }
}
