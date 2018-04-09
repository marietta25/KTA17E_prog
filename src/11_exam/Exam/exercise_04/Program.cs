using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vastavalt eelnevalt defineeritud timestampidele väljastan järgmised andmed: ");
            Console.WriteLine();

            DateTime now = DateTime.Today;

            string[] dates = {"14.01.1956 04:34:22", "17.03.1986 23:05:18", "25.06.1987 13:45:02", "06.03.1986 19:06:37", "22.11.1973 06:28:21", "03.10.1990 08:32:10", "08.05.2002 11:04:34",
            "09.09.1959 14:06:57","15.08.1971 10:54:31","02.07.1976 02:44:12","13.07.1960 21:17:19","30.12.1997 00:27:03","02.04.2000 15:50:05","19.03.1956 20:07:30","11.08.1982 19:38:37",
            "16.02.1978 01:42:33","18.12.1965 05:16:13","23.05.1951 16:21:43","28.09.1961 18:04:48","09.10.1993 10:14:12","26.06.2006 19:53:29","05.11.1970 06:17:27","04.02.1994 13:33:18",
            "22.01.1980 22:49:04","29.07.1965 23:03:58","24.12.1959 12:17:24","16.10.1977 21:38:32","15.04.1997 19:55:02","20.08.2001 10:21:43","08.09.1982 15:39:45","10.03.1981 20:17:37",
            "01.11.1957 23:54:05","23.01.1964 03:30:24"};

            List<DateTime> birthdays = new List<DateTime> { };

            for (int i = 0; i < dates.Length; i++)
            {
                DateTime newDate = DateTime.ParseExact(dates[i], "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                birthdays.Add(newDate);
            }

            // max vanus
            List<int> ages = new List<int> { };

            foreach (var item in birthdays)
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
            Month monthClass = new Month();

            var pair = monthClass.findMonth(birthdays);
            Console.WriteLine($"Kõige rohkem sünnipäevi ({pair.Value}) esineb {pair.Key}. kuul");
            Console.WriteLine();


            // kõik sorteeritud kasvavas järjekorras
            // list -> array
            DateTime[] dateArray = birthdays.ToArray();

            Array.Sort(dateArray);
            Console.WriteLine("Kõik kuupäevad sorteerituna kasvavas järjekorras: ");
            foreach (var item in dateArray)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
