using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prindin välja sisestatud nimed suure algustähega");
            Console.WriteLine();
            Console.WriteLine("Sisesta nimesid.  Lõpetamiseks ja sisestatud nimede nägemiseks sisesta: -1");
            Console.WriteLine("");

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
