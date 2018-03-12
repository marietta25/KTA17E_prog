using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cipher cipher = new Cipher();

            Console.WriteLine("Ceasari šiffer");
            Console.WriteLine();

            Console.Write("Vali, kas soovid teksti krüpteerida või dekrüpteerida (1 = krüpteeri / 2 = dekrüpteeri): ");
            Console.WriteLine();
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
                string encryptedMessage = cipher.Encrypt(userMessage, cipherKey);
                System.IO.File.WriteAllText(@"C:\Users\marietta.pruuli\KTA17E_prog\src\09_class\EncryptedText.txt", encryptedMessage);
            }
            else if (choice == "2")
            {
                // dekrüpteeri failist tekst ja salvesta see teise faili
                userMessage = System.IO.File.ReadAllText(@"C:\Users\marietta.pruuli\KTA17E_prog\src\09_class\EncryptedText.txt");
                Console.Write("Sisesta sifri nihke arv: ");
                string input = Console.ReadLine();
                cipherKey = int.Parse(input);
                string cryptedMessage = cipher.Decrypt(userMessage, cipherKey);
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
    }
}
