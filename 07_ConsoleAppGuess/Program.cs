using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConsoleAppGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);

            Console.Write("Sisesta number: ");

            string input1 = Console.ReadLine();
            int inputNumber1 = int.Parse(input1);

            if (inputNumber1 > number)
            {
                Console.WriteLine("Sinu valitud number on suurem");
            }
            if (inputNumber1 < number)
            {
                Console.WriteLine("Sinu valitud number on väiksem");
            }
            if (inputNumber1 == number)
            {
                Console.WriteLine("Õige!");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
