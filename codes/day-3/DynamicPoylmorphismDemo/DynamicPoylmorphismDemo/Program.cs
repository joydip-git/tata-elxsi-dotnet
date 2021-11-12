using System;

namespace DynamicPoylmorphismDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("1. get data from sql");
            Console.WriteLine("2. get data from mongo");
            Console.Write("Choice: ");
            int choice = int.Parse(Console.ReadLine());            
            IDao dao = Create(choice);
            dao.GetData();
        }

        private static IDao Create(int choice)
        {
            IDao dao = null;
            switch (choice)
            {
                case 1:
                    dao = new SqlDao();
                    break;

                case 2:
                    dao = new MongoDao();
                    break;

                default:
                    break;
            }
            return dao;
        }
    }
}
