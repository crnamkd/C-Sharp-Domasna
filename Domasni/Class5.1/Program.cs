using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5._1
{
    class Program
    {
        static void AgeCalulator(int inputYear)
        {
            var currentYear = DateTime.Now.Year;
            var currentMonth = DateTime.Now.Month;
             
            int age = currentYear - inputYear;

            //var input = int.Parse(Console.ReadLine());


            //var date1 = DateTime.Now.Year;

            //var result = date1 - inputYear;

            //AgeCalulator(input);
            //Console.ReadLine();

        }



        static void Main(string[] args)
        {
            
            //---> String Builder

            //var newString = new StringBuilder("Some String");

            //newString.Append("\ntext");

            //string something = "tomas jovanov\n";

            //var upper = something.ToUpper();
            //var lower = something.ToLower();

            //Console.WriteLine(upper);
            //Console.WriteLine(lower);

            //var date1 = DateTime.Now.AddDays(3);
            //var date2 = DateTime.Now.AddMonths(1);
            //var date3 = DateTime.Now.AddMonths(1).AddDays(3);
            //var date4 = DateTime.Now.AddYears(1).AddMonths(2);
            //var date5 = DateTime.Now.Month;
            //var date6 = DateTime.Now.Year;


            //var currentDateTime = DateTime.Now;
            //var normal = currentDateTime.ToString();


            //Console.WriteLine(String.Format("MM/dd/yyyy",normal));

            //Console.WriteLine(date1);
            //Console.WriteLine(date2);
            //Console.WriteLine(date3);
            //Console.WriteLine(date4);
            //Console.WriteLine(date5);
            //Console.WriteLine(date6);


            //var inputYear = int.Parse(Console.ReadLine());
            //var date1 = DateTime.Now.Year;

            //var result = date1 - inputYear;

            //Console.WriteLine(inputYear);
            //Console.WriteLine(result);
            //Console.WriteLine("You have :" + result + "years");
            //Console.ReadLine();
        }
    }
}
