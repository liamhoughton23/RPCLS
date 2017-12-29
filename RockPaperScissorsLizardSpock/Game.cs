using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        public Player playerOne;
        public Player playerTwo;
        public string option;

        public Game()
        {
            Console.WriteLine("Welcome to rock paper scissors lizard spock.");
            Console.ReadKey();
            Console.WriteLine("The game is simple, pick rock paper scissors or spock, and see if you win the round.");
            Console.ReadKey();
            Console.WriteLine("Best 2 out of 3 wins");
            Console.ReadKey();
            PlayGame();

        }

        public void OptionPlayers()
        {
            Console.WriteLine("Please emter '1' for one player, and enter '2' for two players");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    playerOne = new User();
                    playerTwo = new Computer();
                    break;
                case "2":
                    playerOne = new User();
                    playerTwo = new User();
                    break;
                default:
                    Console.WriteLine("You typed in something wrong, try again.");
                    OptionPlayers();
                    break;

            }
        }
        //method for playing the game
        //playerone make choice
        //playertwo make choice
        //use RPCLS class to determine who won the round

        
        public void PlayGame()
        {
            OptionPlayers();
            playerOne.MakeChoice();
            playerTwo.MakeChoice();
            RPCLS rpcls = new RPCLS();
            rpcls.Formula(playerOne, playerTwo);
        }

    }
}
