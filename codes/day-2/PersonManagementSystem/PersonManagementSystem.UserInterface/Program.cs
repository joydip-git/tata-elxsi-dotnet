using System;
using PersonManagementSystem.Entities;

namespace PersonManagementSystem.UserInterface
{
    class Program
    {
        static void Main()
        {
            Person arunPersonObjRef = null;
            arunPersonObjRef = new Person("arun", "arun@gmail.com", 9090909090, "hyderabad");

            Person sakshamPersonObjRef = new Person("saksham", "saksham@gmail.com", 9090909091, "agra");
            string informationOfArun = arunPersonObjRef.GetInformation();
            Console.WriteLine(informationOfArun);
            string informationOfSaksham = sakshamPersonObjRef.GetInformation();
            Console.WriteLine(informationOfSaksham);

            //Console.WriteLine(sakshamPersonObjRef.GetMobileNumber());
            Console.WriteLine(sakshamPersonObjRef.MobileNumber);

            //sakshamPersonObjRef.SetMobileNumber(9090919293);
            //sakshamPersonObjRef.MobileNumber = 9090919293;

            //Console.WriteLine(sakshamPersonObjRef.GetMobileNumber());
            Console.WriteLine(sakshamPersonObjRef.MobileNumber);

            Person vinayaPersonObjRef = new Person();
            vinayaPersonObjRef.Name = "Vinaya P V";
            vinayaPersonObjRef.EmailId = "vinaya@gmail.com";
            vinayaPersonObjRef.MobileNumber = 9191919191;
            vinayaPersonObjRef.Location = "Chennai";

            Console.WriteLine(vinayaPersonObjRef.Name);

            //Person vimalPersonObjRef = new Person("Vimal Belawal", "vimal@gmail.com", 9292929292, "Mumbai");
            Person vimalPersonObjRef = new Person
            {
                Name = "Vimal Belawal",
                EmailId = "vimal@gmail.com",
                MobileNumber = 9292929292,
                Location = "Mumbai"
            };
        }
    }
}
