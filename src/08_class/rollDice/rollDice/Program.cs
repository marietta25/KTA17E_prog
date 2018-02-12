using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rollDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();

            int rolledSide;
            int sum = 0;

            Console.WriteLine("/roll 3d6 2d8");
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                rolledSide = dice.Roll(6);
                Console.WriteLine($"1d6: {rolledSide}");
                sum += rolledSide;
            }
            
            for (int i = 0; i < 2; i++)
            {
                rolledSide = dice.Roll(8);
                Console.WriteLine($"1d8: {rolledSide}");
                sum += rolledSide;
            }

            Console.WriteLine();
            Console.WriteLine($"Roll total: {sum}");
            Console.WriteLine();
            Console.Write("> ");

            Console.ReadKey();
        }
    }
}
