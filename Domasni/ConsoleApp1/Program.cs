using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//********************************************************
// GENERIC COLLECTIONS
//********************************************************


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> PhoneBook = new Dictionary<string, int>();
            PhoneBook.Add("Tomas", 077100000);
            PhoneBook.Add("Ivan", 077223000);
            PhoneBook.Add("Vlado", 07730000);
            PhoneBook.Add("Dimo", 07740000);
            PhoneBook.Add("Elena", 07750000);
            Console.WriteLine("Enter Name to search: ");
            string name = Console.ReadLine();
            if(!PhoneBook.ContainsKey(name))
            {
                Console.WriteLine("Ne postoi");
                Console.ReadLine();
                return;
            }
            Console.WriteLine($"Postoi :\n{name} : 0{PhoneBook[name]} ");
            Console.ReadLine();
        }
    }
}
