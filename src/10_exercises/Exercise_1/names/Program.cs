using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace names
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta nimi: ");
            Console.WriteLine("Lõpeta ja prindi sisestatud nimed: -1");

            string input;
            List<string> names = new List<string> { };

            while (true)
            {
                input = Console.ReadLine();

                if (input != "-1")
                {
                    input = char.ToUpper(input[0]) + input.Substring(1);
                    names.Add(input);
                }
                else if (input == "-1")
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        Console.WriteLine(names[i]);
                    }
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
