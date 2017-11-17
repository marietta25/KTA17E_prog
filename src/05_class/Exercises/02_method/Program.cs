using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_method
{
    class Program
    {
        static void Main(string[] args)
        {
            DoSomeThing("midagi");
            PrintWord();
            Console.ReadLine();
        }
        static void DoSomeThing(string word)
        {
            Console.WriteLine($"Teen {word}");
        }
        static string PrintWord()
        {
            Console.Write("Kirjuta natuke: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Sa kirjutasid {input}");
            return input;
        }
    }
}
