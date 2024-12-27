using ConsoleAppCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCs
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel("Dizioglu");

            person.FirstName = "Ahmet";
            //person.LastName = "Dizioglu";
            person.Age = 40;
            person.SSN = "123-45-6789";

            Console.WriteLine(person.FullName);
            Console.WriteLine(person.SSN);

            Console.ReadLine();
        }
    }
}
