using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordMixer
{
    class Program
    {
        static void Main(string[] args)
        {


            // user input
            Console.WriteLine("Tähtede vahetus sõnades");
            Console.WriteLine();
            Console.WriteLine("Sisesta lause, eraldades sõnad tühikuga: ");
            string input = Console.ReadLine();

            // eralda sõnad
            string[] words = input.Split(null);
            string subword;

            Console.WriteLine();

            foreach (string word in words)
            {
                // eemalda sõna esimene ja viimane täht
                int lastIndex = word.Length - 1;
                subword = word.Substring(1, word.Length - 2);
                int distinct = subword.Distinct().Count();

                // shuffle meetod
                string shuffled = Shuffle(subword);

                // kui algne sõna pikem kui 3 tähte ja ei sisalda keskel samu tähti, tee nii kaua, kuni esialgne sõna saab muudetud
                if (subword.Length>1 && distinct>1)
                {
                    while (shuffled == subword)
                    {
                        shuffled = Shuffle(subword);
                    }
                }
                
                // pane esimene ja viimane täht jälle sõnale juurde
                Console.Write(word[0]+shuffled+word[lastIndex]+" ");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }
        static string Shuffle(string unMixed)
        {
            char[] array = unMixed.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return new string(array);
        }
    }
}
