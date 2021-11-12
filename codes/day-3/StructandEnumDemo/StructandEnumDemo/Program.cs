using System;

namespace StructandEnumDemo
{
    enum Designtaion
    {
        SrDev,
        JrDev,
        TeamLead,
        ProjectManager
    }
    class Employee
    {
        Designtaion designtaion;
    }
    enum Color
    {
        black = 100,//=0
        blue = 200,//=1
        green = 300//=2
    }
    class User
    {
        public string userName;
        public string userLocation;
    }
    struct Point
    {
        public int x_ordinate;
        public int y_ordinate;
    }
    class Program
    {
        static void Create()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Location: ");
            string location = Console.ReadLine();

            User user = new User();
            user.userLocation = location;
            user.userName = name;

            // return user;
        }
        static void CreatePoint()
        {
            Point p;
            p.x_ordinate = 10;
            p.y_ordinate = 20;
        }
        static void Main()
        {
            CreatePoint();

            // User[] users = new User[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Create();
            //    //User user = Create();
            //    //users[i] = user;
            //}

            Color color = Color.black;
            Console.WriteLine(Convert.ToInt32(color));
        }
    }
}
