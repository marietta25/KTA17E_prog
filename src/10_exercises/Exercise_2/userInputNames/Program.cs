using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userInputNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Kaur", "Mattias", "Kristel", "Heleri", "Trevor", "Kristjan", "Kelli",
                "Kevin", "Maarika", "Laura" };

            Console.WriteLine("Sisesta soovitud sõnad, lause või laused: ");
            Console.WriteLine();
            string input = Console.ReadLine();

            string[] words = input.Split(null);

            foreach (var word in words)
            {
                string firstUpper = char.ToUpper(word[0]) + word.Substring(1);
                if (names.Any(firstUpper.Contains))
                {
                    Console.Write(firstUpper + " ");
                }
                else
                {
                    Console.Write(word + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
