namespace StaticDemo
{
    class Employee
    {
        static Employee()
        {
            System.Console.WriteLine("static ctor");
            JoiningBonus = 4000;
        }

        public Employee() { }
        public Employee(int id, string name, decimal basic, decimal da, decimal hra)
        {
            System.Console.WriteLine("parameterized ctor");
            Id = id;
            Name = name;
            Basic = basic;
            Da = da;
            Hra = hra;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public decimal Da { get; set; }
        public decimal Hra { get; set; }

        //private static decimal joiningBonus = 4000; //field initialization
        //public static decimal JoiningBonus { get => joiningBonus; }

        //or
        //public static decimal JoiningBonus { get; } = 4000;

        //or (use static ctor to set the Joining Bonus)
        public static decimal JoiningBonus { get; }

        public decimal TotalSalary { get; private set; }

        public void CalculateSalary()
        {
            TotalSalary = Basic + Da + Hra + JoiningBonus;
        }
    }

    class Developer : Employee
    {
        public Developer() { }
    }
}
