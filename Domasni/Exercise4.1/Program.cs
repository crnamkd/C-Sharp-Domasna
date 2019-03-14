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
            var arrUsers = new Users[]
            {
            new Users("tomas","samsung",2605),
            new Users("stefan","pasle",15),
            new Users("dimitar","jovanov",32)
            };
            Console.WriteLine("Za login stisnete 1 ili za register 2");
            var input = Console.ReadLine();
            bool successfull = false;
        }
    }
}
