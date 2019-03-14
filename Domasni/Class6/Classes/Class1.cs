using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class6.Classes
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime Birthdate;
        public string Address;
        public char mesto = ' ';

        public string GetPersonFullName()
        {
            return FirstName + mesto + LastName;
        }
        public void Hello()
        {
            //Console.WriteLine("Hello");
        }

    }
}
