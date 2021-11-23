using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("running console app1 in process: " + Process.GetCurrentProcess().ProcessName);
            AppDomain currentDomain = AppDomain.CurrentDomain;
            Console.WriteLine("and running in Domain: " + currentDomain.FriendlyName);

            Console.WriteLine("\nAssemblies in " + currentDomain.FriendlyName);
            Assembly[] assemblies = currentDomain.GetAssemblies();
            assemblies.ToList<Assembly>().ForEach(a => Console.WriteLine(a.FullName));

            //AppDomain newDomain = AppDomain.CreateDomain("Second domain");
            //newDomain.Load("ConsoleApp2");
            //newDomain.ExecuteAssembly("ConsoleApp2.exe");
            //ClassLibrary1.Class1 class1 = new ClassLibrary1.Class1();
            //Console.WriteLine(class1.SayHi());
            Console.WriteLine("\n\n");


            AppDomain newDomain = AppDomain.CreateDomain("Second domain");
            newDomain.Load("ClassLibrary1");


            Console.WriteLine("\nAssemblies in " + newDomain.FriendlyName);
            Assembly[] newDomainAssemblies = newDomain.GetAssemblies();
            newDomainAssemblies.ToList<Assembly>().ForEach(a => Console.WriteLine(a.FullName));

            //object obj = Activator.CreateInstance(newDomainAssemblies[1].GetType());
            //Console.WriteLine(obj);

            Console.WriteLine("hit any key to stop the application...");
            Console.ReadLine();
        }
    }
}
