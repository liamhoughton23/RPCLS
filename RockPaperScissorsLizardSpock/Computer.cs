using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Player
    {
        public Random rnd;
        
        public Computer()
        {
            rnd = new Random();
        }
        public override int MakeChoice()
        {
            name = "Computer";
            value = rnd.Next(0, 4);
            return value;

        }
    }
}
