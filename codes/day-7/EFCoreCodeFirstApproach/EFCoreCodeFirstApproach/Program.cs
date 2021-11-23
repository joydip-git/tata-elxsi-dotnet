using System;
using EFCoreCodeFirstApproach.Models;

namespace EFCoreCodeFirstApproach
{
    class Program
    {
        static void Main()
        {
            LibraryDbContext db = new LibraryDbContext();
            db.Books.Add(new Book { Name = "Pillars of the earth" });
            db.Members.Add(new Member { Name = "anil" });
            int rows = db.SaveChanges();
            Console.WriteLine(rows);
        }
    }
}
