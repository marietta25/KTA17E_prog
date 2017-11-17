using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tere, teeme programmeerimiseks soojendust");
            Console.WriteLine("Kirjuta mulle midagi: ");
            string input = Console.ReadLine();

            Console.WriteLine($"Selge - {input}");
            Console.ReadLine();
        }
    }
}
