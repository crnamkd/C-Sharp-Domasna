using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6.Classes
{
    public class Human
    {
        public string FirstName;
        public string LastName;
        public int age;
        public char mesto = ' ';

        

        public string GetPersonInfo()
        {
            Console.WriteLine("Hello");

            return FirstName + mesto + LastName + mesto + age;
        }
    }


    
}
