using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_guessDefinedNumberEquals
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
            if (predefinedNumber == userNumber)
            {
                Console.WriteLine();
                Console.WriteLine("Arvasid numbri ära!");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
