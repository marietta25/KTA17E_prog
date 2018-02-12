using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rollDice
{
    class Dice
    {
        private Random rand = new Random();

        public int Roll(int sides)
        {
            int rolled = rand.Next(1, sides+1);
            return rolled;
        }
    }
}
