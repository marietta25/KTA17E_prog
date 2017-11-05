using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programm küsib kasutajalt sünnikuu ja -päeva, kontrollib sisendit ning vastavalt sellele annab väljundi.
            // Kui kasutajal on sünnipäev, avab programm brauseriakna ja mängib sünnipäevatervituse.
            DateTime today = DateTime.Today;
            
            Console.WriteLine("Sünnipäevamäng");

            bool invalidMonth = true;
            string month = string.Empty;
            while (invalidMonth)
            {
                Console.WriteLine();
                Console.Write("Sisesta sünnikuu numbritena: ");
                month = Console.ReadLine();
                bool digits = month.All(char.IsDigit);

                if (digits)
                {
                    int monthNum = int.Parse(month);
                    if (monthNum > 12 || monthNum < 1)
                    {
                        Console.WriteLine("Palun sisesta kuu numbritena (1-12)");
                        invalidMonth = true;
                    } else
                    {
                        invalidMonth = false;
                    }
                }
                if (!digits)
                {
                    Console.WriteLine("Palun sisesta kuu numbritena (1-12)");
                    invalidMonth = true;
                }
            }
            bool invalidDay = true;
            string day = string.Empty;
            while (invalidDay)
            {
                Console.WriteLine();
                Console.Write("Sisesta sünnikuupäev: ");
                day = Console.ReadLine();
                bool digits = day.All(char.IsDigit);

                if (digits)
                {
                    int dayNum = int.Parse(day);
                    if (dayNum > 31 || dayNum < 1)
                    {
                        Console.WriteLine("Palun sisesta päev numbritena (1-31)");
                        invalidDay = true;
                    } else
                    {
                        invalidDay = false;
                    }
                }
                if (!digits)
                {
                    Console.WriteLine("Palun sisesta päev numbritena (1-31)");
                    invalidDay = true;
                }
            }

            string birthday = day + "/" + month;
            DateTime birth = DateTime.Parse(birthday);

            if (birth.Day == today.Day && birth.Month == today.Month)
            {
                Console.WriteLine("Sul on täna sünnipäev! Palju õnne!");
                Console.WriteLine("Kohe mängin sulle sünnipäevaloo ka!");
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=WieMOIejIUY");
            }
            else if (birth.Month == today.Month && birth.Day > today.Day)
            {
                Console.WriteLine("Sa on varsti sünnipäev tulemas - hakka kinginimekirja koostama!");
            }
            else if (birth.Month == today.Month && birth.Day < today.Day)
            {
                Console.WriteLine("Sul oli äsja sünnipäev - palju õnne tagantjärgi!");
            }
            else
            {
                Console.WriteLine("Oota veel natuke, varsti saad jälle aasta vanemaks.");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
