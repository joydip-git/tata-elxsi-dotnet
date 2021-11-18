using System;
using System.Collections.Generic;

namespace Has_a_relationship
{
    //table schema
    class Product
    {
        public int Id { get; set; } //PK
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        //public int CategoryId { get; set; } //FK

        //association/navigational property (1-1)
        public Category Category { get; set; } //FK
    }
    class Category
    {
        public int Id { get; set; }//PK
        public string Name { get; set; }

        //navigational property (1-M)
        public List<Product> Products { get; set; }
    }

    //association (1-M/1-M)
    class Trainer
    {
        public List<Student> Students { get; set; }
    }
    class Student
    {
        public List<Trainer> Trainers { get; set; }
    }

    class Book
    {
        public HashSet<Author> Authors { get; set; }
    }
    class Author
    {
        public HashSet<Book> Books { get; set; }
    }
    class Member
    {
        public HashSet<Book> Books { get; set; }
    }
    class CatalogEntry
    {
        public Book IssuedBookInfo { get; set; }
        public Member IssuedMemberInfo { get; set; }
    }


    //composition (1-1/1-M)
    class Room
    {
        public Building Building { get; set; }
    }
    class Building
    {
        public List<Room> Rooms { get; set; }
    }

    //aggregation(1-1/1-M)
    class Laptop
    {
        public List<RAM> RAMs { get; set; }
    }
    class RAM
    {
        public Laptop Laptop { get; set; }
    }
    class Program
    {
        static void Main()
        {
            //category records
            Category mobileCategory = new Category { Id = 1, Name = "Mobliles" };
            Category laptopCategory = new Category { Id = 2, Name = "Laptops" };

            //categories table
            List<Category> categories = new List<Category> { mobileCategory, laptopCategory };

            //product record
            Product onePlusMobile = new Product { Id = 1, Name = "One Plus 8", Price = 50000, Description = "New mobole from One plus", Category = categories[0] };


            //products table
            List<Product> products = new List<Product> { onePlusMobile };
            Console.WriteLine(products[0].Category.Name);


            categories[0].Products = new List<Product> { products[0] };

            foreach (Category category in categories)
            {
                Console.WriteLine($"Category:{category.Name} ");
                Console.WriteLine("---------------------------------------");
                var productsOftheCategory = category.Products;
                if (productsOftheCategory == null || productsOftheCategory.Count == 0)
                {
                    Console.WriteLine("No products found for this category");
                }
                else
                {
                    foreach (Product product in productsOftheCategory)
                    {
                        Console.WriteLine(product.Name);
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
