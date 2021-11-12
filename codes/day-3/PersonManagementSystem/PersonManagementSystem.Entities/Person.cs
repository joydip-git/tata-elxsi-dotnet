namespace PersonManagementSystem.Entities
{
    public abstract class Person
    {
        public Person() { }
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        //public virtual void Foo() { }

        public abstract bool IsOutstanding();       
    }
}
