using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class RPCLS
    {
        public float d;
        public Player PlayerOne;
        public Player PlayerTwo;

        public RPCLS()
        {

        }
        public void Formula()
        {
            d = (5 + PlayerOne.MakeChoice - PlayerTwo.MakeChoice) % 5;
            if (d == 1 || d >= 3)
            {

            }
        }
    }
}
