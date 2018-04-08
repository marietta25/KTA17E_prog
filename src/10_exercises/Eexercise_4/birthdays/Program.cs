using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birthdays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Today;

            string[] dates = {"14.01.1956", "17.03.1986", "25.06.1987", "06.03.1986", "22.11.1973", "03.10.1990", "08.05.2002",
            "09.09.1959","15.08.1971","02.07.1976","13.07.1960","30.12.1997","02.04.2000","19.03.1956","11.08.1982","16.02.1978",
            "18.12.1965","23.05.1951","28.09.1961","09.10.1993","26.06.2006","05.11.1970","04.02.1994","22.01.1980","29.07.1965",
            "24.12.1959","16.10.1977","15.04.1997","20.08.2001","08.09.1982","10.03.1981","01.11.1957","23.01.1964"};

            //DateTime[] birthdays = new DateTime[33];
            List<DateTime> birthdays = new List<DateTime> { };

            for (int i = 0; i < dates.Length; i++)
            {
                DateTime newDate = DateTime.ParseExact(dates[i], "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                birthdays.Add(newDate);
            }

            DateTime[] dateArray = birthdays.ToArray();

            // max vanus
            List<int> ages = new List<int> { };

            foreach (var item in dateArray)
            {
                var age = now.Year - item.Year;
                ages.Add(age);
            }
            int[] agesArray = ages.ToArray();
            Console.WriteLine($"Maksimaalne vanus: {agesArray.Max()}");
            Console.WriteLine();

            // keskmine vanus aastates
            double avg = Math.Round(agesArray.Average(), 0);
            Console.WriteLine($"Keskmine vanus: {avg}");
            Console.WriteLine();

            // min vanus
            Console.WriteLine($"Minimaalne vanus: {agesArray.Min()}");
            Console.WriteLine();

            // millisel kuul kõige rohkem sünnipäevi
            List<int> months = new List<int> { };

            foreach (var item in dateArray)
            {
                var month = item.Month;
                months.Add(month);
            }

            /* var dictionary = new Dictionary<int, int>();

            var g = months.GroupBy(i => i);
            foreach (var item in g)
            {
                dictionary.Add(item.Key, item.Count());
            }

            var Min = dictionary.Select(k => dictionary[k]).Max();
            Console.WriteLine(dictionary.Max());

            //Console.WriteLine($"Kõige rohkem sünnipäevi ({item.Key}) esineb {item.Count()}. kuul");
            Console.WriteLine(); */


            // kõik sorteeritud kasvavas järjekorras
            Array.Sort(dateArray);
            foreach (var item in dateArray)
            {
                Console.WriteLine(item.ToShortDateString());
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
