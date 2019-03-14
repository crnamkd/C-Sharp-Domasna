using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketApp.Classes;
namespace DimkoPlata
{
    public class Program
    {
        public string imePrezime;
        public int plataFiks;
        public double totalSum = double.Parse(Console.ReadLine());

        public double plataSum;
        plataSum = totalSum / 3.04;
        public double koeficient = plataSum / 18;
        public double Toni = 1.85;
        public double Igor = 2.2;
        
        
        public double PlataToni()
        {
            return koeficient * Toni;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi Total Suma: ");
            var input = Console.ReadLine();
            Console.WriteLine(koeficient*Toni);
        }
    }
}
