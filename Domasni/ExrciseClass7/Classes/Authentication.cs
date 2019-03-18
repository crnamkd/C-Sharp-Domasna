using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExrciseClass7.Classes
{
    class Authentication
    {
        private static Person FindUser(Person[] persons, string name)
        {
            foreach (Person person in persons)
            {
                if (person.FirstName.ToLower() == name.ToLower()) return person;
            }
            return null;
        }

        public static void Login(Person[] persons, string name)
        {
            Person person = FindUser(persons, name);

            if (person == null)
            {
                Console.WriteLine("User not found!");
                return;
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine($"Welcome {person.FirstName}!");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Your messages:");

            

            Console.WriteLine("-------------------------");
        }

        public static void Register(Person[] persons, string name, string password, int id)
        {
            Person person = FindUser(persons, name);
            if (person != null)
            {
                Console.WriteLine("User already exists!");
                return;
            }
            

            Console.WriteLine("-------------------------");
        }

    }
}
