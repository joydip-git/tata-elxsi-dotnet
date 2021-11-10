using System;
using MessngerLibrary;

namespace MessengerClientApp
{
    class Program
    {
        static void Main()
        {
            Messenger messenger = new Messenger();
            Console.Write("enter name: ");
            string name = Console.ReadLine();

            string message = messenger.ShowMessage(name);
            Console.WriteLine("Message: " + message);
        }
    }
}
