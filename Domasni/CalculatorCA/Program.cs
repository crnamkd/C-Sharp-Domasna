using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCA
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            Dictionary<int, Func<double, double, double>> MyDict =
                new Dictionary<int, Func<double, double, double>>();
            FillDictionary(MyDict);
            bool KeepOn = true;
            while (KeepOn)
            {
                int choice = ReadInput("Please choose one of the following:\n1-Add\n2-Substract\n3-Multiply\n4-Divide", 1, MyDict.Count);
                double first = ReadInput("Enter the first number :");
                double second = ReadInput("Enter the second number :");

                Console.WriteLine("The result is : {0}", MyDict[choice](first, second));


                Console.WriteLine("Continue? BEWARE: JUST PRESS !!! Y/y to continue or N/n to quit the application");

                if(KeepOn = Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.WriteLine("\n______________________________________\n______________________________________");
                    continue;
                    Console.WriteLine("");

                }
                else (KeepOn = Console.ReadKey().Key != ConsoleKey.Y)
                {
                    Console.WriteLine("   \"       ");
                    Console.WriteLine("    \" ___________ ");
                    Console.WriteLine("     |           |");
                    Console.WriteLine("     | GOOOD BYE |");
                    Console.WriteLine("     |___________|");
                    Console.ReadLine();

                }
                break;
            }
        }
        private static double ReadInput(string prompt)
        {
            Console.WriteLine(prompt);
            double userInput;
            if (double.TryParse(Console.ReadLine(), out userInput))
                return userInput;

            Console.WriteLine(" - Sorry, I expected a number, try again");
            return ReadInput(prompt);
        }

        private static int ReadInput(string prompt, int? min = null, int? max = null)
        {
            Console.WriteLine(prompt);
            int userInput;
            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                if (userInput >= min.GetValueOrDefault(int.MinValue) && userInput <= max.GetValueOrDefault(int.MaxValue))
                    return userInput;

                Console.WriteLine(" - Sorry, I expected an number, between {0} and {1}", min, max);
                return ReadInput(prompt, min, max);

            }

            Console.WriteLine(" - Sorry, I expected an number, try again");
            return ReadInput(prompt, min, max);
        }

        public static void FillDictionary(Dictionary<int, Func<double, double, double>> myDictionary)
        {
            myDictionary.Add(1, (x, y) => x + y);
            myDictionary.Add(2, (x, y) => x - y);
            myDictionary.Add(3, (x, y) => x * y);
            myDictionary.Add(4, (x, y) => x / y);
        }
    }
}