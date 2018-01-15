using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mingi arv etteantud sõnu
            //arvuti valib suvaliselt sõna
            //mängija pakub tähti
            //kindel arv kordi valesti pakkumisest

            Console.WriteLine("Valin välja ühe sõna.");
            Console.WriteLine("Sina hakka tähti pakkuma.");
            Console.WriteLine();

            List<string> words = new List<string> { "raamatukogu", "taevas", "rohutirts", "ploomipuu", "linnapea", "kassipoeg", "suurettevõte", "aplikatsioon", "universum", "korsten"};

            int random = new Random().Next(0, words.Count);
            string word = words[random];

            //mitu tähte sõnas
            int characters = word.Length;

            StringBuilder sb = new StringBuilder(word);

            //prindi välja kriipsud
            for (var i = 1; i <= characters; i++)
            {
                Console.Write("_ ");
            }

            Console.WriteLine();
            Console.Write("Paku täht: ");

            string character = Console.ReadLine();
            List<string> userInput = new List<string>();
            userInput.Add(character);

            var foundIndexes = new List<int>();

            int index = 0;
            for (var i = 0; i < word.Length; i++)
            {
                index = word.IndexOf(character);
                foundIndexes.Add(index);
            }
            
            //sb[word[foundIndexes[0]]] = character;
            Console.WriteLine(word[foundIndexes[0]]);


            Console.WriteLine(word);

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
