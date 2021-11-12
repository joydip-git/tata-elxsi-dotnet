namespace PersonManagementSystem.Entities
{
    public class Student:Person
    {
        public Student() { }
        public Student(string name, double marksObtained)
            :base(name)
        {
            MarksObtained = marksObtained;
        }
        public double MarksObtained { get; set; }

        public override bool IsOutstanding()
        {
            return this.MarksObtained > 85 ? true : false;
        }

        public string PrintDetail()
        {
            return $"Name: {this.Name}, Marks: {this.MarksObtained}";
        }        
    }
}
