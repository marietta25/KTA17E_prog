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
            Console.WriteLine("See on allahindluse arvutamise programm");
            Console.Write("Kas oled püsiklient või tavaklient? (Püsiklient/Tavaklient)");
            string client = Console.ReadLine();

            Console.Write("Sisesta summa eurodes");
            string sumText = Console.ReadLine();
            int sum = int.Parse(sumText);

            int salePercent = 0;
            
            if (client == "Tavaklient" && sum > 50 && sum < 250)
            {
                salePercent = 10;
            }
            else if (client == "Tavaklient" && sum >= 250 && sum < 350)
            {
                salePercent = 20;
            }
            else if (client == "Tavaklient" && sum >= 350)
            {
                salePercent = 30;
            }


            if (client == "Püsiklient" && sum > 50 && sum < 250)
            {
                salePercent = 20;
            }
            else if (client == "Püsiklient" && sum >= 250 && sum < 350)
            {
                salePercent = 30;
            }
            else if (client == "Püsiklient" && sum >= 350)
            {
                salePercent = 40;
            }

            double payment = sum - (sum * salePercent * 0.01);

            Console.WriteLine(client+":");
            Console.WriteLine("Allahindlus: " + salePercent + "%");
            Console.WriteLine("Tasuda: " + payment + "€");

            Console.ReadLine();
        }
    }
}
