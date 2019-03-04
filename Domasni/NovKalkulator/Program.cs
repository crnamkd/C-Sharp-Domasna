using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovKalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "x";

            int convertor;
            bool result = int.TryParse(input, out convertor);
            if(result)
            {
                Console.WriteLine("Vnesi broj");
                return;
            }
            else
            {
                Console.WriteLine("Enter your first number: ");
                int result1;
                string input1;
                bool num1 = int.TryParse(input1, out result1);

                Console.WriteLine("Enter your second number: ");
                int result2;
                string input2;
                bool num2 = int.TryParse(input2, out result2);
                Console.WriteLine("Enter operator");
                string op = Console.ReadLine();
                bool switchStatement = true;
                if (switchStatement = true)
                {
                    switch (op)
                    {

                        case "+":
                            Console.WriteLine(num1+num2);

                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            result = num1 / num2;
                            break;
                        case "%":
                            result = num1 % num2;
                            break;
                        case "text":

                            break;
                        default:
                            Console.WriteLine("Invalid Operator");
                            break;

                    }
                    return;

                    Console.WriteLine("Result = " + result);
                    Console.ReadLine();

                }
            }
            Console.ReadLine();
        }
    }
}
