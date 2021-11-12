using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagementSystem.Entities
{
    public class Professor : Person
    {
        public Professor() { }
        public Professor(string name, int booksPublished)
            : base(name)
        {
            BooksPublished = booksPublished;
        }
        public int BooksPublished { get; set; }

        public override bool IsOutstanding()
        {
            return this.BooksPublished > 5;
        }

        public string ShowtDetail()
        {
            return $"Name: {this.Name}, Marks: {this.BooksPublished}";
        }
    }
}
