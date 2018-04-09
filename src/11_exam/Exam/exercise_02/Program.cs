using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Kaur", "Mattias", "Kristel", "Heleri", "Trevor", "Kristjan", "Kelli",
                "Kevin", "Maarika", "Laura" };

            Console.WriteLine("Prindin eelnevalt defineeritud nimed muu teksti seas suure algustähega");
            Console.WriteLine();
            Console.WriteLine("Sisesta soovitud tekst: ");
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
