using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher_Textfiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceasari šiffer");
            Console.WriteLine();

            Console.WriteLine("Vali, kas soovid oma sõnumit krüpteerida või dekrüpteerida (1 = krüpteeri / 2 = dekrüpteeri)");
            string choice = Console.ReadLine();

            string userMessage = string.Empty;
            int cipherKey;

            if (choice == "1")
            {
                //krüpteeri failist tekst ja salvesta see teise faili
                userMessage = System.IO.File.ReadAllText(@"C:\Users\marietta.pruuli\KTA17E_prog\src\09_class\DecryptedText.txt");

                Console.Write("Sisesta šifri nihke arv: ");
                string input = Console.ReadLine();
                cipherKey = int.Parse(input);
                string encryptedMessage = Encrypt(userMessage, cipherKey);
                System.IO.File.WriteAllText(@"C:\Users\marietta.pruuli\KTA17E_prog\src\09_class\EncryptedText.txt", encryptedMessage);
            }
            else if (choice == "2")
            {
                // dekrüpteeri failist tekst ja salvesta see teise faili
                userMessage = System.IO.File.ReadAllText(@"C:\Users\marietta.pruuli\KTA17E_prog\src\09_class\EncryptedText.txt");
                Console.Write("Sisesta sifri nihke arv: ");
                string input = Console.ReadLine();
                cipherKey = int.Parse(input);
                string cryptedMessage = Decrypt(userMessage, cipherKey);
                System.IO.File.WriteAllText(@"C:\Users\marietta.pruuli\KTA17E_prog\src\09_class\DecryptedText.txt", cryptedMessage);
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
                    if (newIndex > alphabet.Length - 1)
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
