using PersonManagementSystem.Entities;
using static System.Console;

namespace PersonManagementSystem.UserInterface
{
    static class UserInterfaceUtility
    {
        public static int GetCount()
        {
            Write("How many records? ");
            return int.Parse(ReadLine());
        }

        public static void PrintOpions()
        {
            WriteLine("\n1. Create Professor");
            WriteLine("2. Create Student");
        }

        public static int GetChoice()
        {
            Write("Enter Choice[1/2]: ");
            return int.Parse(ReadLine());
        }

        public static Person CreatePerson(int choice)
        {
            Person person = null;

            Write("\nName: ");
            string name = ReadLine();

            switch (choice)
            {
                case 1:

                    Write("Books published: ");
                    int books = int.Parse(ReadLine());

                    person = new Professor(name, books);
                    break;

                case 2:

                    Write("Marks: ");
                    double marks = double.Parse(ReadLine());

                    person = new Student(name, marks);
                    break;

                default:
                    WriteLine("\nEnter proper choice...");
                    break;
            }
            return person;
        }

        public static void PrintOutstandingPerson(Person[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                Person person = people[i];
                if (person.IsOutstanding())
                {
                    if (person is Professor)
                    {
                        Professor professor = person as Professor;
                        WriteLine($"\n{professor.ShowtDetail()}");
                    }
                    if (person is Student)
                    {
                        Student student = person as Student;
                        WriteLine($"\n{student.PrintDetail()}");
                    }
                }
            }
        }
    }
}
