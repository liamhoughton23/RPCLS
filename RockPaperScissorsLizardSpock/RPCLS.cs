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
        if (resultFormula == 1 || resultFormula == 3)

           {
                playerOne.roundsWon++;
                Console.WriteLine(playerOne.name + " " + "wins that round!");
                Console.ReadLine();
                CompareScore(playerOne, playerTwo);



            }
        else if (resultFormula == 2 || resultFormula == 4)
            {
                playerTwo.roundsWon++;
                Console.WriteLine(playerTwo.name + " " + "wins that round!");
                Console.ReadLine();
                CompareScore(playerOne, playerTwo);

            }
            else
            {
                Console.WriteLine("Its a tie!");
                playerOne.MakeChoice();
                playerTwo.MakeChoice();
                Formula(playerOne, playerTwo);
            }
        }

        public void CompareScore(Player playerOne, Player playerTwo)
        {
            if (playerOne.roundsWon >= 2)
            {
                Console.WriteLine( playerOne.name + "  " + "wins!");
                Console.ReadLine();
            }
            else if (playerTwo.roundsWon >= 2)
            {
                Console.WriteLine(playerTwo.name + " " + "wins!");
                Console.ReadLine();
            }
            else
            {
                playerOne.MakeChoice();
                playerTwo.MakeChoice();
                Formula(playerOne, playerTwo);
            }
        }
    }
}
