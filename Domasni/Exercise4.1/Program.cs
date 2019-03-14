using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise4._1.Classes;
namespace Exercise4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Za login stisnete 1 ili za register 2");
            var input = Console.ReadLine();
            bool op = false;
            while (!op)

            if (input == "1")
            {
                Users.Login();
                    if (!op)
                    {
                        Console.WriteLine("Your username or password is incorect, try again !!!");
                    }
                }
            else if (input == "2")
            {
                Users.Register();
                    if (!op)
                    {
                        Console.WriteLine("Your username or password is incorect, try again !!!");
                    }
                    continue;
            }
            else
            {
                Console.WriteLine("Try Again");
                    break;
            }
        }
    }
}
