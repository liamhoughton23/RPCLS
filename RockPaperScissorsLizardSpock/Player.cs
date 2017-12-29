using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    abstract class Player
    {
        public int score;
        public int roundsWon;
        public int value;
        public Player()
        {
            score = 0;
            roundsWon = 0;
        }
        public abstract int MakeChoice();


    }
}
