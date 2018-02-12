using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mingi arv etteantud sõnu
            //arvuti valib suvaliselt sõna
            //mängija pakub tähti
            //kindel arv kordi valesti pakkumisi

            Console.WriteLine("Valin välja ühe sõna.");
            Console.WriteLine("Sina hakka tähti pakkuma. Valesti saad arvata 5 korda.");
            Console.WriteLine();

            List<string> words = new List<string> { "raamatukogu", "taevas", "rohutirts", "ploomipuu", "linnapea", "kassipoeg", "suurettevõte", "aplikatsioon", "universum", "korsten" };

            int random = new Random().Next(0, words.Count);
            string word = words[random].ToUpper();

            //prindi sõna pikkuselt välja tärnid
            StringBuilder sb = new StringBuilder(word.Length);

            for (var i = 0; i < word.Length; i++)
            {
                sb.Append("*");
            }

            Console.WriteLine(sb.ToString());
            Console.WriteLine();

            StringBuilder rightGuesses = new StringBuilder();
            StringBuilder wrongGuesses = new StringBuilder();

            // 5 elu
            int tries = 5;

            bool hasWon = false;
            int visibleChars = 0;

            string input;
            char guessedChar;

            while (!hasWon && (tries > 0))
            {
                Console.WriteLine();
                Console.Write("Paku täht: ");

                input = Console.ReadLine().ToUpper();
                guessedChar = input[0];

                if (word.Contains(guessedChar))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Pakutud täht '{guessedChar}' on sõnas olemas");
                    rightGuesses.Append(guessedChar);
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == guessedChar)
                        {
                            sb[i] = word[i];
                            visibleChars++;
                        }
                    }
                    if (visibleChars == word.Length)
                    {
                        hasWon = true;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Pakutud tähte '{guessedChar}' sõnas ei sisaldu");
                    wrongGuesses.Append(guessedChar);
                    tries--;
                }
                Console.WriteLine();
                Console.WriteLine(sb.ToString());
                Console.WriteLine($"Õigesti pakutud tähed: {rightGuesses.ToString()}; Valesti pakutud tähed: {wrongGuesses.ToString()}");
            }

            Console.WriteLine();

            if (hasWon)
            {
                Console.WriteLine("Arvasid sõna ära! Võitsid mängu!");
            }
            else
            {
                Console.WriteLine($"Kaotasid mängu! Otsitav sõna oli {word}");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        
        }
    }
}
