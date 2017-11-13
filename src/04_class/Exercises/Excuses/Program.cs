using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excuses
{
    class Program
    {
        static void Main(string[] args)
        {
            //excuses
            
            Console.WriteLine("Sisesta komadega eraldatud vabandused: ");
            Console.Write("> ");

            var input = Console.ReadLine();
            var userText = input.Split(',');

            int random = new Random().Next(0, userText.Length);

            Console.WriteLine("Tänane vabandus on: " + userText[random]);
            Console.ReadLine();           
        }
    }
}
