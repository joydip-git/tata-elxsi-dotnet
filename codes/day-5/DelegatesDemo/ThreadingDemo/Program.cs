using System;
using System.Threading;

namespace ThreadingDemo
{
    class OtherThreads
    {
        public static void Run1()
        {
            Console.WriteLine($"In Thread {Thread.CurrentThread.Name} with Thread Id: {Thread.CurrentThread.ManagedThreadId}");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Run1, i:{i}");
            }
        }
        public void Run2(object value)
        {
            Console.WriteLine($"In Thread {Thread.CurrentThread.Name} with Thread Id: {Thread.CurrentThread.ManagedThreadId}");

            int count = (int)value;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Run2, i:{i}");
            }
        }
    }
    class Program
    {
        //2nd thread

        //STA (Single-Threaded Apartment application)
        //MTA (Multi-threaded Apartment application)
        static void Main()
        {
            Thread.CurrentThread.Name = "Main";
            Console.WriteLine($"In Thread {Thread.CurrentThread.Name} with Thread Id: {Thread.CurrentThread.ManagedThreadId}");

            //int x = 10;
            //Run1();
            //Run2();
            //ThreadStart

            //ThreadStart run1Delegate = new ThreadStart(OtherThreads.Run1);
            //Thread run1Thread = new Thread(run1Delegate);

            Thread run1Thread = new Thread(OtherThreads.Run1);
            run1Thread.Name = "Run1";
            run1Thread.Start(); //--> run1Delegate.Invoke(); --> Run1()

            ParameterizedThreadStart run2Delegate = new ParameterizedThreadStart(new OtherThreads().Run2);
            Thread run2Thread = new Thread(run2Delegate);
            run2Thread.Name = "Run2";
            run2Thread.Start(5);//-->run2Delegate.Invoke(5)-->Run2(5)

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main, i:{i}");
            }
        }
    }
}
