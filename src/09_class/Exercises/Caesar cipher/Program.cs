using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceasari šiffer");
            Console.WriteLine();

            Console.WriteLine("vali, kas soovid oma sõnumit krüpteerida või dekrüpteerida (1 = krüpteeri / 2 = dekrüpteeri)");
            string choice = Console.ReadLine();

            string userMessage = string.Empty;
            int cipherKey;

            if (choice == "1")
            {
                //krüpteeri kasutaja sisend
                Console.WriteLine("Sisesta sõnum krüpteerimiseks: ");
                userMessage = Console.ReadLine();
                Console.Write("Sisesta šifri nihke arv: ");
                string input = Console.ReadLine();
                cipherKey = int.Parse(input);
                string encryptedMessage = Encrypt(userMessage, cipherKey);
                Console.WriteLine(encryptedMessage);
            }
            else if (choice == "2")
            {
                // dekrüpteeri kasutaja sisend
                Console.WriteLine("Sisesta sõnum dekrüpteerimiseks: ");
                userMessage = Console.ReadLine();
                Console.Write("Sisesta sifri nihke arv: ");
                string input = Console.ReadLine();
                cipherKey = int.Parse(input);
                string cryptedMessage = Decrypt(userMessage, cipherKey);
                Console.WriteLine(cryptedMessage);
            }
            else
            {
                Console.WriteLine("Ei saanud su soovist aru");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }

        public static string Encrypt(string message, int key)
        {
            string alphabet = "abcdefghijklmnopqrsšzžtuvwõäöüxy";
            string crypted = string.Empty;
            int newIndex = 0;
            char newCharacter;

            foreach (var character in message)
            {
                if (!char.IsLetter(character))
                {
                    crypted += character;
                }
                else
                {
                    newIndex = alphabet.IndexOf(character) + key;
                    
                    // kui indeks jääb tähestiku piiridest välja
                    if (newIndex > alphabet.Length-1)
                    {
                        newIndex = newIndex - alphabet.Length;
                    }
                    newCharacter = alphabet[newIndex];
                    crypted += newCharacter;
                }
            }
            return crypted;
        }
        public static string Decrypt(string message, int key)
        {
            string alphabet = "abcdefghijklmnopqrsšzžtuvwõäöüxy";
            string decrypted = string.Empty;
            int newIndex = 0;
            char newCharacter;

            foreach (var character in message)
            {
                if (!char.IsLetter(character))
                {
                    decrypted += character;
                }
                else
                {
                    newIndex = alphabet.IndexOf(character) - key;

                    // kui indeks jääb tähestiku piiridest välja
                    if (newIndex < 0)
                    {
                        newIndex = newIndex + alphabet.Length;
                    }
                    newCharacter = alphabet[newIndex];
                    decrypted += newCharacter;
                }
            }
            return decrypted;
        }
    }
}
