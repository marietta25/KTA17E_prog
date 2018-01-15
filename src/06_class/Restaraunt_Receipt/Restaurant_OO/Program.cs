using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            

            Restaraunt restaraunt = new Restaraunt("Taco Palenque", "1200 Main ST.");

            Tab tab = new Tab();

            tab.Add(7.99);
            tab.Add(6.55);
            tab.Add(2.345);

            Receipt receipt = restaraunt.GetReceipt(tab);

            Console.Write(receipt);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        static List<Int32> GetReceipt(List<Int32> tab)
        {
            double sum = tab.Sum();
            sum = Math.Round(sum);
            double grat = 0.15 * sum;
            grat = Math.Round(grat);
            double totalPrice = sum - grat;
            totalPrice = Math.Round(totalPrice);
        }
    }
}
