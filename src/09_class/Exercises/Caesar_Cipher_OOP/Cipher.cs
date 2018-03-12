using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher_OOP
{
    class Cipher
    {
        string alphabet = "ABCDEFGHIJKLMNOPQRSŠZŽTUVWÕÄÖÜXY";
        int newIndex = 0;
        char newCharacter;

        public string Encrypt(string message, int key)
        {
            string crypted = string.Empty;
            message = message.ToUpper();

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

        public string Decrypt(string message, int key)
        {
            string decrypted = string.Empty;
            message = message.ToUpper();

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
