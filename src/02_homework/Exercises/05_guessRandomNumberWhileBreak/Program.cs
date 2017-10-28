using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_guessRandomNumberWhileBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);

            Console.WriteLine("Ma valin välja ühe suvalise numbri vahemikus [1 – 100]. Proovi see ära arvata.");

            bool haventGuessed = true;
            while (haventGuessed)
            {
                Console.WriteLine();
                Console.Write("Sisesta number: ");

                string input = Console.ReadLine();
                int userNumber = int.Parse(input);

                if (randomNumber > userNumber)
                {
                    Console.WriteLine();
                    Console.WriteLine("Arvuti valitud number on suurem");
                }
                if (randomNumber < userNumber)
                {
                    Console.WriteLine();
                    Console.WriteLine("Arvuti valitud number on väiksem");
                }
                if (randomNumber == userNumber)
                {
                    Console.WriteLine();
                    Console.WriteLine("Arvasid numbri ära!");
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
