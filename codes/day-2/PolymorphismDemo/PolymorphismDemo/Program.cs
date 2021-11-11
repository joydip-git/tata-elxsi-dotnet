using System;

namespace PolymorphismDemo
{
    class Addition
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Add(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);
        }
        public void Add(int x, int y, long z)
        {
            Console.WriteLine(x + y + z);
        }
        public void Add(int x, long y, int z)
        {
            Console.WriteLine(x + y + z);
        }
    }

    class Person
    {
        string name;
        public Person() { }
        public Person(string name)
        {
            this.name = name;
        }
        public virtual string GetInformation()
        {
            return this.name;
        }
    }

    class Trainer : Person
    {
        string subject;
        public Trainer() { }
        public Trainer(string name, string subject)
            : base(name)
        {
            this.subject = subject;
        }
        /*
         *  
        public string GetInformation()
        {
            return this.name;
        }
         */
        public override string GetInformation()
        {
            string partialInformation = base.GetInformation();
            return partialInformation + " " + this.subject;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //string str1 = "bangalore";
            //string str2 = "railway";
            //Console.WriteLine(str1 + str2);

            //Addition addition = new Addition();
            //addition.Add(10, 20);

            //upcasting (creating object of child class, and storing the address in variable of base class)
            Person trainer = new Trainer("joy", ".net");
            string info = trainer.GetInformation();
            Console.WriteLine(info);
        }
    }
}
