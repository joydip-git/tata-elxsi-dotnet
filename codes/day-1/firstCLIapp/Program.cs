using System;
using MessngerLibrary;

namespace firstCLIapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Messenger messenger = new Messenger();
            Console.WriteLine(messenger.ShowMessage("joydip"));
        }
    }
}
