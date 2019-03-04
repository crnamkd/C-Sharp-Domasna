using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_28_2019_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter your first number: ");
            //string input = Console.ReadLine();
            //int result;
            //bool validInput = int.TryParse(input, out result);
            //int i = 1;
            //while (i<=result)
            //{

            //    Console.WriteLine(i);

            //    i++;
            //}

            //Console.WriteLine("Enter your second number: ");

            //string input2 = Console.ReadLine();
            //int result2;
            //bool validInput2 = int.TryParse(input2, out result2);

            //int j = 1;
            //while (result2 >= j) 
            //{
            //    Console.WriteLine(result2);
            //    result2--;
            //}

            // input from console
            //iterations to input number

            //not print numbers that can divide with 3 and 7
            //if 100 then print message and stop

            //Console.WriteLine("Enter your number: ");

            //int number = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= number; i++)
            //{
            //    if(i %3==0 || 1%7==0)
            //    {
            //        // Console.WriteLine(i+"+ + + +"+number);
            //        continue;
            //    }

            //    if (i == 100)
            //    {
            //        Console.WriteLine("100 and STOP");
            //        break;
            //    }

            //    Console.WriteLine(i);
            //}


            //int[] numbers = new int[5] {1,2,3,4,5};
            //numbers[0] = 10;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //var numbers = new int[] { 10, 20 };

            //var index = Array.IndexOf(numbers, 10);



            //if(index == -1)
            //{
            //    // toj element sto go baras ne e vo nizata !!!
            //}


            //Console.WriteLine(index);


            //Console.WriteLine("Enter 3 names:");
            //var names = new string[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    names[i] = Console.ReadLine();
            //}

            //var names = new string[] { "Tomas", "Monika", "C-Sharp" };

            //for (int i = 0; i < names.Length; i++)

            //{
            //    Console.WriteLine(names[i]);
            //}

            //foreach(var name in names)
            //{
            //    Console.WriteLine(name);

            //}

            //var numbers = new int[] { 100, 200, 20, 10, 300, 30 };

            //Array.Resize(ref numbers, 2); // 100 , 20

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            int counter = 0;

            while(true)
            {
                Console.WriteLine("Enter name :");



                bool exit;
                    while (true)
                    {
                    Console.WriteLine("Enter N/n for exit or Y/y to continue");
                    if (Console.ReadLine() == "N" ||
                        Console.ReadLine() == "n")
                    {
                        exit = true;
                        break;
                    }
                    else if (Console.ReadLine() == "Y" || Console.ReadLine() == "y")
                    {
                        exit = false;
                        break;
                    }

                    }

                if (exit) break;




            }
            Console.ReadLine();

        }


    }
}
