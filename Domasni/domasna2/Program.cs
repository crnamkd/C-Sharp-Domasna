using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float result = 0f;
            bool badValue = true;
            string text;
            


            Console.WriteLine("Enter your first number: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator");
            string op = Console.ReadLine();
            bool switchStatement = true;
            if (switchStatement = true )
            { 
            switch (op)
            {

                case "+":
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
           
            
            Console.WriteLine("Result = " + result);
            Console.ReadLine();

        }
        else
            {
                Console.WriteLine("You have not entered a number, please try again !");
                Console.ReadLine();
                
            };
            

            //----------------------------------------------------------------------------------------

            /*
            float number2;

            Console.WriteLine("Enter your first number: ");
            bool num1 = float.TryParse(Console.ReadLine(), out number2);
            float result2;
            string input1 = "input";
            Console.WriteLine("Enter your second number: ");
            bool num2 = int.TryParse(input1, out result2);
            string input = Console.ReadLine();

            int result;
            bool validInput = int.TryParse(input, out result);
            while(validInput == true)
            if (int.TryParse(input, out result))
            {
                Console.WriteLine("the number was : " + result);
                    switch (op)
                    {

                        case "+":
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
                }
            else
            {
                Console.WriteLine("Not a number");

            }
            Console.ReadLine();
            */
        }
    }

}
