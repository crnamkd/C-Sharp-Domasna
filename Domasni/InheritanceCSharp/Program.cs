using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClasses;

namespace InheritanceCSharp
{
    public class Animal // Parent/Base Class
    {
        public int NumberOfLegs { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }


        public void Hello()
        {
            Console.WriteLine($"Hello from {Name} i have {NumberOfLegs} legs");

        }
        public Animal()
        {
            Console.WriteLine("I`m default constructor from Animal Class");
        }
        public virtual void Eat()
        {
            Console.WriteLine("Eating....");
        }
    }
    public class Dog : Animal
    {
        public string Rasa { get; set; }
        public void Bark()
        {
            Console.WriteLine("Af, Af");
        }
        public Dog()
        {
            Console.WriteLine("I`m default constructor from Dog Class");
        }
    }
    public class Cat : Animal
    {
        public string Lazyness { get; set; }
        public void Meow()
        {
            Console.WriteLine("Meow...");
        }

        public override void Eat()
        {
            Console.WriteLine("Eating Fish..");
        }

    }
    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {


            Employee[] employee = new Employee[]
            {
            new Employee("Tomas","Jovanov", 2500),
            new Employee("Dimitar","Jovanov", 25000)
            };

            var input = Console.ReadLine();
            




            Console.ReadLine();
        }
    }
}
