using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise4.Classes;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrUsers = new Users[]
            {
            new Users("tomas","samsung",2605),
            new Users("stefan","pasle",15),
            new Users("dimitar","jovanov",32)
            };

            Start:
            Console.WriteLine("Za login stisnete 1 ili za register 2");
            var input = Console.ReadLine();
            bool successfull = false;
            while (!successfull)
            {

                if (input == "1")
                {
                    Console.WriteLine("Write your username:");
                    var username = Console.ReadLine();
                    Console.WriteLine("Enter your password:");
                    var password = Console.ReadLine();
                    string name = username.Trim();
                    string name2 = password.Trim();
                    foreach (Users user in arrUsers)
                    {
                        if (name == user.username && name2 == user.password)
                        {
                            Console.WriteLine("You have successfully logged in !!!");
                            Console.ReadLine();
                            successfull = true;
                            break;
                        }
                    }
                    if (!successfull)
                    {
                        Console.WriteLine("Your username or password is incorect, try again !!!");
                    }
                }
                else if (input == "2")
                {
                    Console.WriteLine("Enter your username:");
                    var username = Console.ReadLine();
                    Console.WriteLine("Enter your password:");
                    var password = Console.ReadLine();
                    Console.WriteLine("Enter your id:");
                    int id = int.Parse(Console.ReadLine());
                    Array.Resize(ref arrUsers, arrUsers.Length + 1);
                    arrUsers[arrUsers.Length - 1] = new Users(username.Trim(), password.Trim(), id);
                    successfull = true;
                    goto Start;
                }
                else
                {
                    Console.WriteLine("Try again !!!");
                    goto Start;
                }
            }
        }
    }
}