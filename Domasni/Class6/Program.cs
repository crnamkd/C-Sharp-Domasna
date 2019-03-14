using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class6.Classes;



namespace Class6
{
   class Program
    {

        static void Main(string[] args)
        {
            #region exercise 1
            //int number = 10;
            //char praznoMesto = ' ';
            //var person = new Person();
            //var person1 = new Person();

            //person.FirstName = "Tomas";
            //person.LastName = "Jovanov";

            //person1.FirstName = "Jovanov";

            //person1.LastName = "Dimitar";

            //Console.WriteLine(person.FirstName + praznoMesto + person.LastName);
            //Console.WriteLine(person1.FirstName + praznoMesto + person1.LastName);

            //Console.WriteLine(person);
            //Console.WriteLine(person1);
            #endregion

            #region exercise 1.2
            //DateTime datum = new DateTime();
            //DateTime sega = DateTime.Now;
            //var person = new Person();
            //person.FirstName = Console.ReadLine();
            //person.LastName = Console.ReadLine();
            //person.GetPersonFullName();

            //Console.WriteLine(person.GetPersonFullName());
            #endregion

            #region exercise 2
            //var human = new Human();
            //human.FirstName = Console.ReadLine();
            //human.LastName = Console.ReadLine();
            //human.age = int.Parse(Console.ReadLine());

            //Console.WriteLine(human.GetPersonInfo());
            //Console.ReadLine();
            #endregion

            #region Exercise 3
            //var student = new Student();
            //student.firstName = Console.ReadLine();
            //student.lastName = Console.ReadLine();
            //student.Academy = "Web-Development";
            //student.Group = "5G";
            //int counter = 0;

            //var storred = student[];
            //var input = Console.ReadLine();
            //do
            //{
            //    while (input = storred)
            //    {
            //        Console.WriteLine("error, name not found try again :");

            //    };
            //    return storred;
            //};


            Student[] arrStudents = new Student[]
            {
                new Student("Bob", "G5", "Web Development"),
                new Student("Bob", "G3", "Network"),
                new Student("Bob", "G9", "Design"),
                new Student("Bob", "G5", "Web Development"),
                new Student("Bob", "G3", "Network"),


            };
            Console.WriteLine("Enter student name: ");
            string studentName = Console.ReadLine();
            findStudent(arrStudents, studentName);
            #endregion
        }
    }
}
