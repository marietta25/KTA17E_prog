using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_guessPredefinedNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int predefinedNumber = 42;

            Console.WriteLine("Ma valin välja ühe suvalise numbri vahemikus [1 – 100]. Proovi see ära arvata.");
            Console.WriteLine();
            Console.Write("Sisesta number: ");

            string input = Console.ReadLine();
            int userNumber = int.Parse(input);

            if (predefinedNumber > userNumber)
            {
                Console.WriteLine();
                Console.WriteLine("Arvuti valitud number on suurem");
            }
            if (predefinedNumber < userNumber)
            {
                Console.WriteLine();
                Console.WriteLine("Arvuti valitud number on väiksem");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
