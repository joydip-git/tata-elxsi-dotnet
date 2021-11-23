using System;
using System.Net.Http;

namespace TestApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Main Thread: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            MakeRequest();
            Console.WriteLine("hit any key to terminate");
            Console.ReadLine();
        }
        async static void MakeRequest()
        {
            HttpClient client = null;
            try
            {
                Console.WriteLine($"Request Thread: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
                client = new HttpClient();
                var res =await client.GetStringAsync("http://localhost:41723/api/Employees/fetchall");
                Console.WriteLine(res);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
