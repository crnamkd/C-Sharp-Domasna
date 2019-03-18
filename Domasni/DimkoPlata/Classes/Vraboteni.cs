using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.Classes
{
    public class Vraboteni
    {
        public string Name { get; set; }
        public double PlataSum { get; set; }
        private double Koeficient { get; set; }
        public string[] Message { get; set; }
        public double TotalSum { get; set; }
        public double Toni = 1.85;
        public double Igor = 2.2;

        public Vraboteni(string name, double plataSum, double koeficient, double totalSum)
        {
            Name = name;
            PlataSum = plataSum;

            plataSum = totalSum / 3.04;

            TotalSum = totalSum;

            Koeficient = koeficient;
            koeficient = plataSum / 18;
        }


       public void MSG()
        {
            Console.WriteLine("Delenje Plata : ");
        }

        public double PlataToni()
        {
            return Koeficient * Toni;
        }
    }
}
