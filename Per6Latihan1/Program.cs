using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Per6Latihan1
{
    class Program
    {
        static void Main(string[] args)
        {
            // AKSES NAMA DARI CONTACT
            Contact c = new Contact();
            c.Name = "Robi";
            Console.WriteLine(c.Name);

            // TRY TO ACCES PRIVATE FIELD
            // ERROR : 'Per6Latihan1.PdaItem.Age' is inaccessible due to its protection level
            // c.Age = 1;

            // TRY TO ACCES PROTECTED FIELD
            // ERROR : 'Per6Latihan1.PdaItem.ZipCode' is inaccessible due to its protection level
            // c.ZipCode = 1;

            // AKSES NAMA DARI APPOINTMENT
            Appointment app = new Appointment();
            app.Name = "Tanzil";
            Console.WriteLine(app.Name);

            // AKSES NAMA DARI CUSTOMER
            Customer cus = new Customer();
            cus.Name = "Ganefi";
            Console.WriteLine(cus.Name);

            Console.ReadLine();

        }
    }
}
