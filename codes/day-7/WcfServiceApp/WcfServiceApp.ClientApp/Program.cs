using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceApp.ClientApp.CalcService;

namespace WcfServiceApp.ClientApp
{
    class Program
    {
        static void Main()
        {
            //proxy object
            var proxy = new CalculationClient();
            var res = proxy.AddNumbers(12, 13);
            Console.WriteLine(res);
        }
    }
}
