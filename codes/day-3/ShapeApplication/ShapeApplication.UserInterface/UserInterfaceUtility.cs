using ShapeApplication.Entities;
using static System.Console;

namespace ShapeApplication.UserInterface
{
    static class UserInterfaceUtility
    {
        public static int GetCount()
        {
            Write("How many shapes? ");
            return int.Parse(ReadLine());
        }

        public static void PrintOpions()
        {
            WriteLine("\n1. Create Circle");
            WriteLine("2. Create Triangle");
        }

        public static int GetChoice()
        {
            Write("Enter Choice[1/2]: ");
            return int.Parse(ReadLine());
        }

        public static IShape CreateShape(int choice)
        {
            IShape shape = null;

            switch (choice)
            {
                case 1:

                    Write("Radius: ");
                    double radius = double.Parse(ReadLine());

                    shape = new Circle(radius);
                    break;

                case 2:

                    Write("Base: ");
                    double @base = double.Parse(ReadLine());

                    Write("Height: ");
                    double height = double.Parse(ReadLine());

                    shape = new Triangle(@base, height);
                    break;

                default:
                    WriteLine("\nEnter proper choice...");
                    break;
            }
            return shape;
        }

        public static void PrintArea(IShape[] shapes)
        {
            for (int i = 0; i < shapes.Length; i++)
            {
                IShape shape = shapes[i];
                System.Console.WriteLine($"Area: {shape.CalculateArea()}");
            }
        }
    }
}
