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
            Console.WriteLine("Korrutustabel 6x6");
            Console.WriteLine("------------------");
            //Console.WriteLine("X | 1 | 2 | 3 | 4 | 5 | 6 |");

            int i, j;
            for (i = 0; i < 7; i++)
            {
                Console.Write(i + "\t");
                for (j = 0; j < 7; j++)
                {
                    int row = i * j;
                    if (i > 0)
                        Console.Write(i * j + "\t");
                    else
                        Console.Write(j + "\t");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
