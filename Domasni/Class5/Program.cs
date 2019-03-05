using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Class5
{
    
    
    class Program
    {
        // <returnType> <name> <inputArguments>
        
        //static int Sum(int number1, int number2)
        //{
        //    int result;
        //    result = number1 + number2;
        //    return result;
        //}
        //static double Subtract(double number1, double number2)
        //{
        //    double result;
        //    result = number1 - number2;
        //    return result;
        //}

        

        static void Main(string[] args)
        {
            #region Class5
            //Console.WriteLine("Enter your first number:");
            //int input1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your second number");
            //int input2 = int.Parse(Console.ReadLine());

            //var result1 = Sum(input1, input2);
            //double result2 = Subtract(20, 10);
            //Console.WriteLine(result1);
            //Console.ReadLine();


            //string firstName = "Tomas";
            //string lastName = "Jovanov";

            /* --------------------------- Konkatanacija(spojuvanje) na stringovi --------------------------- */

            ////string fullName = firstName + lastName; //---> 

            ////string fullName = string.Format("{0} {1}", firstName, lastName);  //---> 

            //string fullName = $"{firstName} {lastName}";  //---> Interpolacija

            //Console.WriteLine(fullName);
            //Console.ReadLine();

            //string anotherString1 = @"Check your c:\ drive :";
            //string anotherString2 = @"We will have ""Fair"" elections";
            //string anotherString3 = "The \\n means: \nnew line";
            //Console.WriteLine(anotherString1);
            //Console.WriteLine(anotherString2);
            //Console.WriteLine(anotherString3);
            //Console.ReadLine();\


            #endregion

            //double someValue = 130.66666;

            //string someString = string.Format("{0:P}", someValue);

            //string username = "Tomas Jovanov";
            //string password = "1234 ";
            //string trimmed = password.Trim();
            //var name = username.Substring(0);

            //int length = username.Trim().Length;

            //if (password.Trim() != "1234")
            //{
            //    Console.WriteLine("Invalid Password");
            //    Console.ReadLine();

            //    return;
            //}

            //Console.WriteLine("Entered:" + name );


            //string username = "Zdravo jas sum Tomas Jovanov";
            //var words = username.Split(' ');
            //foreach(var word in words)
            //{
            //    Console.WriteLine(word);
            //}

            //string arrayTest = "1,2,100,50,6,8";

            //var arrayInt = arrayTest.Split(',');

            string testString = "Tomas uci da programira";
            var result = testString.IndexOf("m");



            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
