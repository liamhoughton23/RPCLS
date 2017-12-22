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

        public override int MakeChoice()
        {
            int result;
            result = rnd.Next(0, 4);
            return result;

        }
    }
}
