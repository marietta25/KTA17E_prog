using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");
            Console.WriteLine("--------------------------------------------");
            
            List<double> priceList = new List<double>();
            bool continueAsk = true;
            while (continueAsk)
                {
                Console.Write("Enter price of food item [-1 to quit]: ");
                string input = Console.ReadLine();
                if (input == "-1")
                    break;
                else
                    {
                    double foodPrice = double.Parse(input);
                    priceList.Add(foodPrice);
                    }
                }

            double sum = priceList.Sum();
            double grat = 0.15 * sum;
            double totalPrice = sum - grat;

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Subtotal: €{Math.Round(sum, 2)}");
            Console.WriteLine($"15% Gratuity: €{Math.Round(grat, 2)}");
            Console.WriteLine($"Total: €{Math.Round(totalPrice, 2)}");
            
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
