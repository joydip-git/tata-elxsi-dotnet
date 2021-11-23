using System;
using System.ServiceModel;
using WcfServiceApp.Entities;

namespace WcfServiceApp.CustomHost
{
    class Program
    {
        static void Main()
        {
            ServiceHost host = null;
            try
            {
                host = new ServiceHost(typeof(Calculation));
                host.Open();
                Console.WriteLine("calcuation service host is running...");
                Console.WriteLine("press any ket to terminate the host");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                host.Close();
            }
        }
    }
}
