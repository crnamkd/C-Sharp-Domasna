using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Povtoruvanje.Classes;


namespace Povtoruvanje
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Human person = new Human()
            {
                firstName = Console.ReadLine(),
                lastName = Console.ReadLine(),

            };
            //person.firstName = Console.ReadLine();
            //person.lastName = Console.ReadLine();


            var product = new Product();



            Console.WriteLine($"FirstName: {person.firstName}\n LastName: {person.lastName}");
            Console.ReadLine();
        }
    }
}
