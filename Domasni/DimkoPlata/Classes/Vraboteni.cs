using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.Classes
{
    public class Vraboteni
    {
        public string imePrezime;
        public int plataFiks;
        public double totalSum = double.Parse(Console.ReadLine());
        public int a;
        public int b;
        double plataSum = totalSum / 3.04;
        double koeficient = plataSum / 18;
        public double Toni = 1.85;
        public double Igor = 2.2;

        public Vraboteni(string ime, int plata)
        {
            imePrezime = ime;
            plataFiks = plata;
        }


        public double MestenjePlata()
        {

        }
        public double PlataToni()
        {
            return koeficient * Toni;
        }
    }
}
