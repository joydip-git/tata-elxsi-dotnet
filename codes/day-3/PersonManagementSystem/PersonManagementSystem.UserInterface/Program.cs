using System;
using PersonManagementSystem.Entities;
using static PersonManagementSystem.UserInterface.UserInterfaceUtility;

namespace PersonManagementSystem.UserInterface
{
    class Program
    {
        static void Main()
        {
            int count = GetCount();
            Person[] people = new Person[count];

            for (int i = 0; i < count; i++)
            {
                PrintOpions();
                int choice = GetChoice();
                Person person = CreatePerson(choice);
                people[i] = person;
            }

            PrintOutstandingPerson(people);
        }
    }
}
