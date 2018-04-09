using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generatedTimeStamps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sisesta numbrina minimaalne aastaarv: ");
            string minInputString = Console.ReadLine();
            int minYear = Int32.Parse(minInputString);

            Console.Write("Sisesta numbrina maksimaalne aastaarv: ");
            string maxInputString = Console.ReadLine();
            int maxYear = Int32.Parse(maxInputString);

            Console.Write("Sisesta numbrina genereeritavate andmete hulk: ");
            string amountString = Console.ReadLine();
            int amount = Int32.Parse(amountString);

            List<DateTime> dates = new List<DateTime> ();

            Random random = new Random();
            DateTime start = new DateTime(minYear, 1, 1);
            DateTime end = new DateTime(maxYear, 12, 31);
            int range = (end - start).Days;

            for (var i = 0; i < amount; i++)
            {
                int rnd = random.Next(1, range);
                var generatedTime = start.AddDays(rnd);
                dates.Add(generatedTime);
            }

            Console.WriteLine();
            for (var i = 0; i < dates.Count; i++)
            {
                Console.WriteLine(dates[i].ToShortDateString());
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
