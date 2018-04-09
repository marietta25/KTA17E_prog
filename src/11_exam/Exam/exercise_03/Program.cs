using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vastavalt etteantud andmetele prindin välja timestampe");
            Console.WriteLine();

            Console.Write("Sisesta numbrina minimaalne aastaarv: ");
            string minInputString = Console.ReadLine();
            int minYear = Int32.Parse(minInputString);

            Console.Write("Sisesta numbrina maksimaalne aastaarv: ");
            string maxInputString = Console.ReadLine();
            int maxYear = Int32.Parse(maxInputString);

            Console.Write("Sisesta numbrina genereeritavate andmete hulk: ");
            string amountString = Console.ReadLine();
            int amount = Int32.Parse(amountString);

            List<DateTime> dates = new List<DateTime>();

            Random random = new Random();
            DateTime start = new DateTime(minYear, 1, 1, 0, 0, 0);
            DateTime end = new DateTime(maxYear, 12, 31, 0, 0, 0);
            int range = (end - start).Days;

            for (var i = 0; i < amount; i++)
            {
                int rndDays = random.Next(1, range);
                int rndHour = random.Next(0, 23);
                int rndMinute = random.Next(0, 59);
                int rndSecond = random.Next(0, 59);
                var generatedTime = start.AddDays(rndDays).AddHours(rndHour).AddMinutes(rndMinute).AddSeconds(rndSecond);
                dates.Add(generatedTime);
            }

            Console.WriteLine();
            for (var i = 0; i < dates.Count; i++)
            {
                Console.WriteLine(dates[i].ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
