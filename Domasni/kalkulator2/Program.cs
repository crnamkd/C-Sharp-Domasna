using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double number1 = GetNumber();
                Console.Clear();
                Console.WriteLine(number1);
                Console.WriteLine();
                string action = GetAction();
                double number2 = GetNumber();
                Console.WriteLine(number2);
                double result = Perform(number1, action, number2);
                Console.Clear();
                Console.WriteLine(number1 + action + number2);
                Console.WriteLine();
                Console.WriteLine("The result is " + " = " + result);
                Console.Write("Press enter to calculate again: ");
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static double GetNumber()
        {
            double number;

            Console.Write("Enter Number: ");
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                NumberInputError();
            }

            return number;
        }

        private static void NumberInputError()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Wrong sort of input.");
            Console.Write("Enter a number: ");
        }

        private static string GetAction()
        {
            while (true)
            {
                Console.Write("Enter operator: ");
                string action = Console.ReadLine();
                Console.Clear();
                if ((action == "*") || (action == "/") || (action == "-") || (action == "+"))
                {
                    return action;
                }

                Console.WriteLine("False action input, choose between: / ; * ; - ; +");
            }
        }

        private static double Perform(double number1, string action, double number2)
        {
            switch (action)
            {
                case "+": return number1 + number2;
                case "-": return number1 - number2;
                case "*": return number1 * number2;
                case "/": return number1 / number2;
                default: throw new InvalidOperationException("False action input, choose between: / ; * ; - ; +");
            }
        }
    }
}