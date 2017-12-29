using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class RPCLS
    {
        public float resultFormula;
      
        

        public void Formula(Player playerOne, Player playerTwo)
        {
         resultFormula = (5 + playerOne.value - playerTwo.value) % 5;
        if (resultFormula == 1 || resultFormula == 3)//|| 3 >= playerOne.value)
        {
                playerOne.roundsWon++;
                Console.WriteLine("Player one wins that round!");
                Console.ReadLine();
                


            }
        else if (resultFormula == 2 || resultFormula == 4)//|| 4 >= playerTwo.value)
            {
                playerTwo.roundsWon++;
                Console.WriteLine("Player two wins that round!");
                Console.ReadLine();
                
            }
            else
            {
                Console.WriteLine("Its a tie!");
                Formula(playerOne, playerTwo);
            }
        }

        public void CompareScore(Player playerOne, Player playerTwo)
        {
            if (playerOne.roundsWon >= 2)
            {
                Console.WriteLine("Player one wins!");
            }
            else if (playerTwo.roundsWon >= 2)
            {
                Console.WriteLine("Player two wins!");
            }
            else
            {
                playerOne.MakeChoice();
                playerTwo.MakeChoice();
            }
        }
    }
}
