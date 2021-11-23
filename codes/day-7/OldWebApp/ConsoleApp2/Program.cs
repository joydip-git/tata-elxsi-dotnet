using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("running console app2 in process: " + Process.GetCurrentProcess().ProcessName);
            Console.WriteLine("and running in Domain: " + AppDomain.CurrentDomain.FriendlyName);
          
            Console.WriteLine("hit any key to stop the application...");
            Console.ReadLine();
        }
    }
}
