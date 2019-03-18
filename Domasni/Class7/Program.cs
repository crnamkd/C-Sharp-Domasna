using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary
            Dictionary<string, int> statuses = new Dictionary<string, int>();
            statuses.Add("Tomas", 45);
            statuses.Add("Hello", 60);
            statuses.Add("Vlado", 95);
            bool baremPolozen = statuses.ContainsValue(50);
            foreach (var pair in statuses)
            {
                if (pair.Value > 50)
                { Console.WriteLine(pair.Key + " have passed !"); }
            }
            #endregion

            #region List
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(100);
            numbers.Add(50);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Queue

            Queue<string> daPrasamNesto = new Queue<string>();

            daPrasamNesto.Enqueue("Vlado");
            daPrasamNesto.Enqueue("Andrea");
            daPrasamNesto.Enqueue("Ivan");

            Console.WriteLine("Site sto cekaat red se : \n");
            foreach (var item in daPrasamNesto)
            {
                Console.WriteLine(item);
            }

            string first = daPrasamNesto.Dequeue();

            Console.WriteLine("Prv vo redot bese:" + first);

            foreach (var person in daPrasamNesto)
            {
                Console.WriteLine("Ostanite se : \n" + person);
            }

            #endregion

            #region Stack

            Stack<string> people = new Stack<string>();




            Console.WriteLine("POP za cao: ");
            var koj = people.Pop();
            Console.WriteLine($"Si zaminuva {} :");
            foreach (var person in people)
            {

            }

            #endregion
        }
    }
}
